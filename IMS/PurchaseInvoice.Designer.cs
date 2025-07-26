
namespace Inventory_Management_System
{
    partial class PurchaseInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.supplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTEXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTEXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pupTEXT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cartButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.supplierErrorLabel = new System.Windows.Forms.Label();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.totalLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.cartButton);
            this.leftPanel.Controls.Add(this.pupTEXT);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.barcodeText);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.quantityTEXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.productTEXT);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supplierErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Controls.Add(this.quantityErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(221, 494);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.pupTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.cartButton, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totalLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 41);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(579, 494);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Supplier";
            // 
            // supplierDD
            // 
            this.supplierDD.FormattingEnabled = true;
            this.supplierDD.Location = new System.Drawing.Point(7, 134);
            this.supplierDD.Name = "supplierDD";
            this.supplierDD.Size = new System.Drawing.Size(208, 23);
            this.supplierDD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product";
            // 
            // productTEXT
            // 
            this.productTEXT.Location = new System.Drawing.Point(7, 219);
            this.productTEXT.Name = "productTEXT";
            this.productTEXT.Size = new System.Drawing.Size(208, 21);
            this.productTEXT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Quanity";
            // 
            // quantityTEXT
            // 
            this.quantityTEXT.Location = new System.Drawing.Point(7, 305);
            this.quantityTEXT.Name = "quantityTEXT";
            this.quantityTEXT.Size = new System.Drawing.Size(208, 21);
            this.quantityTEXT.TabIndex = 4;
            this.quantityTEXT.TextChanged += new System.EventHandler(this.quantityTEXT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barcode";
            // 
            // barcodeText
            // 
            this.barcodeText.Location = new System.Drawing.Point(7, 176);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(208, 21);
            this.barcodeText.TabIndex = 1;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            this.barcodeText.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeText_Validating);
            this.barcodeText.Validated += new System.EventHandler(this.barcodeText_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Per Unit Price";
            // 
            // pupTEXT
            // 
            this.pupTEXT.Location = new System.Drawing.Point(7, 266);
            this.pupTEXT.Name = "pupTEXT";
            this.pupTEXT.Size = new System.Drawing.Size(208, 21);
            this.pupTEXT.TabIndex = 3;
            this.pupTEXT.TextChanged += new System.EventHandler(this.pupTEXT_TextChanged);
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
            this.quantityGV,
            this.pupGV,
            this.totalGV,
            this.actionGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(579, 326);
            this.dataGridView1.TabIndex = 4;
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
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // pupGV
            // 
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // totalGV
            // 
            this.totalGV.HeaderText = "Total Amount";
            this.totalGV.Name = "totalGV";
            this.totalGV.ReadOnly = true;
            // 
            // actionGV
            // 
            this.actionGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actionGV.HeaderText = "Action";
            this.actionGV.Name = "actionGV";
            this.actionGV.ReadOnly = true;
            this.actionGV.Text = "DELETE";
            this.actionGV.UseColumnTextForButtonValue = true;
            // 
            // cartButton
            // 
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.FlatAppearance.BorderSize = 2;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cartButton.Location = new System.Drawing.Point(7, 349);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(208, 40);
            this.cartButton.TabIndex = 5;
            this.cartButton.Text = "ADD TO CART";
            this.cartButton.UseVisualStyleBackColor = true;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(59, 414);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(80, 37);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "0.00";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(579, 61);
            this.panel5.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.28497F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.71503F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(579, 61);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(371, 61);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gross Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grossLabel
            // 
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(380, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(196, 61);
            this.grossLabel.TabIndex = 13;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // supplierErrorLabel
            // 
            this.supplierErrorLabel.AutoSize = true;
            this.supplierErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.supplierErrorLabel.Location = new System.Drawing.Point(198, 120);
            this.supplierErrorLabel.Name = "supplierErrorLabel";
            this.supplierErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.supplierErrorLabel.TabIndex = 14;
            this.supplierErrorLabel.Text = "*";
            this.supplierErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(198, 163);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.barcodeErrorLabel.TabIndex = 15;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.quantityErrorLabel.Location = new System.Drawing.Point(198, 291);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.quantityErrorLabel.TabIndex = 16;
            this.quantityErrorLabel.Text = "*";
            this.quantityErrorLabel.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox supplierDD;
        private System.Windows.Forms.TextBox quantityTEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productTEXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pupTEXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label supplierErrorLabel;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn actionGV;
    }
}