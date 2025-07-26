using System;
using System.Collections;
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
    public partial class SalesReturnWindow : Sample2
    {
        public SalesReturnWindow()
        {
            InitializeComponent();
        }
        Hashtable hta = new Hashtable();
        insertion i = new insertion();
        updation u = new updation();
        float amount_refund = 0;
        int salesID;


        //public override void saveButton_Click(object sender, EventArgs e)
        //{
        //    if (refundTEXT.Text != "" && hta.Count > 0 && salesIDText.Text != "")
        //    {

        //        DialogResult dr = MessageBox.Show("Are you sure, you want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (dr == DialogResult.Yes)
        //        {
        //            using (TransactionScope sc = new TransactionScope())
        //            {
        //                int x = 0;
        //                foreach (DictionaryEntry de in hta)
        //                {  // actual paramters were salesID , datetime , rettrieval user , key , value

        //                    //isko dekh lein ik barr
        //                    //  Convert.ToInt64(de.Key);
        //                    //  Convert.ToInt16(de.Value);

        //                    x += i.insertReturnRefund(Convert.ToInt64(salesIDText.Text), DateTime.Now, retrieval.USER_ID, Convert.ToInt64(proIDGV), Convert.ToInt16(quantityGV), Convert.ToInt64(refundTEXT.Text));
        //                    int currentQuantity = (int)r.getProductQuantity(Convert.ToInt64(de.Key));
        //                    int finalQuantity = currentQuantity - Convert.ToInt16(de.Value);
        //                 //   u.updateStock(Convert.ToInt64(de.Key), finalQuantity);

        //                    // yeh bh dekhty kya krta ha
        //                    u.updateSalesQuantity(Convert.ToInt64(salesIDText.Text), Convert.ToInt16(de.Value));
        //                }
        //                if (x > 0)
        //                {

        //                    DialogResult drr = MainClass.ShowMSG("Return and Refund Successfull", "Success", "Success");
        //                    if (drr == DialogResult.OK)
        //                    {
        //                        SalesReturnReceiptWindow obj = new SalesReturnReceiptWindow();
        //                        obj.ShowDialog();
        //                    }
        //                    x = 0;
        //                    hta.Clear();
        //                }
        //                sc.Complete();
        //            }
        //        }

        //        else
        //        {
        //            MainClass.ShowMSG("Please provide complete details", "Error", "Error");
        //        }
        //    }
        //}



        public override void saveButton_Click(object sender, EventArgs e)
        {
            if (refundTEXT.Text != "" && hta.Count > 0 && salesIDText.Text != "")
            {
                DialogResult dr = MessageBox.Show("Are you sure, you want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        int x = 0;
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue; // Skip new row placeholder

                            long proID = Convert.ToInt64(row.Cells["proIDGV"].Value);
                            short quantity = Convert.ToInt16(row.Cells["quantityGV"].Value);

                            float refundAmount;
                            if (!float.TryParse(refundTEXT.Text, out refundAmount))
                            {
                                MainClass.ShowMSG("Invalid refund amount", "Error", "Error");
                                return;
                            }

                            x += i.insertReturnRefund(
                                Convert.ToInt64(salesIDText.Text),
                                DateTime.Now,
                                retrieval.USER_ID,
                                proID,
                                quantity,
                                refundAmount
                            );

                            int currentQuantity = (int)r.getProductQuantity(proID);
                            int finalQuantity = currentQuantity - quantity;
                            u.updateStock(proID, finalQuantity);

                            u.updateSalesQuantity(Convert.ToInt64(salesIDText.Text), quantity);
                        }

                        if (x > 0)
                        {
                            DialogResult drr = MainClass.ShowMSG("Return and Refund Successful", "Success", "Success");
                            if (drr == DialogResult.OK)
                            {
                                SalesReturnReceiptWindow obj = new SalesReturnReceiptWindow();
                                obj.ShowDialog();
                            }
                            x = 0;
                            hta.Clear();
                        }
                        sc.Complete();
                    }
                }
                else
                {
                    MainClass.ShowMSG("Please provide complete details", "Error", "Error");
                }
            }
        }


        retrieval r = new retrieval();
        Regex rg = new Regex("^[0-9]+$");
        //   private object ht;

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (salesIDText.Text != "")
            {
                if (rg.Match(salesIDText.Text).Success)
                {
                    r.showSalesDataViaID(Convert.ToInt64(salesIDText.Text), dataGridView1, SaleIDGV, barcodeGV,
                        productGV, quantityGV, totDiscGV, totAmountGV, amountGivenGV, amountReturnedGV, dateGV,
                        priceGV, perProductDiscGV, perProductTotGV, userGV, paymentGV, proIDGV);

                    if (dataGridView1.RowCount > 0)
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
                        userTEXT.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
                        paymentTEXT.Text = dataGridView1.Rows[0].Cells["paymentGV"].Value.ToString();

                        // Disable the textboxes to prevent changes
                        dateTimePicker1.Enabled = false;
                        userTEXT.Enabled = false;
                        paymentTEXT.Enabled = false;

                        // Enable the barcode textbox for sales return
                        barcodeTEXT.Enabled = true;
                    }
                    else
                    {
                        // No data loaded, reset everything
                        dateTimePicker1.Value = DateTime.Now;
                        userTEXT.Text = "";
                        paymentTEXT.Text = "";

                        // Disable the textboxes
                        dateTimePicker1.Enabled = false;
                        userTEXT.Enabled = false;
                        paymentTEXT.Enabled = false;

                        // Enable the barcode textbox for sales return
                        barcodeTEXT.Enabled = true;
                    }
                }
                else
                {
                    // Invalid sales ID format, reset input and focus
                    salesIDText.Text = "";
                    salesIDText.Focus();
                    dateTimePicker1.Value = DateTime.Now;
                    userTEXT.Text = "";
                    paymentTEXT.Text = "";

                    // Disable the textboxes
                    dateTimePicker1.Enabled = false;
                    userTEXT.Enabled = false;
                    paymentTEXT.Enabled = false;

                    // Enable the barcode textbox for sales return
                    barcodeTEXT.Enabled = true;
                }
            }
            else
            {
                // No sales ID entered, reset everything
                dateTimePicker1.Value = DateTime.Now;
                userTEXT.Text = "";
                paymentTEXT.Text = "";

                // Disable the textboxes
                dateTimePicker1.Enabled = false;
                userTEXT.Enabled = false;
                paymentTEXT.Enabled = false;

                // Enable the barcode textbox for sales return
                barcodeTEXT.Enabled = true;
            }
        }

        //private void LoadButton_Click(object sender, EventArgs e)
        //{
        //    if (salesIDText.Text != "")
        //    {
        //        if (rg.Match(salesIDText.Text).Success)
        //        {
        //            r.showSalesDataViaID(Convert.ToInt64(salesIDText.Text), dataGridView1, SaleIDGV, barcodeGV,
        //                productGV, quantityGV, totDiscGV, totAmountGV, amountGivenGV, amountReturnedGV, dateGV,
        //                priceGV, perProductDiscGV, perProductTotGV, userGV, paymentGV, proIDGV);

        //            if (dataGridView1.RowCount > 0)
        //            {
        //                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["dateGV"].Value);
        //                userTEXT.Text = dataGridView1.Rows[0].Cells["userGV"].Value.ToString();
        //                paymentTEXT.Text = dataGridView1.Rows[0].Cells["paymentGV"].Value.ToString();
        //            }

        //        }
        //        else
        //        {
        //            salesIDText.Text = "";
        //            salesIDText.Focus();
        //            dateTimePicker1.Value = DateTime.Now;
        //            userTEXT.Text = "";
        //            paymentTEXT.Text = "";
        //        }
        //    }
        //    else
        //    {
        //        dateTimePicker1.Value = DateTime.Now;
        //        userTEXT.Text = "";
        //        paymentTEXT.Text = "";
        //    }

        //}

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //private void barcodeTEXT_Validating(object sender, CancelEventArgs e)
        //{
        //    if (barcodeTEXT.Text != "")
        //    {
        //        if (dataGridView1.Rows.Count > 0)
        //        {
        //            using (TransactionScope sc = new TransactionScope())
        //            {
        //                foreach (DataGridViewRow row in dataGridView1.Rows)
        //                {
        //                    if (barcodeTEXT.Text == row.Cells["barcodeGV"].Value.ToString() )
        //                    {
        //                        DialogResult dr = MessageBox.Show("Are you sure you want to return" + row.Cells["productGV"].Value.ToString() + "?", "Question", MessageBoxButtons.YesNo );
        //                        if (dr == DialogResult.Yes)
        //                        {
        //                            Int64 product_id = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
        //                            float product_price = Convert.ToSingle(row.Cells["priceGV"].Value.ToString());

        //                            int product_quantity = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) - 1;
        //                            amount_refund += product_price;

        //                            refundTEXT.Text = Math.Round(amount_refund, 0).ToString();
        //                            if (product_quantity == 0)
        //                            {

        //                                if (hta.ContainsKey(row.Cells["proIDGV"].Value))
        //                                {
        //                                    Int64 proIDhta = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
        //                                    hta[proIDhta] = Convert.ToInt32(hta[proIDhta]) -1 ;
        //                                }
        //                                else
        //                                {
        //                                    hta.Add(row.Cells["proIDGV"].Value , 1);
        //                                }
        //                                dataGridView1.Rows.Remove(row);
        //                            }
        //                            else
        //                            {
        //                                row.Cells["quantityGV"].Value = product_quantity;
        //                                row.Cells["perProductTotGV"].Value = (Convert.ToSingle(row.Cells["priceGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) );
        //                                if (hta.ContainsKey(row.Cells["proIDGV"].Value.ToString()))
        //                                {
        //                                    Int64 proIDhta = Convert.ToInt64(row.Cells["proIDGV"].Value.ToString());
        //                                    hta[proIDhta] = Convert.ToInt32(hta[proIDhta]) + 1;
        //                                }
        //                                else
        //                                {
        //                                    hta.Add(row.Cells["proIDGV"].Value, 1);
        //                                }

        //                            }
        //                        }
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}



        private void barcodeTEXT_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTEXT.Text != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope sc = new TransactionScope())
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (barcodeTEXT.Text == row.Cells["barcodeGV"].Value.ToString())
                            {
                                DialogResult dr = MessageBox.Show("Are you sure you want to return " + row.Cells["productGV"].Value.ToString() + "?", "Question", MessageBoxButtons.YesNo);
                                if (dr == DialogResult.Yes)
                                {
                                    Int64 product_id = Convert.ToInt64(row.Cells["proIDGV"].Value);
                                    float product_price = Convert.ToSingle(row.Cells["priceGV"].Value);

                                    int product_quantity = Convert.ToInt32(row.Cells["quantityGV"].Value) - 1;
                                    amount_refund += product_price;

                                    refundTEXT.Text = Math.Round(amount_refund, 0).ToString();

                                    // Check if the product ID already exists in hta
                                    if (hta.ContainsKey(product_id))
                                    {
                                        hta[product_id] = Convert.ToInt32(hta[product_id]) - 1;
                                    }
                                    else
                                    {
                                        hta.Add(product_id, 1);
                                    }

                                    if (product_quantity == 0)
                                    {
                                        dataGridView1.Rows.Remove(row);
                                    }
                                    else
                                    {
                                        row.Cells["quantityGV"].Value = product_quantity;
                                        row.Cells["perProductTotGV"].Value = Convert.ToSingle(row.Cells["priceGV"].Value) * product_quantity;
                                    }
                                }
                                break; // Exit the loop after processing the barcode match
                            }
                        }
                    }
                }
            }
        }








        private void SalesReturnWindow_Load(object sender, EventArgs e)
        {
            base.addButton.Enabled = false;
            base.editButton.Enabled = false;
            base.deleteButton.Enabled = false;
            base.viewButton.Enabled = false;
            userLabel.Text = retrieval.EMP_NAME;
        }

        private void searchTEXT_TextChanged_1(object sender, EventArgs e)
        {
            if (searchTEXT.Text != "")
            {
                r.showSalesDataViaID(salesID, dataGridView1, SaleIDGV, barcodeGV, productGV, quantityGV, totDiscGV, totAmountGV, amountGivenGV, amountReturnedGV, dateGV, priceGV, perProductDiscGV, perProductTotGV, userGV, paymentGV, proIDGV, searchTEXT.Text);
            }
            else
            {
                r.showSalesDataViaID(salesID, dataGridView1, SaleIDGV, barcodeGV, productGV, quantityGV, totDiscGV, totAmountGV, amountGivenGV, amountReturnedGV, dateGV, priceGV, perProductDiscGV, perProductTotGV, userGV, paymentGV, proIDGV);
            }
     
        }
    }
}
