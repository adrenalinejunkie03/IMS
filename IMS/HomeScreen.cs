using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u,this,MDI.ActiveForm);
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            Categories u = new Categories();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void productDD_Click(object sender, EventArgs e)
        {
            Products u = new Products();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
           // userLabel.Text = retrieval.EMP_NAME;

            MDI m = new MDI();
            m.logoutToolStripMenuItem.Enabled = true;
            userLabel.Text = retrieval.EMP_NAME;
        }

        private void supplierButton_Click(object sender, EventArgs e)
        {
            Supplier u = new Supplier();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            PurchaseInvoice u = new PurchaseInvoice();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Stocks u = new Stocks();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            Sales u = new Sales();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            ProductPricing u = new ProductPricing();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void salesReturnbutton_Click(object sender, EventArgs e)
        {
            SalesReturnWindow u = new SalesReturnWindow();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }
    }
}
