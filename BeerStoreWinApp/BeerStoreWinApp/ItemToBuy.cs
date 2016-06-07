using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerStoreWinApp
{
    public partial class ItemToBuy : UserControl
    {
        // define variables
        string ImagePath;
        ShoppingCart theShoppersCart = new ShoppingCart();

        // class members
        int ID;
        string name;
        string description;
        int x_pos;
        int y_pos;
        string imageFilename;
        decimal price;

        public struct cartItem
        {
            public string ID;
            public string name;
            public string description;
            public int quantity;
            public decimal price;
        }
        public ItemToBuy()
        {
            InitializeComponent();
        }
        public ItemToBuy(int _ID, string _name, string _description, string _imageFilename, decimal _price)
        {
            InitializeComponent();
            //ImagePath = @"C:\Users\tlyde\Documents\C# Course\CodeSamples\BeerStoreRepos\BeerStoreWinApp\BeerStoreWinApp\Images\";
            ImagePath = @"C:\Users\jcerezo\Documents\Visual Studio 2015\Projects\BeerStoreRepos\BeerStoreWinApp\BeerStoreWinApp\Images\";
            ID = _ID;
            name = _name;
            Name = name.Replace(" ", "");
            description = _description;
            imageFilename = _imageFilename;
            price = _price;
            this.label_name.Text = name;
            this.richTextBox_description.Text = description;
            this.pictureBox1.ImageLocation = ImagePath + _imageFilename;
        }



        private void button_addBeerToCart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to add this beer to your cart??", 
                "Add to Cart", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // add to cart
                cartItem itemToAdd = new cartItem();
                itemToAdd.ID = ID.ToString() + "_" + name;
                itemToAdd.description = description;
                itemToAdd.name = name;
                itemToAdd.quantity = int.Parse(this.domainUpDown_quantity.SelectedItem.ToString());
                itemToAdd.price = price;
                theShoppersCart.addToCart(itemToAdd);
            }
        }
    }
}
