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
    public partial class HomePage : Form
    {

        // define variables
        StuffToBuy localStuffToBuy;
        UserAccount shopper;
        public static string DBPath;

        public HomePage()
        {
            InitializeComponent();
            DBPath = Application.StartupPath;
            shopper = new UserAccount();

        }

        private void button_shopForBeer_Click(object sender, EventArgs e)
        {
            localStuffToBuy = new StuffToBuy();
            localStuffToBuy.Show();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            shopper.Show();
        }
    }
}
