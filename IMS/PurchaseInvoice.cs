using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class PurchaseInvoice : Sample2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        retrieval r = new retrieval();

        int productID;
        float gt, tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public override void addButton_Click(object sender, EventArgs e)
        {

        }

        public override void editButton_Click(object sender, EventArgs e)
        {

        }

        int co;
        updation u = new updation();


        // bool allProductsExist = true;

        //foreach (DataGridViewRow row in dataGridView1.Rows)
        //{
        //    Int64 productId = Convert.ToInt64(row.Cells["productIDGV"].Value.ToString());
        //    // Check if the product exists
        //    object[] productCheck = r.checkProductPriceExistance(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
        //    //productId
        //    if (productCheck[0] == null)
        //    {
        //        allProductsExist = false;
        //        MainClass.ShowMSG($"Product with ID {productId} does not exist.", "Error...", "Error");
        //        break;
        //    }
        //}

        //if (allProductsExist)
        //{



        //public override void saveButton_Click(object sender, EventArgs e)
        //{

        //    if (dataGridView1.Rows.Count > 0)
        //    {
        //        Int64 purchaseInvoiceID;
        //        insertion i = new insertion();
        //        using (TransactionScope sc = new TransactionScope())
        //        {
        //            purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

        //                int co = 0;
        //                foreach (DataGridViewRow row in dataGridView1.Rows)
        //                {
        //                    co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));

        //                    object[] arr = r.checkProductPriceExistance(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()));

        //                    if (arr[3] != null)
        //                    {
        //                        float disPercentage = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToSingle(arr[3].ToString()) / 100;
        //                        float profitPercentage = Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToSingle(arr[4].ToString()) / 100;
        //                        float totalAmount = Convert.ToSingle(row.Cells["productIDGV"].Value.ToString()) + profitPercentage - disPercentage;
        //                        u.updateProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
        //                    }
        //                    else
        //                    {
        //                        i.insertProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
        //                    }

        //                    int q;
        //                    object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
        //                    if (ob != null)
        //                    {
        //                        q = Convert.ToInt32(ob);
        //                        q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
        //                        u.updateStock(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()), q);
        //                    }
        //                    else
        //                    {
        //                        i.insertStock(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
        //                    }
        //                }
        //                if (co > 0)
        //                {
        //                    MainClass.ShowMSG("Purchase Invoice created successfully. ", "Success...", "Success");
        //                }
        //                else
        //                {
        //                    MainClass.ShowMSG("Unable to create purchase invoice. ", "Error...", "Error");
        //                }
        //                sc.Complete();

        //        }
        //    }
        //}




        //  GPT CODE
        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Int64 purchaseInvoiceID;
                insertion i = new insertion();
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseInvoiceID = i.insertPurchaseInvoice(DateTime.Today, retrieval.USER_ID, Convert.ToInt32(supplierDD.SelectedValue));

                    int co = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        co += i.insertPurchaseInvoiceDetails(purchaseInvoiceID, Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()), Convert.ToSingle(row.Cells["totalGV"].Value.ToString()));

                        object[] arr = r.checkProductPriceExistance(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()));

                        float discountPercentage = 0f;
                        float profitPercentage = 0f;
                        float existingPrice = 0f;

                        // Check the length of the array and parse values if available
                        if (arr.Length > 3)
                        {
                            float.TryParse(arr[3]?.ToString(), out discountPercentage);
                        }
                        if (arr.Length > 4)
                        {
                            float.TryParse(arr[4]?.ToString(), out profitPercentage);
                        }
                        if (arr.Length > 5)
                        {
                            float.TryParse(arr[5]?.ToString(), out existingPrice);
                        }

                        // Ensure arr[4] is parsed
                        if (arr.Length > 4)
                        {
                            float productPrice = Convert.ToSingle(row.Cells["pupGV"].Value.ToString());
                            float disPercentage = productPrice * discountPercentage / 100;
                            float profitPercentageAmount = productPrice * profitPercentage / 100;
                            float totalAmount = existingPrice + profitPercentageAmount - disPercentage;

                            u.updateProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), productPrice);
                        }
                        else
                        {
                            i.insertProductPrice(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()), Convert.ToSingle(row.Cells["pupGV"].Value.ToString()));
                        }

                        int q;
                        object ob = r.getProductQuantity(Convert.ToInt32(row.Cells["productIDGV"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                            u.updateStock(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()), q);
                        }
                        else
                        {
                            i.insertStock(Convert.ToInt64(row.Cells["productIDGV"].Value.ToString()), Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()));
                        }
                    }
                    if (co > 0)
                    {
                        MainClass.ShowMSG("Purchase Invoice created successfully. ", "Success...", "Success");
                    }
                    else
                    {
                        MainClass.ShowMSG("Unable to create purchase invoice. ", "Error...", "Error");
                    }
                    sc.Complete();
                }
            }
        }




        public override void deleteButton_Click(object sender, EventArgs e)
        {

        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {

            //if (searchTEXT.Text != "")
            //{
            //    r.showPurchaseInvoice(productID, dataGridView1, productIDGV, productGV, quantityGV, pupGV, totalGV, searchTEXT.Text);
            //}
            //else
            //{
            //    r.showPurchaseInvoice(productID, dataGridView1, productIDGV, productGV, quantityGV, pupGV, totalGV);
            //}

        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            PurchaseInvoiceDetails pid = new PurchaseInvoiceDetails();
            MainClass.showWindow(pid, this, MDI.ActiveForm);
        }

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            r.getList("st_getSupplierList", supplierDD, "Company", "ID");
            base.addButton.Enabled = false;
            base.editButton.Enabled = false;
            base.deleteButton.Enabled = false;
        }

        string[] productARR = new string[4];
        private void barcodeText_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void barcodeText_Validated(object sender, EventArgs e)
        {
          
        }

        private void quantityTEXT_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(quantityTEXT.Text) && !string.IsNullOrWhiteSpace(pupTEXT.Text))
            {
                if (float.TryParse(quantityTEXT.Text, out float quan) && float.TryParse(pupTEXT.Text, out float price))
                {
                    float total = quan * price;
                    totalLabel.Text = total.ToString("######.##");
                }
                else
                {
                    // Invalid input format
                    MessageBox.Show("Please enter valid numeric values for quantity and price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantityTEXT.Focus(); // Set focus back to quantity field
                }
            }
            else
            {
                totalLabel.Text = "0.00";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if(e.ColumnIndex == 5)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    gt -= Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                    grossLabel.Text = gt.ToString();
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        //   string regexPattern = @"^[0-9]+$";
        //string regexPattern = @"^[0-9]*(?:\.[0-9]*)?$";
        private void pupTEXT_TextChanged(object sender, EventArgs e)
        {
           // Regex rg = new Regex(regexPattern);
            if (pupTEXT.Text != "")
            {
                if(!rg.Match(pupTEXT.Text).Success)
                {
                    pupTEXT.Text = "";
                    pupTEXT.Focus();
                }
            }
           
        }

        private void barcodeText_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeText.Text != " ")
            {
                productARR = r.getProductsWRTBarcode(barcodeText.Text);
                productID = Convert.ToInt32(productARR[0]);
                productTEXT.Text = productARR[1];
                string barco = productARR[2];
                productTEXT.Enabled = false;

                if (barco != " ")
                {
                    pupTEXT.Focus();
                }
            }
            else
            {
                productID = 0;
                productTEXT.Text = " ";
                pupTEXT.Text = " ";
                Array.Clear(productARR, 0, productARR.Length);
            }
        }


        private void cartButton_Click(object sender, EventArgs e)
        {
            if(supplierDD.SelectedIndex == -1) { supplierErrorLabel.Visible = true; } else { supplierErrorLabel.Visible = false; }
            if (quantityTEXT.Text == " ") { quantityErrorLabel.Visible = true; } else { quantityErrorLabel.Visible = false; }
            if (barcodeText.Text == " ") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (supplierErrorLabel.Visible || quantityErrorLabel.Visible || barcodeErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "Stop...", "Error");
            }
            else
            {
                dataGridView1.Rows.Add(productID, productTEXT.Text, quantityTEXT.Text, pupTEXT.Text, totalLabel.Text);
                gt += Convert.ToSingle(totalLabel.Text);
                grossLabel.Text = gt.ToString();
                productID = 0;
                productTEXT.Text = " ";
                pupTEXT.Text = " ";
                barcodeText.Text = " ";
                totalLabel.Text = "0.00";
                quantityTEXT.Text = " ";
                Array.Clear(productARR, 0, productARR.Length);

            }

        }



     }
 }

