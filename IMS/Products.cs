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
    public partial class Products : Sample2
    {
        int edit = 0;
        // this zero is indication to save operation and 1 is an indication to update operation.
        Int64 productID;
        //short stat;
        public Products()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();

        private void Products_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            MainClass.disable_reset(leftPanel);
            r.getList("st_getCategoriesList", categoryDD, "Category", "ID");
        }
        public override void addButton_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
           
        }

        public override void editButton_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveButton_Click(object sender, EventArgs e)
        {
            {
                // in the if condition is the name of (NAME) text box which I didnot write in UI properties
                if (productTEXT.Text == " ") { productErrorLabel.Visible = true; } else { productErrorLabel.Visible = false; }
                if (barcodeTEXT.Text == " ") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
                if (expiryPicker.Value < DateTime.Now) { expiryErrorLabel.Visible = true; expiryErrorLabel.Text = "Invalid date "; } else { expiryErrorLabel.Visible = false; }
                if (expiryPicker.Value.Date == DateTime.Now.Date) { expiryErrorLabel.Visible = false; }

                if (categoryDD.SelectedIndex == -1 || categoryDD.SelectedIndex == 0) { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }

                if (productErrorLabel.Visible || barcodeErrorLabel.Visible || expiryErrorLabel.Visible || categoryErrorLabel.Visible)
                {
                    MainClass.ShowMSG("Fields with * are mandatory", "STOP", "Error"); // Error is type of message
                }
                else
                {


                    if (edit == 0) // code for save operation
                    {

                        insertion i = new insertion();
                        if(expiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            i.insertProduct(productTEXT.Text, barcodeTEXT.Text, Convert.ToInt32(categoryDD.SelectedValue));

                        }
                        else
                        {
                            i.insertProduct(productTEXT.Text, barcodeTEXT.Text, Convert.ToInt32(categoryDD.SelectedValue) , expiryPicker.Value);

                        }

                        r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV, barcodeGV, categoryIDGV);
                        MainClass.disable_reset(leftPanel);
                    }
                    else if (edit == 1) // code for update operation
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to edit record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            updation u = new updation();
                            if(expiryPicker.Value.Date == DateTime.Now.Date)
                            {
                                u.updateProduct(productID, productTEXT.Text, barcodeTEXT.Text,  Convert.ToInt32(categoryDD.SelectedValue));

                            }
                            else
                            {
                                u.updateProduct(productID, productTEXT.Text, barcodeTEXT.Text, Convert.ToInt32(categoryDD.SelectedValue), expiryPicker.Value);

                            }
                            r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV, barcodeGV, categoryIDGV);
                            MainClass.disable_reset(leftPanel);
                        }

                    }


                }
            }

        }

        public override void deleteButton_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(productID, "s_productDelete", "@proID");
                    r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV,  barcodeGV, categoryIDGV);
                }
            }
        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTEXT.Text.Trim() != "")
            {
                r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV, barcodeGV, categoryIDGV, searchTEXT.Text);
            }
            else
            {
                r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV, barcodeGV, categoryIDGV);
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, productIDGV, productGV, expiryGV, catGV, barcodeGV, categoryIDGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                productID = Convert.ToInt32(row.Cells["productIDGV"].Value.ToString());
                productTEXT.Text = row.Cells["productGV"].Value.ToString(); // name textbox
                barcodeTEXT.Text = row.Cells["barcodeGV"].Value.ToString();
                if(row.Cells["expiryGV"].FormattedValue.ToString() == "")
                {
                    expiryPicker.Value = DateTime.Now;
                }
                else
                {
                    expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
               
                categoryDD.SelectedValue = row.Cells["categoryIDGV"].Value.ToString();
        
                MainClass.disable(leftPanel);
            }
        }
    }
}
