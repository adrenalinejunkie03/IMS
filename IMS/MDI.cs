//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;

//namespace Inventory_Management_System
//{
//    public partial class MDI : Form
//    {
//          public MDI()
//        {
//             InitializeComponent();
//        }

//        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void MDI_Load(object sender, EventArgs e)
//        {
//            // from gpt

//            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//            string configPath = Path.Combine(documentsPath, "connect");

//            // string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//            // from gpt
//            // string configPath = Path.combine(path, "connect");


//            // from gpt
//            if (File.Exists(configPath))
//            // if (File.Exists(Path+ "\\connect"))
//            {
//                login log = new login();
//                MainClass.showWindow(log, this);
//            }
//            else
//            {
//                Settings set = new Settings();
//                MainClass.showWindow(set, this);
//            }

//            this.logoutToolStripMenuItem.Enabled = true;

//        }

//        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
//        {
//            Settings set = new Settings();
//            MainClass.showWindow(set, this);
//        }

//        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
//        {

//            //this.logoutToolStripMenuItem.Enabled = false;
//            login set = new login();
//            MainClass.showWindow(set, this);

//        }
//    }
//}








// UPDATED GPT MDI //



using System;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string configPath = Path.Combine(documentsPath, "connect");

            try
            {
                if (File.Exists(configPath))
                {
                    login log = new login();
                    MainClass.showWindow(log, this);
                }
                else
                {
                    Settings set = new Settings();
                    MainClass.showWindow(set, this);
                }

                this.logoutToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MainClass.ShowMSG("An error occurred: " + ex.Message, "Error", "Error");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login set = new login();
            MainClass.showWindow(set, this);
        }
    }
}
