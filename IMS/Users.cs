using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Users : Sample2
    {
       int edit = 0;
        // this zero is indication to save operation and 1 is an indication to update operation.
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
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
            // in the if condition is the name of (NAME) text box which I didnot write in UI properties
            if(textBox1.Text == " ") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if(usernameTEXT.Text == " ") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if(pswdTEXT.Text == " ") { passErrorLabel.Visible = true; } else {passErrorLabel.Visible =  false; }
            if(phoneTEXT.Text == " ") { phoneErrorLable.Visible = true; } else { phoneErrorLable.Visible = false; }
            if(emailTEXT.Text == " ") { emailErrorLabel.Visible = true; }else { emailErrorLabel.Visible = false; }
            if (statusDD.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passErrorLabel.Visible || phoneErrorLable.Visible || statusErrorLabel.Visible )
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
                 
                    i.insertUsers(textBox1.Text, usernameTEXT.Text, pswdTEXT.Text, phoneTEXT.Text, emailTEXT.Text, stat);
                    r.showUsers(dataGridView1,UserIDGV,NameGV,UsernameGV,PassGV,EmailGV,PhoneGV,StatusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if(edit == 1) // code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to edit record?" , "Question..." , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
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

                        u.updateUsers(userID, textBox1.Text, usernameTEXT.Text, pswdTEXT.Text, phoneTEXT.Text, emailTEXT.Text, stat);
                        r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }
                

            }
        }

        public override void deleteButton_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(userID, "st_deleteUser", "@id");
                    r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, EmailGV, PhoneGV, StatusGV);
                }
            }
        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {
            if(searchTEXT.Text != " ")
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, EmailGV, PhoneGV, StatusGV ,searchTEXT.Text);
            }
            else
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, EmailGV, PhoneGV, StatusGV);
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, EmailGV, PhoneGV, StatusGV);
        }

        // this method is of name textbox, I accidentally generated the event without naming it. 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32 (row.Cells["UserIDGV"].Value.ToString());
                textBox1.Text = row.Cells["NameGV"].Value.ToString(); // name textbox
                usernameTEXT.Text = row.Cells["UsernameGV"].Value.ToString();
                pswdTEXT.Text = row.Cells["PassGV"].Value.ToString();
                phoneTEXT.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTEXT.Text = row.Cells["EmailGV"].Value.ToString();
                statusDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        // no need
        private void searchTEXT_TextChanged_1(object sender, EventArgs e)
        {
            //no need
        }
    }   // no need
}
