using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class PurchaseInvoiceDetails : Sample2
    {
        public PurchaseInvoiceDetails()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        int productID;

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }
        public override void backButton_Click(object sender, EventArgs e)
        {
            PurchaseInvoice obj = new PurchaseInvoice();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        private void PurchaseInvoiceDetails_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            dataGridView1.AutoGenerateColumns = false;
            r.getListWithTwoParameters("st_getPurchaseInvoiceList", purchaseDD, "Company", "ID", "@month", datePicker.Value.Month, "@year", datePicker.Value.Year);
        }

        private void purchaseDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(purchaseDD.SelectedIndex != -1 && purchaseDD.SelectedIndex != 0)
            {
                float gt = 0;
                r.showPurchaseInvoiceDetails(Convert.ToInt64(purchaseDD.SelectedValue.ToString()),dataGridView1 , mPIDgv, productIDGV, productGV, quantityGV, pupGV, totalGV);
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossLabel.Text = gt.ToString();
                gt = 0;
            }
        }

        insertion i = new insertion();
        updation u = new updation();
        deletion d = new deletion();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 6)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete" + row.Cells["productGV"].Value.ToString() + " from purchase invoice? \n \t\t\t WARNING \n DELETION OF PRODUCT WILL EFFECT STOCK", "Question...",MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                    int q;
                    if (dr == DialogResult.Yes)
                    {
                        using(TransactionScope sc = new TransactionScope())
                        {
                            i.insertDeletedItem(Convert.ToInt64(purchaseDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), retrieval.USER_ID, DateTime.Today);
                            object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                            if (ob != null)
                            {
                                q = Convert.ToInt32(ob);
                                q -= Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                                u.updateStock(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), q);
                                float tot = Convert.ToSingle(grossLabel.Text) - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                                
                              grossLabel.Text = tot.ToString();
                                d.delete(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()) , "st_deleteProductFromPID" , "@mPID");
                                dataGridView1.Rows.Remove(row);
                            }
                            sc.Complete();
                        }
                      
                    }
                }
            }
        }

        private void searchTEXT_TextChanged_1(object sender, EventArgs e)
        {
            if (searchTEXT.Text != "")
            {
                r.showPurchaseInvoiceDetails(productID, dataGridView1, mPIDgv, productIDGV, productGV, quantityGV, pupGV, totalGV, searchTEXT.Text);
            }
            else
            {
                r.showPurchaseInvoiceDetails(productID, dataGridView1, mPIDgv, productIDGV, productGV, quantityGV, pupGV, totalGV);
            }
        }
    }
}
