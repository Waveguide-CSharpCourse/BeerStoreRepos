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
        ShoppingCart theShoppersCart;

        public StuffToBuy()
        {
            InitializeComponent();
            AddBeerItemsToPage();
            AddJunkFoodItemsToPage();
        }

        // define variables
        //ShoppingCart theShoppingCart = new ShoppingCart();

        private void button_viewCart_Click(object sender, EventArgs e)
        {
            theShoppersCart = new ShoppingCart();
            theShoppersCart.Show();
        }


        private void AddBeerItemsToPage()
        {
            // connect to the database and get the table of beer items then add to page
            DataTable beerItems = localBeerDataObj.getBeerData();
            int width = 250;
            int height = 300;

            // loop thru each beer item (row) and add to page
            int X_index = 0;
            int Y_index = 0;
            foreach (DataRow aRow in beerItems.Rows)
            {
                ItemToBuy newBeerItem = new ItemToBuy((int)aRow[0], aRow[1].ToString(), aRow[2].ToString(), aRow[3].ToString());
                int xcoord = 25 + (X_index * width);
                int ycoord = 40 + (Y_index * height);
                newBeerItem.Location = new System.Drawing.Point(xcoord, ycoord);
                this.tabPage_Beer.Controls.Add(newBeerItem);
                X_index++;
                if (xcoord > 500)    // start new row
                {
                    Y_index++;
                    X_index = 0;
                }
            }

        }


        private void AddJunkFoodItemsToPage()
        {
        }


    }
}
