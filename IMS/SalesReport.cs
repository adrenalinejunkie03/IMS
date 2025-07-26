using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Inventory_Management_System
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }
        ReportDocument rd;

        private void Form1_Load(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            rd = new ReportDocument();
            if (viewSalesInvoices.salesID == 0)
            {  
                r.showReport("salesReceipt.rpt", rd, crystalReportViewer2, "st_getSalesReceipt", "@user", retrieval.USER_ID);
            }
            else
            {
                r.showReport("salesReceipt.rpt",rd, crystalReportViewer2, "st_getSalesReceiptWRTSalesID", "@salesID", viewSalesInvoices.salesID);
                viewSalesInvoices.salesID = 0;

            }

        }

        private void SalesReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rd != null)
            {
                rd.Close();
            }
        }
    }
}
