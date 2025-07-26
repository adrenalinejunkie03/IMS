//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO;
//using System.Data.SqlClient;

//namespace Inventory_Management_System
//{
//    class MainClass
//    {
//        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//        private static string s = File.ReadAllText(path + "\\connect");
//        public static SqlConnection con = new SqlConnection(s);
//        public  static DialogResult ShowMSG(string msg , string heading , string type )
//        {
//            if(type == "Success")
//            {
//                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }
//            else
//            {
//                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//        public static void showWindow(Form openWin, Form closeWin, Form MDIWin)
//        {
//            closeWin.Close();
//            openWin.MdiParent = MDIWin;
//            openWin.WindowState = FormWindowState.Maximized;
//            openWin.Show();
//        }

//        public static void showWindow(Form openWin, Form MDIWin)
//        {
//            openWin.MdiParent = MDIWin;
//            openWin.WindowState = FormWindowState.Maximized;
//            openWin.Show();
//        }
//        public static void disable_reset(Panel p)
//        {
//            foreach (Control c in p.Controls)
//            {
//                if (c is TextBox)
//                {
//                    TextBox t = (TextBox)c;
//                    t.Enabled = false;
//                    t.Text = " ";
//                }
//                if (c is ComboBox)
//                {
//                    ComboBox cb = (ComboBox)c;
//                    cb.Enabled = false;
//                    cb.SelectedIndex = -1;
//                }
//                if (c is RadioButton)
//                {
//                    RadioButton rb = (RadioButton)c;
//                    rb.Enabled = false;
//                    rb.Checked = false;
//                }
//                if (c is CheckBox)
//                {
//                    CheckBox cb = (CheckBox)c;
//                    cb.Enabled = false;
//                    cb.Checked = false;
//                }
//                if (c is DateTimePicker)
//                {
//                    DateTimePicker dtp = (DateTimePicker)c;
//                    dtp.Enabled = false;
//                    dtp.Value = DateTime.Now;
//                }
//            }
//        }

//        public static void disable(Panel p)
//        {
//            foreach (Control c in p.Controls)
//            {
//                if (c is TextBox)
//                {
//                    TextBox t = (TextBox)c;
//                    t.Enabled = false;

//                }
//                if (c is ComboBox)
//                {
//                    ComboBox cb = (ComboBox)c;
//                    cb.Enabled = false;

//                }
//                if (c is RadioButton)
//                {
//                    RadioButton rb = (RadioButton)c;
//                    rb.Enabled = false;

//                }
//                if (c is CheckBox)
//                {
//                    CheckBox cb = (CheckBox)c;
//                    cb.Enabled = false;

//                }
//                if (c is DateTimePicker)
//                {
//                    DateTimePicker dtp = (DateTimePicker)c;
//                    dtp.Enabled = false;

//                }
//            }
//        }

//        public static void enable_reset(Panel p)
//        {
//            foreach (Control c in p.Controls)
//            {
//                if (c is TextBox)
//                {
//                    TextBox t = (TextBox)c;
//                    t.Enabled = true;
//                    t.Text = " ";
//                }
//                if (c is ComboBox)
//                {
//                    ComboBox cb = (ComboBox)c;
//                    cb.Enabled = true;
//                    cb.SelectedIndex = -1;
//                }
//                if (c is RadioButton)
//                {
//                    RadioButton rb = (RadioButton)c;
//                    rb.Enabled = true;
//                    rb.Checked = false;
//                }
//                if (c is CheckBox)
//                {
//                    CheckBox cb = (CheckBox)c;
//                    cb.Enabled = true;
//                    cb.Checked = false;
//                }
//                if (c is DateTimePicker)
//                {
//                    DateTimePicker dtp = (DateTimePicker)c;
//                    dtp.Enabled = true;
//                    dtp.Value = DateTime.Now;
//                }
//            }
//        }

