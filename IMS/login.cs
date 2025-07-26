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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTEXT.Text == " ") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (passwordTEXT.Text == " ") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if(nameErrorLabel.Visible || passwordErrorLabel.Visible)
            {
                MainClass.ShowMSG("Fields with * are mandatory", "STOP", "Error");
            }
            else
            {
                if(retrieval.getUserDetails(usernameTEXT.Text, passwordTEXT.Text))
                {
                    HomeScreen hm = new HomeScreen();
                    MainClass.showWindow(hm, this, MDI.ActiveForm);

                }
                else
                {

                }
            }
           
        }

        private void usernameTEXT_TextChanged(object sender, EventArgs e)
        {

            if (usernameTEXT.Text == " ") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void passwordTEXT_TextChanged(object sender, EventArgs e)
        {
            if (passwordTEXT.Text == " ") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
