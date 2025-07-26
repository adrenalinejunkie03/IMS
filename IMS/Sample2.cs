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
    public partial class Sample2 : Sample
    {
        public Sample2()
        {
            InitializeComponent();
        }

        public virtual void backButton_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj,this,MDI.ActiveForm);
        }

        public virtual void addButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void editButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void saveButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void deleteButton_Click(object sender, EventArgs e)
        {

        }

        public virtual void searchTEXT_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void Sample2_Load(object sender, EventArgs e)
        {

        }
    }
}
