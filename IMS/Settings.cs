//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Inventory_Management_System
//{
//    public partial class Settings : Sample
//    {
//        public Settings()
//        {
//            InitializeComponent();
//        }

//        private void leftPanel_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void saveBUTTON_Click(object sender, EventArgs e)
//        {
//            string s;
//            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

//            if (integratedsecurityCHECKBOX.Checked)
//            {
//                if (serverTEXT.Text != " " && databaseTEXT.Text != " ")
//                {
//                    s = "Data Source= " + serverTEXT.Text + "; Initial Catalog= " + databaseTEXT.Text + "; Integrated Security= true;MultipleActiveResultSets=true;";
//                    File.WriteAllText(path + "\\connect", s);
//                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    if (dr == DialogResult.OK)
//                    {
//                        login log = new login();
//                        MainClass.showWindow(log, this, MDI.ActiveForm);
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("Please give complete data to continue...");
//                }
//            }
//            else
//            {
//                if (serverTEXT.Text != " " && databaseTEXT.Text != " " && userIDTEXT.Text != " " && pswdTEXT.Text != " ")
//                {
//                    s = "Data Source= " + serverTEXT.Text + "; Initial Catalog= " + databaseTEXT.Text + "; User ID=" +userIDTEXT.Text+";Password="+pswdTEXT.Text+ ";MultipleActiveResultSets=true;";
//                    File.WriteAllText(path+"\\connect", s);
//                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    if (dr == DialogResult.OK)
//                    {
//                        login log = new login();
//                        MainClass.showWindow(log, this, MDI.ActiveForm);
//                    }
//                }
//                else
//                {
//                    MessageBox.Show("Please give complete data to continue...");
//                }
//            }


//        }

//        private void integratedsecurityCHECKBOX_CheckedChanged(object sender, EventArgs e)
//        {
//            if(integratedsecurityCHECKBOX.Checked)
//            {
//                userIDTEXT.Enabled = false;
//                pswdTEXT.Enabled = false;

//                userIDTEXT.Text = " ";
//                pswdTEXT.Text = " ";
//            }
//            else
//            {
//                userIDTEXT.Enabled = true;
//                pswdTEXT.Enabled = true;
//            }
//        }

//        private void Settings_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}






// GPT CODEEE



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBUTTON_Click(object sender, EventArgs e)
        {
            string connectionString;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configPath = Path.Combine(path, "connect");

            if (integratedsecurityCHECKBOX.Checked)
            {
                if (!string.IsNullOrWhiteSpace(serverTEXT.Text) && !string.IsNullOrWhiteSpace(databaseTEXT.Text))
                {
                    connectionString = $"Data Source={serverTEXT.Text}; Initial Catalog={databaseTEXT.Text}; Integrated Security=true;MultipleActiveResultSets=true;";
                    File.WriteAllText(configPath, connectionString);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide complete data to continue...");
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(serverTEXT.Text) && !string.IsNullOrWhiteSpace(databaseTEXT.Text) &&
                    !string.IsNullOrWhiteSpace(userIDTEXT.Text) && !string.IsNullOrWhiteSpace(pswdTEXT.Text))
                {
                    connectionString = $"Data Source={serverTEXT.Text}; Initial Catalog={databaseTEXT.Text}; User ID={userIDTEXT.Text};Password={pswdTEXT.Text};MultipleActiveResultSets=true;";
                    File.WriteAllText(configPath, connectionString);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide complete data to continue...");
                }
            }
        }

        private void integratedsecurityCHECKBOX_CheckedChanged(object sender, EventArgs e)
        {
            if (integratedsecurityCHECKBOX.Checked)
            {
                userIDTEXT.Enabled = false;
                pswdTEXT.Enabled = false;

                userIDTEXT.Text = string.Empty;
                pswdTEXT.Text = string.Empty;
            }
            else
            {
                userIDTEXT.Enabled = true;
                pswdTEXT.Enabled = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}