//        public static void enable_reset(GroupBox gb)
//        {
//            foreach (Control c in gb.Controls)
//            {
//                if (c is TextBox)
//                {
//                    TextBox t = (TextBox)c;
//                    t.Enabled = true;
//                    t.Text = " ";
//                }
//                if (c is ComboBox)
//                {
//                    ComboBox cb = (ComboBox)c;
//                    cb.Enabled = true;
//                    cb.SelectedIndex = -1;
//                }
//                if (c is RadioButton)
//                {
//                    RadioButton rb = (RadioButton)c;
//                    rb.Enabled = true;
//                    rb.Checked = false;
//                }
//                if (c is CheckBox)
//                {
//                    CheckBox cb = (CheckBox)c;
//                    cb.Enabled = true;
//                    cb.Checked = false;
//                }
//                if (c is DateTimePicker)
//                {
//                    DateTimePicker dtp = (DateTimePicker)c;
//                    dtp.Enabled = true;
//                    dtp.Value = DateTime.Now;
//                }
//            }
//        }

//        public static void enable(Panel p)
//        {
//            foreach (Control c in p.Controls)
//            {
//                if (c is TextBox)
//                {
//                    TextBox t = (TextBox)c;
//                    t.Enabled = true;

//                }
//                if (c is ComboBox)
//                {
//                    ComboBox cb = (ComboBox)c;
//                    cb.Enabled = true;

//                }
//                if (c is RadioButton)
//                {
//                    RadioButton rb = (RadioButton)c;
//                    rb.Enabled = true;

//                }
//                if (c is CheckBox)
//                {
//                    CheckBox cb = (CheckBox)c;
//                    cb.Enabled = true;

//                }
//                if (c is DateTimePicker)
//                {
//                    DateTimePicker dtp = (DateTimePicker)c;
//                    dtp.Enabled = true;

//                }
//            }
//        }
//    }
//}



// GPT CODE //


using System;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class MainClass
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string configFile = Path.Combine(path, "connect");
        public static SqlConnection con;

        static MainClass()
        {
            try
            {
                if (File.Exists(configFile))
                {
                    string s = File.ReadAllText(configFile);
                    con = new SqlConnection(s);
                }
                else
                {
                    con = null;
                }
            }
            catch (Exception ex)
            {
                ShowMSG("An error occurred while reading the configuration file: " + ex.Message, "Error", "Error");
            }
        }

        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            MessageBoxIcon icon = type == "Success" ? MessageBoxIcon.Information : MessageBoxIcon.Error;
            return MessageBox.Show(msg, heading, MessageBoxButtons.OK, icon);
        }

        public static void showWindow(Form openWin, Form closeWin, Form MDIWin)
        {
            closeWin.Close();
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void showWindow(Form openWin, Form MDIWin)
        {
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox t) { t.Enabled = false; t.Text = string.Empty; }
                if (c is ComboBox cb) { cb.Enabled = false; cb.SelectedIndex = -1; }
                if (c is RadioButton rb) { rb.Enabled = false; rb.Checked = false; }
                if (c is CheckBox cbx) { cbx.Enabled = false; cbx.Checked = false; }
                if (c is DateTimePicker dtp) { dtp.Enabled = false; dtp.Value = DateTime.Now; }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox t) { t.Enabled = true; t.Text = string.Empty; }
                if (c is ComboBox cb) { cb.Enabled = true; cb.SelectedIndex = -1; }
                if (c is RadioButton rb) { rb.Enabled = true; rb.Checked = false; }
                if (c is CheckBox cbx) { cbx.Enabled = true; cbx.Checked = false; }
                if (c is DateTimePicker dtp) { dtp.Enabled = true; dtp.Value = DateTime.Now; }
            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox t) t.Enabled = false;
                if (c is ComboBox cb) cb.Enabled = false;
                if (c is RadioButton rb) rb.Enabled = false;
                if (c is CheckBox cbx) cbx.Enabled = false;
                if (c is DateTimePicker dtp) dtp.Enabled = false;
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox t) t.Enabled = true;
                if (c is ComboBox cb) cb.Enabled = true;
                if (c is RadioButton rb) rb.Enabled = true;
                if (c is CheckBox cbx) cbx.Enabled = true;
                if (c is DateTimePicker dtp) dtp.Enabled = true;
            }
        }

        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {
                if (c is TextBox t)
                {
                    t.Enabled = true;
                    t.Text = string.Empty;
                }
                if (c is ComboBox cb)
                {
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton rb)
                {
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox cbx)
                {
                    cbx.Enabled = true;
                    cbx.Checked = false;
                }
                if (c is DateTimePicker dtp)
                {
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
            }
        }
    }
}
