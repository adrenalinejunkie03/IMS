
namespace Inventory_Management_System
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTEXT = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.changeGivenTEXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.amountGivenTEXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalDiscountTEXT = new System.Windows.Forms.TextBox();
            this.grossTEXT = new System.Windows.Forms.TextBox();
            this.payDD = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(674, 40);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Size = new System.Drawing.Size(221, 40);
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
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Controls.Add(this.panel7);
            this.leftPanel.Size = new System.Drawing.Size(221, 597);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel7, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.SetChildIndex(this.backButton, 0);
            this.panel2.Controls.SetChildIndex(this.panel6, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(674, 597);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Barcode";
            // 
            // barcodeTEXT
            // 
            this.barcodeTEXT.Location = new System.Drawing.Point(3, 6);
            this.barcodeTEXT.MaxLength = 100;
            this.barcodeTEXT.Name = "barcodeTEXT";
            this.barcodeTEXT.Size = new System.Drawing.Size(212, 21);
            this.barcodeTEXT.TabIndex = 3;
            this.barcodeTEXT.TextChanged += new System.EventHandler(this.barcodeTEXT_TextChanged);
            this.barcodeTEXT.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTEXT_Validating);
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
            this.discGV,
            this.totalGV,
            this.actionGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(674, 326);
            this.dataGridView1.TabIndex = 5;
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
            // discGV
            // 
            this.discGV.HeaderText = "Discount";
            this.discGV.Name = "discGV";
            this.discGV.ReadOnly = true;
            this.discGV.Visible = false;
            // 
            // totalGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalGV.DefaultCellStyle = dataGridViewCellStyle2;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 433);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(674, 164);
            this.panel5.TabIndex = 6;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(674, 164);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(434, 164);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gross Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grossLabel
            // 
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(443, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(228, 164);
            this.grossLabel.TabIndex = 13;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.Firebrick;
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.FlatAppearance.BorderSize = 2;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Location = new System.Drawing.Point(9, 356);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(203, 76);
            this.payButton.TabIndex = 4;
            this.payButton.Text = "&PAY";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkoutButton);
            this.groupBox2.Controls.Add(this.changeGivenTEXT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.amountGivenTEXT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.totalDiscountTEXT);
            this.groupBox2.Controls.Add(this.grossTEXT);
            this.groupBox2.Controls.Add(this.payDD);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.payButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 454);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payments";
            // 
            // checkoutButton
            // 
            this.checkoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.checkoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutButton.FlatAppearance.BorderSize = 2;
            this.checkoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutButton.Location = new System.Drawing.Point(12, 290);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(200, 60);
            this.checkoutButton.TabIndex = 14;
            this.checkoutButton.Text = "&CHECKOUT";
            this.checkoutButton.UseVisualStyleBackColor = false;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // changeGivenTEXT
            // 
            this.changeGivenTEXT.Enabled = false;
            this.changeGivenTEXT.Location = new System.Drawing.Point(6, 238);
            this.changeGivenTEXT.MaxLength = 100;
            this.changeGivenTEXT.Name = "changeGivenTEXT";
            this.changeGivenTEXT.Size = new System.Drawing.Size(212, 21);
            this.changeGivenTEXT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Change To Give";
            // 
            // amountGivenTEXT
            // 
            this.amountGivenTEXT.Location = new System.Drawing.Point(6, 187);
            this.amountGivenTEXT.MaxLength = 100;
            this.amountGivenTEXT.Name = "amountGivenTEXT";
            this.amountGivenTEXT.Size = new System.Drawing.Size(212, 21);
            this.amountGivenTEXT.TabIndex = 11;
            this.amountGivenTEXT.TextChanged += new System.EventHandler(this.amountGivenTEXT_TextChanged);
            this.amountGivenTEXT.Validating += new System.ComponentModel.CancelEventHandler(this.amountGivenTEXT_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount Given";
            // 
            // totalDiscountTEXT
            // 
            this.totalDiscountTEXT.Enabled = false;
            this.totalDiscountTEXT.Location = new System.Drawing.Point(6, 85);
            this.totalDiscountTEXT.MaxLength = 100;
            this.totalDiscountTEXT.Name = "totalDiscountTEXT";
            this.totalDiscountTEXT.Size = new System.Drawing.Size(212, 21);
            this.totalDiscountTEXT.TabIndex = 9;
            // 
            // grossTEXT
            // 
            this.grossTEXT.Enabled = false;
            this.grossTEXT.Location = new System.Drawing.Point(6, 39);
            this.grossTEXT.MaxLength = 100;
            this.grossTEXT.Name = "grossTEXT";
            this.grossTEXT.Size = new System.Drawing.Size(212, 21);
            this.grossTEXT.TabIndex = 4;
            // 
            // payDD
            // 
            this.payDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payDD.FormattingEnabled = true;
            this.payDD.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card",
            ""});
            this.payDD.Location = new System.Drawing.Point(7, 133);
            this.payDD.Name = "payDD";
            this.payDD.Size = new System.Drawing.Size(211, 23);
            this.payDD.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Payment Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gross Total";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(12, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 22);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.barcodeTEXT);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(221, 36);
            this.panel7.TabIndex = 6;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 597);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTEXT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox changeGivenTEXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amountGivenTEXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalDiscountTEXT;
        private System.Windows.Forms.TextBox grossTEXT;
        private System.Windows.Forms.ComboBox payDD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGV;
        private System.Windows.Forms.DataGridViewButtonColumn actionGV;
    }
}