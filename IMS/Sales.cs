using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Inventory_Management_System
{
    public partial class Sales : Sample2
    {
        public Sales()
        {
            InitializeComponent();
        }
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        int productID;

        private void Sales_Load(object sender, EventArgs e)
        {
            base.addButton.Enabled = false;
            base.editButton.Enabled = false;
            base.deleteButton.Enabled = false;
            userLabel.Text = retrieval.EMP_NAME;
        }

        retrieval r = new retrieval();
        string[] productARR = new string[6];
        float gross = 0;
        private void barcodeTEXT_TextChanged(object sender, EventArgs e)
        {


        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            viewSalesInvoices vsi = new viewSalesInvoices();
            MainClass.showWindow(vsi, this, MDI.ActiveForm);
        }


        bool productCheck;

        private void barcodeTEXT_Validating(object sender, CancelEventArgs e)
        {
            if (barcodeTEXT.Text != "")
            {
                grossTEXT.Text = "";
                totalDiscountTEXT.Text = "";
                amountGivenTEXT.Text = "";
                changeGivenTEXT.Text = "";


                int qCount = 0;
                int sQuant = 0;
                int nCount = 0;
                productARR = r.GetProductPricing(barcodeTEXT.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (productARR[0] == row.Cells["productIDGV"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(r.getProductQuantity(Convert.ToInt64(productARR[0])));

                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        dataGridView1.Rows.Add(Convert.ToInt32(productARR[0]), productARR[1], 1, Convert.ToSingle(productARR[3]), Math.Round(Convert.ToSingle(productARR[4]), 2), Convert.ToSingle(productARR[5]));

                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["productIDGV"].Value.ToString() == productARR[0])
                            {
                                productCheck = true;
                                break;

                            }
                            else
                            {
                                productCheck = false;
                                // dataGridView1.Rows.Add(Convert.ToInt32(productARR[0]), productARR[1], 1, Convert.ToSingle(productARR[3]), productARR[4], Convert.ToSingle(productARR[5]));

                            }
                        }
                        if (productCheck == true)
                        {
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                if (row.Cells["productIDGV"].Value.ToString() == productARR[0])
                                {
                                    float disc = 0;
                                    row.Cells["quantityGV"].Value = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString()) + 1;
                                    if (row.Cells["discGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["discGV"].Value = disc;
                                    }

                                    float tot = (Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) * Convert.ToInt32(row.Cells["quantityGV"].Value.ToString())) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                    row.Cells["totalGV"].Value = tot;
                                }

                            }

                        }
                        else
                        {
                            dataGridView1.Rows.Add(Convert.ToInt32(productARR[0]), productARR[1], 1, Convert.ToSingle(productARR[3]), Math.Round(Convert.ToSingle(productARR[4]), 2), Convert.ToSingle(productARR[5]));

                        }

                    }
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        gross += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                    }
                    grossLabel.Text = Math.Ceiling(gross).ToString();
                    gross = 0;
                    barcodeTEXT.Focus();
                    barcodeTEXT.Text = " ";
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    grossTEXT.Text = "";
                    totalDiscountTEXT.Text = "";
                    amountGivenTEXT.Text = "";
                    changeGivenTEXT.Text = "";

                    float gt, tot, dis;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    int q = Convert.ToInt32(row.Cells["quantityGV"].Value.ToString());
                    if (q == 1)
                    {
                        gt = Convert.ToSingle(grossLabel.Text);
                        gt = gt - Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                        grossLabel.Text = gt.ToString();
                        dataGridView1.Rows.Remove(row);
                    }
                    else if (q > 1)
                    {
                        q--;
                        row.Cells["quantityGV"].Value = q;
                        dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(productARR[4]);
                        row.Cells["discGV"].Value = dis;
                        tot = Convert.ToSingle(row.Cells["quantityGV"].Value.ToString()) * Convert.ToSingle(row.Cells["pupGV"].Value.ToString()) - dis;
                        row.Cells["totalGV"].Value = tot;

                        foreach (DataGridViewRow item in dataGridView1.Rows)
                        {
                            gross += Convert.ToSingle(item.Cells["totalGV"].Value.ToString());
                        }
                        grossLabel.Text = gross.ToString();
                        gross = 0;

                        //gt = Convert.ToSingle(grossLabel.Text);
                        //gt = gt - Convert.ToSingle(row.Cells["pupGV"].Value.ToString());
                        //grossLabel.Text = gt.ToString();
                        //row.Cells["quantityGV"].Value = q;
                    }
                }
            }

        }



        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                float dis = 0;
                float grosss = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    grosss += Convert.ToSingle(row.Cells["totalGV"].Value.ToString());
                }
                grossTEXT.Text = Math.Ceiling(grosss).ToString();
                totalDiscountTEXT.Text = Math.Ceiling(dis).ToString();
            }
        }

        private void amountGivenTEXT_TextChanged(object sender, EventArgs e)
        {
            if (amountGivenTEXT.Text != "")
            {
                if (!rg.Match(amountGivenTEXT.Text).Success)
                {
                    amountGivenTEXT.Text = "";
                    amountGivenTEXT.Focus();
                }
                else
                {

                }
            }
            else
            {
                changeGivenTEXT.Text = "";
            }
        }

        private void amountGivenTEXT_Validating(object sender, CancelEventArgs e)
        {
            if (amountGivenTEXT.Text != "" && grossTEXT.Text != "")
            {
                if (!(Convert.ToSingle(grossTEXT.Text) <= Convert.ToSingle(amountGivenTEXT.Text)))
                {
                    amountGivenTEXT.Text = "";
                    changeGivenTEXT.Text = "";
                    amountGivenTEXT.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(amountGivenTEXT.Text);
                    float amountToReturn = amountGiven - Convert.ToSingle(grossTEXT.Text);
                    changeGivenTEXT.Text = Math.Ceiling(amountToReturn).ToString();
                }
            }
        }


       


        insertion i = new insertion();

        private void payButton_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
            //    xcelApp.Application.Workbooks.Add(Type.Missing);

            //    for(int i=1; i<dataGridView1.Columns.Count+1; i++)
            //    {
            //        xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            //    }
            //    for(int i=0; i<dataGridView1.Rows.Count; i++)
            //    {
            //        for(int j=0; j<dataGridView1.Columns.Count; j++)
            //        {
            //            xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    xcelApp.Columns.AutoFit();
            //    xcelApp.Visible = true;

            //}
            if (amountGivenTEXT.Text != "" && totalDiscountTEXT.Text != "" && grossTEXT.Text != "" && payDD.SelectedIndex != -1 && changeGivenTEXT.Text != "")
            {
                DialogResult dr = MessageBox.Show("\n\tTotal Amount : " + grossTEXT.Text + "\n\tTotal Discount : " + totalDiscountTEXT.Text + "\n\tAmount Given : " + amountGivenTEXT.Text + "\n\tAmount Returned : " + changeGivenTEXT.Text + "\n\nAre you sure , submit current sales?\n", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    i.insertSales(dataGridView1, "productIDGV", "quantityGV", retrieval.USER_ID, DateTime.Now, Convert.ToSingle(grossTEXT.Text), Convert.ToSingle(totalDiscountTEXT.Text), Convert.ToSingle(amountGivenTEXT.Text), Convert.ToSingle(changeGivenTEXT.Text), payDD.SelectedItem.ToString());

                    MainClass.enable_reset(groupBox2);
                    dataGridView1.Rows.Clear();
                    grossLabel.Text = "0.00";


                    SalesReport sr = new SalesReport();
                    sr.Show();
                }
            }
        }

        private void searchTEXT_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}