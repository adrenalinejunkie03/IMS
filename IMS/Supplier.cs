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
    public partial class Supplier : Sample2
    {
        public Supplier()
        {
            InitializeComponent();
        }
        int edit = 0;
        // this zero is indication to save operation and 1 is an indication to update operation.
        int supplierID;
        short stat;
        retrieval r = new retrieval();

        private void Supplier_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            MainClass.disable_reset(leftPanel);
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
            if (supplierCompanyText.Text == " ") { supplierNameErrorLabel.Visible = true; } else { supplierNameErrorLabel.Visible = false; }
            if (personNameText.Text == " ") { contactPersonErrorLabel.Visible = true; } else { contactPersonErrorLabel.Visible = false; }
            if (phone1Text.Text == " ") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (addressText.Text == " ") { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (supplierNameErrorLabel.Visible || contactPersonErrorLabel.Visible || phoneErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "STOP", "Error"); // Error is type of message
            }
            else
            {


                if (statusDD.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusDD.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0) // code for save operation
                {

                    insertion i = new insertion();
                    if(phone2Text.Text == null && ntnText.Text != null)
                    {
                        i.insertSupplier(supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat , null, ntnText.Text);
                    }
                    else if(phone2Text.Text != " " && ntnText.Text == " ")
                    {
                        i.insertSupplier(supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat,  phone2Text.Text ,null);
                    }
                    else if (phone2Text.Text == " " && ntnText.Text == " ")
                    {
                        i.insertSupplier(supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, null, null);
                    }
                    else
                    {
                         i.insertSupplier(supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, phone2Text.Text , ntnText.Text);
                    }

                    r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV , phone2GV , addressGV , ntnGV, StatusGV );
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to edit record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (statusDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        if (phone2Text.Text == null && ntnText.Text != null)
                        {
                            u.updateSupplier(supplierID, supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, null , ntnText.Text );
                        }
                        else if (phone2Text.Text != " " && ntnText.Text == " ")
                        {
                            u.updateSupplier(supplierID, supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, phone2Text.Text, null);
                        }
                        else if (phone2Text.Text == " " && ntnText.Text == " ")
                        {
                            u.updateSupplier(supplierID, supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, supplierCompanyText.Text, personNameText.Text, phone1Text.Text, addressText.Text, stat, phone2Text.Text, ntnText.Text);
                        }
                       
                        r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
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
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
                }
            }
        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTEXT.Text != "")
            {
                r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV , searchTEXT.Text);
            }
            else
            {
                r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, supplierIDGV, companyGV, personGV, phone1GV, phone2GV, addressGV, ntnGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["supplierIDGV"].Value.ToString());
                supplierCompanyText.Text = row.Cells["companyGV"].Value.ToString(); // name textbox
                personNameText.Text = row.Cells["personGV"].Value.ToString();
                phone1Text.Text = row.Cells["phone1GV"].Value.ToString();
                phone2Text.Text = row.Cells["phone2GV"].Value.ToString();
                ntnText.Text = row.Cells["ntnGV"].Value.ToString();
                addressText.Text = row.Cells["addressGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
 }

