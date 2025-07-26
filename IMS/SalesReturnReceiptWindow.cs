using CrystalDecisions.CrystalReports.Engine;
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
    public partial class SalesReturnReceiptWindow : Form
    {
        public SalesReturnReceiptWindow()
        {
            InitializeComponent();
        }

        ReportDocument rd;
        retrieval r = new retrieval();
        private void SalesReturnReceiptWindow_Load(object sender, EventArgs e)
        {
            rd = new ReportDocument();
            r.showReport("RefundInvoiceReport.rpt",rd,crystalReportViewer2,"st_getRefundInvoice", "@saleID","53564");
        }
    }
}
