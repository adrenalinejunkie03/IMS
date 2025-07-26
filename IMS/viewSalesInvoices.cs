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
    public partial class viewSalesInvoices : Sample
    {
        public viewSalesInvoices()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            retrieval r = new retrieval();
            r.showDailySales(dateTimePicker1.Value, dataGridView1, saleIDGV, userGV, totalAmountGV, totalDiscountGV, givenGV, returnGV, userIDGV);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["totalAmountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalAmountGV"].Value));
                row.Cells["totalDiscountGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["totalDiscountGV"].Value));
                row.Cells["givenGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["givenGV"].Value));
                row.Cells["returnGV"].Value = Math.Ceiling(Convert.ToSingle(row.Cells["returnGV"].Value));

            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            MainClass.showWindow(s, this, MDI.ActiveForm);
        }

        public static Int64 salesID = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salesID = Convert.ToInt64(row.Cells["saleIDGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }

        private void viewSalesInvoices_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
