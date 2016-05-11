using System.Windows.Forms;
using System.Collections.Generic;

namespace BeerStoreWinApp
{
    public sealed partial class ShoppingCart : Form
    {
        // only want 1 instance of the shopping cart for the 1 user
        static readonly ShoppingCart _instance = new ShoppingCart();

        
        // define needed variables
        static List<ItemToBuy.cartItem> shoppingCartList = new List<ItemToBuy.cartItem>();


        public static ShoppingCart Instance
        {
            get
            {
                return _instance;
            }
        }

        public void addToCart(ItemToBuy.cartItem itemToAdd)
        {
            shoppingCartList.Add(itemToAdd);
        }


        ShoppingCart()
        {
            InitializeComponent();
        }


    }
}
