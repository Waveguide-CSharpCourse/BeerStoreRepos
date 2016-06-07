using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace BeerStoreWinApp
{
    public partial class ShoppingCart : Form
    {        
        // define needed variables
        static List<ItemToBuy.cartItem> shoppingCartList = new List<ItemToBuy.cartItem>();


        public void addToCart(ItemToBuy.cartItem itemToAdd)
        {
            shoppingCartList.Add(itemToAdd);
        }


        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void ShoppingCart_Load(object sender, System.EventArgs e)
        {

        }

    }
}
