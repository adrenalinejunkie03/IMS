
namespace Inventory_Management_System
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.productTEXT = new System.Windows.Forms.TextBox();
            this.productErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodeTEXT = new System.Windows.Forms.TextBox();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expiryErrorLabel = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryDD = new System.Windows.Forms.ComboBox();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(647, 40);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.expiryPicker);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.expiryErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeTEXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.productTEXT);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.productErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.categoryErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(221, 498);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.productErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.expiryPicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryDD, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 41);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(647, 498);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // productTEXT
            // 
            this.productTEXT.Location = new System.Drawing.Point(7, 130);
            this.productTEXT.Name = "productTEXT";
            this.productTEXT.Size = new System.Drawing.Size(208, 21);
            this.productTEXT.TabIndex = 3;
            // 
            // productErrorLabel
            // 
            this.productErrorLabel.AutoSize = true;
            this.productErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productErrorLabel.Location = new System.Drawing.Point(87, 111);
            this.productErrorLabel.Name = "productErrorLabel";
            this.productErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.productErrorLabel.TabIndex = 13;
            this.productErrorLabel.Text = "*";
            this.productErrorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Barcode";
            // 
            // barcodeTEXT
            // 
            this.barcodeTEXT.Location = new System.Drawing.Point(7, 172);
            this.barcodeTEXT.Name = "barcodeTEXT";
            this.barcodeTEXT.Size = new System.Drawing.Size(208, 21);
            this.barcodeTEXT.TabIndex = 15;
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(62, 154);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.barcodeErrorLabel.TabIndex = 16;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expiry Date";
            // 
            // expiryErrorLabel
            // 
            this.expiryErrorLabel.AutoSize = true;
            this.expiryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.expiryErrorLabel.Location = new System.Drawing.Point(62, 196);
            this.expiryErrorLabel.Name = "expiryErrorLabel";
            this.expiryErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.expiryErrorLabel.TabIndex = 19;
            this.expiryErrorLabel.Text = "*";
            this.expiryErrorLabel.Visible = false;
            // 
            // expiryPicker
            // 
            this.expiryPicker.CustomFormat = "dd-MMM-yyyy";
            this.expiryPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryPicker.Location = new System.Drawing.Point(7, 215);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(208, 21);
            this.expiryPicker.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(79, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "*";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Category";
            // 
            // categoryDD
            // 
            this.categoryDD.FormattingEnabled = true;
            this.categoryDD.Location = new System.Drawing.Point(7, 258);
            this.categoryDD.Name = "categoryDD";
            this.categoryDD.Size = new System.Drawing.Size(208, 23);
            this.categoryDD.TabIndex = 26;
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.categoryErrorLabel.Location = new System.Drawing.Point(62, 239);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.categoryErrorLabel.TabIndex = 27;
            this.categoryErrorLabel.Text = "*";
            this.categoryErrorLabel.Visible = false;
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
            this.productIDGV,
            this.productGV,
            this.barcodeGV,
            this.expiryGV,
            this.categoryIDGV,
            this.catGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(647, 391);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productIDGV
            // 
            this.productIDGV.HeaderText = "productID";
            this.productIDGV.Name = "productIDGV";
            this.productIDGV.ReadOnly = true;
            this.productIDGV.Visible = false;
            // 
            // productGV
            // 
            this.productGV.HeaderText = "Product";
            this.productGV.Name = "productGV";
            this.productGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // categoryIDGV
            // 
            this.categoryIDGV.HeaderText = "CategoryID";
            this.categoryIDGV.Name = "categoryIDGV";
            this.categoryIDGV.ReadOnly = true;
            this.categoryIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productTEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productErrorLabel;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label expiryErrorLabel;
        private System.Windows.Forms.TextBox barcodeTEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox categoryDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}