
namespace Inventory_Management_System
{
    partial class SalesReturnWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.salesIDText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaleIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProductDiscGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perProductTotGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totDiscGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGivenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountReturnedGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.userTEXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentTEXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodeTEXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.refundTEXT = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTEXT
            // 
            this.searchTEXT.TextChanged += new System.EventHandler(this.searchTEXT_TextChanged_1);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.refundTEXT);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.barcodeTEXT);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.paymentTEXT);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.userTEXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.dateTimePicker1);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.LoadButton);
            this.leftPanel.Controls.Add(this.salesIDText);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(221, 532);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.salesIDText, 0);
            this.leftPanel.Controls.SetChildIndex(this.LoadButton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.paymentTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.refundTEXT, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(579, 532);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Sales ID";
            // 
            // salesIDText
            // 
            this.salesIDText.Location = new System.Drawing.Point(3, 144);
            this.salesIDText.Name = "salesIDText";
            this.salesIDText.Size = new System.Drawing.Size(212, 21);
            this.salesIDText.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDGV,
            this.barcodeGV,
            this.productGV,
            this.quantityGV,
            this.priceGV,
            this.perProductDiscGV,
            this.perProductTotGV,
            this.totDiscGV,
            this.totAmountGV,
            this.amountGivenGV,
            this.amountReturnedGV,
            this.dateGV,
            this.paymentGV,
            this.userGV,
            this.proIDGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 326);
            this.dataGridView1.TabIndex = 6;
            // 
            // SaleIDGV
            // 
            this.SaleIDGV.HeaderText = "Sale ID";
            this.SaleIDGV.Name = "SaleIDGV";
            this.SaleIDGV.ReadOnly = true;
            this.SaleIDGV.Visible = false;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // priceGV
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.priceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceGV.HeaderText = "Price";
            this.priceGV.Name = "priceGV";
            this.priceGV.ReadOnly = true;
            // 
            // perProductDiscGV
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.perProductDiscGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.perProductDiscGV.HeaderText = "Per Product Discount";
            this.perProductDiscGV.Name = "perProductDiscGV";
            this.perProductDiscGV.ReadOnly = true;
            this.perProductDiscGV.Visible = false;
            // 
            // perProductTotGV
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.perProductTotGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.perProductTotGV.HeaderText = "Per Product Total";
            this.perProductTotGV.Name = "perProductTotGV";
            this.perProductTotGV.ReadOnly = true;
            // 
            // totDiscGV
            // 
            this.totDiscGV.HeaderText = "Total Discount";
            this.totDiscGV.Name = "totDiscGV";
            this.totDiscGV.ReadOnly = true;
            this.totDiscGV.Visible = false;
            // 
            // totAmountGV
            // 
            this.totAmountGV.HeaderText = "Total Amount";
            this.totAmountGV.Name = "totAmountGV";
            this.totAmountGV.ReadOnly = true;
            this.totAmountGV.Visible = false;
            // 
            // amountGivenGV
            // 
            this.amountGivenGV.HeaderText = "Amount Given";
            this.amountGivenGV.Name = "amountGivenGV";
            this.amountGivenGV.ReadOnly = true;
            this.amountGivenGV.Visible = false;
            // 
            // amountReturnedGV
            // 
            this.amountReturnedGV.HeaderText = "Amount Returned";
            this.amountReturnedGV.Name = "amountReturnedGV";
            this.amountReturnedGV.ReadOnly = true;
            this.amountReturnedGV.Visible = false;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            this.dateGV.Visible = false;
            // 
            // paymentGV
            // 
            this.paymentGV.HeaderText = "Payment";
            this.paymentGV.Name = "paymentGV";
            this.paymentGV.ReadOnly = true;
            this.paymentGV.Visible = false;
            // 
            // userGV
            // 
            this.userGV.HeaderText = "User";
            this.userGV.Name = "userGV";
            this.userGV.ReadOnly = true;
            this.userGV.Visible = false;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Firebrick;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatAppearance.BorderSize = 2;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Location = new System.Drawing.Point(6, 171);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(203, 41);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "&LOAD";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy hh:mm:ss tt";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 238);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "User";
            // 
            // userTEXT
            // 
            this.userTEXT.Enabled = false;
            this.userTEXT.Location = new System.Drawing.Point(9, 290);
            this.userTEXT.Name = "userTEXT";
            this.userTEXT.Size = new System.Drawing.Size(200, 21);
            this.userTEXT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Payment Type";
            // 
            // paymentTEXT
            // 
            this.paymentTEXT.Enabled = false;
            this.paymentTEXT.Location = new System.Drawing.Point(9, 333);
            this.paymentTEXT.Name = "paymentTEXT";
            this.paymentTEXT.Size = new System.Drawing.Size(200, 21);
            this.paymentTEXT.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter Barcode";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // barcodeTEXT
            // 
            this.barcodeTEXT.Enabled = false;
            this.barcodeTEXT.Location = new System.Drawing.Point(6, 375);
            this.barcodeTEXT.Name = "barcodeTEXT";
            this.barcodeTEXT.Size = new System.Drawing.Size(200, 21);
            this.barcodeTEXT.TabIndex = 13;
            this.barcodeTEXT.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTEXT_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount To Refund";
            // 
            // refundTEXT
            // 
            this.refundTEXT.Enabled = false;
            this.refundTEXT.Location = new System.Drawing.Point(6, 417);
            this.refundTEXT.Name = "refundTEXT";
            this.refundTEXT.Size = new System.Drawing.Size(200, 21);
            this.refundTEXT.TabIndex = 15;
            // 
            // SalesReturnWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Name = "SalesReturnWindow";
            this.Text = "Sales Return Window";
            this.Load += new System.EventHandler(this.SalesReturnWindow_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox salesIDText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox paymentTEXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userTEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProductDiscGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn perProductTotGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totDiscGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totAmountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGivenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountReturnedGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.TextBox refundTEXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barcodeTEXT;
        private System.Windows.Forms.Label label6;
    }
}