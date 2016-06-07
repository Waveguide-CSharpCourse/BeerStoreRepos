using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerStoreWinApp
{
    public partial class StuffToBuy : Form
    {
        // define variables
        BeerData localBeerDataObj = new BeerData();
        internal ShoppingCart theShoppersCart = ShoppingCart.Instance;

        public StuffToBuy()
        {
            InitializeComponent();
            this.tabControl.Selected += Tab_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            DrawPageByIndex(this.tabControl.SelectedIndex);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RedrawActivePage();
        }
       
        private void Tab_Click(object sender, TabControlEventArgs e)
        {
            // DrawPageByIndex(e.TabPageIndex);
            DrawPage(e.TabPage);
        }

        /// <summary>
        /// Will draw ItemsToBuy on target page.
        /// </summary>
        /// <param name="Page"> Target page to draw</param>
        private void DrawPage(TabPage Page)
        {
            DrawPageByIndex(Page.TabIndex);   
        }

        /// <summary>
        /// Will draw ItemsToBuy on target page using index number in tab control.
        /// </summary>
        /// <param name="PageIndex">Index reference number page use in tab control</param>
        private void DrawPageByIndex(int PageIndex)
        {
            var Page = this.tabControl.TabPages[PageIndex]; // Get page object
            RemoveAllItemstoBuy(Page); //Remove all ItemsToBuy objects in this page.

            switch ((ePage)PageIndex) // Lookup page index and add items to that page. 
            {
                case (ePage.BeerPage):
                    {
                        AddItemsToPage(ePage.BeerPage);
                        break;
                    }
                case (ePage.MunchiesPage):
                    {
                        AddItemsToPage(ePage.MunchiesPage);
                        break;
                    }
            }
        }

        /// <summary>
        /// Will redraw ItemsToBuy objects on active page
        /// </summary>
        private void RedrawActivePage()
        {
            RedrawPage(this.tabControl.SelectedIndex);
        }

        /// <summary>
        /// Will redraw ItemsToBuy objects on target page using index number in tab control
        /// </summary>
        /// <param name="PageIndex">Index reference number use in tab control</param>
        private void RedrawPage(int PageIndex)
        {
            switch (PageIndex)
            {
                case (0):
                    {
                        RedrawItemsToBuy(this.tabPage_Beer);
                        break;
                    }
                case (1):
                    {
                        RedrawItemsToBuy(this.tabPage_Munchies);
                        break;
                    }
            }
        }

        /// <summary>
        /// Will redraw all ItemsToBuy object in the page
        /// </summary>
        /// <param name="Page">Tabpage target where ItemsToBuy objects will be redraw</param>
        private void RedrawItemsToBuy(TabPage Page)
        {

            List<int> ControlItems = new List<int>();
            List<LayoutPoint> Layout = new List<LayoutPoint>();

            if (Page.Controls.Count > 0)
            {

                foreach (Control Item in Page.Controls)
                {
                    if (Item.GetType() == typeof(ItemToBuy))
                    {
                        ControlItems.Add(Item.TabIndex);
                    }
                }

                Layout = CalculateWLayoutPoints(Page.Width, ControlItems.Count);

                if (ControlItems.Count > 0)
                {
                    int counter = 0;
                    foreach (int item in ControlItems)
                    {
                        Page.Controls[item].Location = Layout[counter].Location;
                        counter++;
                    }
                }

            }
        }

        private void button_viewCart_Click(object sender, EventArgs e)
        {

            try
            {
                theShoppersCart.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + "\r" + ex.Data , "Shopping Cart Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        private void AddItemsToPage(ePage Page)
        {
            DataTable Data = new DataTable();

            try
            {
                switch (Page)
                {
                    case (ePage.BeerPage):
                        {
                            Data = localBeerDataObj.getBeerData();
                            break;
                        }
                    case (ePage.MunchiesPage):
                        {
                            Data = localBeerDataObj.getMunchiesData();
                            break;
                        }
                }

                DrawItemsToBuy(Data, this.tabControl.TabPages[(int)Page]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Source, ex.Message + ":\r" + ex.Data, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawItemsToBuy(DataTable Data, TabPage Page)
        {
            
            int count = Data.Rows.Count;

            if(count > 0)
            {

                List<LayoutPoint> Layout = CalculateWLayoutPoints(  Page.Width, 
                                                                    count);

                count = 0;

                foreach (DataRow item in Data.Rows)
                {
                    ItemToBuy newItem = new ItemToBuy((int)item[(int)eField.id],
                                                            item[(int)eField.name].ToString(),
                                                            item[(int)eField.description].ToString(),
                                                            item[(int)eField.image].ToString());

                    newItem.Location = Layout[count].Location;
                    Page.Controls.Add(newItem);
                    count++;
                }
            }
            
        }
        
        private void RemoveAllItemstoBuy(TabPage Page)
        {

            int target = Page.Controls.Count;
            int current = 0;
            if (target > 0)
            {
                for (int cnt = 0; cnt < target; cnt++)
                {
                    if (Page.Controls[current].GetType() == typeof(ItemToBuy))
                    {
                        Page.Controls.RemoveAt(current);
                    }
                    else
                    {
                        current++;
                    }
                }

                Page.Refresh();
            }
        }

        private List<LayoutPoint> CalculateWLayoutPoints(int Width, int TotalItems)
        {
            return CalculateWLayoutPoints(Width, TotalItems, new Point(20, 60), new Size(250, 300));
        }

        private List<LayoutPoint> CalculateWLayoutPoints(int Width, int TotalItems, Point WHPadItem, Size SizeItem) {

            
            int width = SizeItem.Width;
            int height = SizeItem.Height;
            int xPadding = WHPadItem.X;
            int yPadding = WHPadItem.Y;

            List<LayoutPoint> ReturnList = new List<LayoutPoint>();

            if (TotalItems > 0)
            {
                int MaxColumns = Width / (width + (xPadding * 2));
                if ((Width % (width + (xPadding * 2))) > xPadding)
                {
                    MaxColumns++;
                }
                if (MaxColumns == 0) MaxColumns = 1;
                

                for (int counter = 1; counter <= TotalItems; counter++)
                {
                    int x = counter % MaxColumns;
                    if (x == 0)
                    {
                        x = (MaxColumns - 1) * width;
                    }
                    else
                    {
                        x = (x - 1) * width;
                    }

                    int y = ((counter - 1) / MaxColumns) * height;

                    x += xPadding;
                    y += yPadding;

                    ReturnList.Add(new LayoutPoint(new Point(x, y), counter));
                }

            }
            else
            {
                ReturnList.Add(new LayoutPoint(new Point(xPadding, yPadding), 0));
            }

            return ReturnList;

        }

        private Size CalculateParentResize(Size Parent, Size Item, int TotalItems ) {
            Size NewSize = new Size(Parent.Width, Parent.Height);

            if ((TotalItems > 0) && (Item.Width > 10) && (Item.Height > 10))
            {
                int MaxColums = Parent.Width / Item.Width ;
                if ((Parent.Width % Item.Width) > 0) MaxColums++;
                if (MaxColums == 0) MaxColums = 1;
                double diff = (Item.Width * MaxColums) - Parent.Width;

                if(diff > ((Item.Width/2)*1)) NewSize.Width = Item.Width * MaxColums;

                int MaxRows = Parent.Height / Item.Height;
                if ((Parent.Height % Item.Height) > 0) MaxRows++;
                if (MaxRows == 0) MaxRows = 1;
                diff = (Item.Height * MaxRows) - Parent.Height;

                if (diff > ((Item.Height / 2) * 1)) NewSize.Height = Item.Height * MaxRows;
            }

            return NewSize;
        }

        private DataTable FakeBigDataTable() {
            DataTable BDT = new DataTable();
            DataTable smallSample = localBeerDataObj.getBeerData();
            int id = 0;

            BDT.Columns.Add("ID",typeof(int));
            BDT.Columns.Add("NAME", typeof(string));
            BDT.Columns.Add("DESCRIPTION", typeof(string));
            BDT.Columns.Add("IMAGE", typeof(string));
            for (int cnt=0;cnt <=5; cnt++)
            {
                foreach (DataRow item in smallSample.Rows) {
                    id++;
                    DataRow row = BDT.NewRow();
                    row["ID"] = id;
                    row["NAME"] = item[(int)eField.name];
                    row["DESCRIPTION"] = item[(int)eField.description];
                    row["IMAGE"] = item[(int)eField.image];
                    BDT.Rows.Add(row);
                }

            }
            return BDT;
        }

        private enum eField
        {
            id = 0,
            name = 1,
            description = 2,
            image = 3,
            price = 4,
            stock =5,                       
        };

        private enum ePage
        {
            BeerPage,
            MunchiesPage,
        }

        private class LayoutPoint
        {
            private Point _Location;
            private int _Index;

            public Point Location
            {
                get { return _Location; }
               // set { _Location = value; }
            }

            public int Index
            {
                get { return _Index; }
            }

            public LayoutPoint(Point Location, int Index) {
                _Location = new Point(Location.X, Location.Y);
                _Index = Index;
            }

        }

        
    }
}
