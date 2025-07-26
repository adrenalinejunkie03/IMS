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
    public partial class Stocks : Sample2
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            base.addButton.Enabled = false;
            base.editButton.Enabled = false;
            base.deleteButton.Enabled = false;
            base.saveButton.Enabled = false;
        
        }

        public override void addButton_Click(object sender, EventArgs e)
        {

        }

        public override void editButton_Click(object sender, EventArgs e)
        {

        }

        public override void saveButton_Click(object sender, EventArgs e)
        {

        }

        public override void deleteButton_Click(object sender, EventArgs e)
        {

        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTEXT.Text.Trim() != "")
            {
                r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryGV, bpGV, spGV, categoryGV, quantityGV, statusGV, totalGV,searchTEXT.Text);
            }
            else
            {
                r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryGV, bpGV, spGV, categoryGV, quantityGV, statusGV, totalGV);
            }
           
        }

        retrieval r = new retrieval();
        public override void viewButton_Click(object sender, EventArgs e)
        {
     
            r.showStockDetails(dataGridView1, productIDGV, productGV, barcodeGV, expiryGV, bpGV, spGV ,categoryGV, quantityGV, statusGV, totalGV);
        }
    }
}
