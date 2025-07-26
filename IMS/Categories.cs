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
    public partial class Categories : Sample2
    {
        int edit = 0;
        // this zero is indication to save operation and 1 is an indication to update operation.
        int catID;
        short stat;
        retrieval r = new retrieval();
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            userLabel.Text = retrieval.EMP_NAME;
            MainClass.disable(leftPanel);
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
                if (categoryTEXT.Text == " ") { categoryErrorLabel.Visible = true; } else { categoryErrorLabel.Visible = false; }
                if (activeDD.SelectedIndex == -1) { activeErrorLabel.Visible = true; } else { activeErrorLabel.Visible = false; }

                if ( categoryErrorLabel.Visible || activeErrorLabel.Visible)
                {
                    MainClass.ShowMSG("Fields with * are mandatory", "STOP", "Error"); // Error is type of message
                }
                else
                {


                    if (activeDD.SelectedIndex == 0)
                    {
                        stat = 1;
                    }
                    else if (activeDD.SelectedIndex == 1)
                    {
                        stat = 0;
                    }

                    if (edit == 0) // code for save operation
                    {

                        insertion i = new insertion();

                        i.insertCat(categoryTEXT.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                    else if (edit == 1) // code for update operation
                    {
                        DialogResult dr = MessageBox.Show("Are you sure you want to edit record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            updation u = new updation();
                        if (activeDD.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (activeDD.SelectedIndex == 1)
                        {
                            stat = 0;
                        }

                        u.updateCat(catID, categoryTEXT.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
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
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
                }
            }
        }

        public override void searchTEXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTEXT.Text != " ")
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV, searchTEXT.Text);
            }
            else
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
            }
        }

        public override void viewButton_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categoryTEXT.Text = row.Cells["NameGV"].Value.ToString(); 
                activeDD.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        // accidentally created this.
        private void searchTEXT_TextChanged_1(object sender, EventArgs e)
        {
            //cancel this function
        
        }
        // no need for this function
    }
}
