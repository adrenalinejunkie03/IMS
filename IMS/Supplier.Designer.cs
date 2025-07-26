
namespace Inventory_Management_System
{
    partial class Supplier
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
            this.supplierCompanyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.personNameText = new System.Windows.Forms.TextBox();
            this.phone1Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phone2Text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ntnText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.supplierNameErrorLabel = new System.Windows.Forms.Label();
            this.contactPersonErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.addressErrorLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label11);
            this.leftPanel.Controls.Add(this.ntnText);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.addressText);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.phone2Text);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.phone1Text);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.personNameText);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.supplierCompanyText);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.supplierNameErrorLabel);
            this.leftPanel.Controls.Add(this.contactPersonErrorLabel);
            this.leftPanel.Controls.Add(this.phoneErrorLabel);
            this.leftPanel.Controls.Add(this.addressErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.contactPersonErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.supplierCompanyText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.personNameText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone1Text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.phone2Text, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.addressText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.ntnText, 0);
            this.leftPanel.Controls.SetChildIndex(this.label11, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 41);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name / Company";
            // 
            // supplierCompanyText
            // 
            this.supplierCompanyText.Location = new System.Drawing.Point(7, 134);
            this.supplierCompanyText.MaxLength = 100;
            this.supplierCompanyText.Name = "supplierCompanyText";
            this.supplierCompanyText.Size = new System.Drawing.Size(208, 21);
            this.supplierCompanyText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Person";
            // 
            // personNameText
            // 
            this.personNameText.Location = new System.Drawing.Point(7, 176);
            this.personNameText.MaxLength = 50;
            this.personNameText.Name = "personNameText";
            this.personNameText.Size = new System.Drawing.Size(208, 21);
            this.personNameText.TabIndex = 5;
            // 
            // phone1Text
            // 
            this.phone1Text.Location = new System.Drawing.Point(7, 218);
            this.phone1Text.MaxLength = 15;
            this.phone1Text.Name = "phone1Text";
            this.phone1Text.Size = new System.Drawing.Size(208, 21);
            this.phone1Text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone 1";
            // 
            // phone2Text
            // 
            this.phone2Text.Location = new System.Drawing.Point(7, 259);
            this.phone2Text.MaxLength = 15;
            this.phone2Text.Name = "phone2Text";
            this.phone2Text.Size = new System.Drawing.Size(208, 21);
            this.phone2Text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone 2";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(7, 301);
            this.addressText.MaxLength = 100;
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(208, 21);
            this.addressText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // ntnText
            // 
            this.ntnText.Location = new System.Drawing.Point(7, 343);
            this.ntnText.MaxLength = 25;
            this.ntnText.Name = "ntnText";
            this.ntnText.Size = new System.Drawing.Size(208, 21);
            this.ntnText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "NTN#";
            // 
            // supplierNameErrorLabel
            // 
            this.supplierNameErrorLabel.AutoSize = true;
            this.supplierNameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNameErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.supplierNameErrorLabel.Location = new System.Drawing.Point(198, 119);
            this.supplierNameErrorLabel.Name = "supplierNameErrorLabel";
            this.supplierNameErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.supplierNameErrorLabel.TabIndex = 14;
            this.supplierNameErrorLabel.Text = "*";
            this.supplierNameErrorLabel.Visible = false;
            // 
            // contactPersonErrorLabel
            // 
            this.contactPersonErrorLabel.AutoSize = true;
            this.contactPersonErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPersonErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.contactPersonErrorLabel.Location = new System.Drawing.Point(198, 163);
            this.contactPersonErrorLabel.Name = "contactPersonErrorLabel";
            this.contactPersonErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.contactPersonErrorLabel.TabIndex = 15;
            this.contactPersonErrorLabel.Text = "*";
            this.contactPersonErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.phoneErrorLabel.Location = new System.Drawing.Point(198, 204);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.phoneErrorLabel.TabIndex = 16;
            this.phoneErrorLabel.Text = "*";
            this.phoneErrorLabel.Visible = false;
            // 
            // addressErrorLabel
            // 
            this.addressErrorLabel.AutoSize = true;
            this.addressErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.addressErrorLabel.Location = new System.Drawing.Point(198, 287);
            this.addressErrorLabel.Name = "addressErrorLabel";
            this.addressErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.addressErrorLabel.TabIndex = 17;
            this.addressErrorLabel.Text = "*";
            this.addressErrorLabel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(9, 386);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(209, 23);
            this.statusDD.TabIndex = 19;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.statusErrorLabel.Location = new System.Drawing.Point(198, 371);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.statusErrorLabel.TabIndex = 20;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
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
            this.supplierIDGV,
            this.companyGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.StatusGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(579, 343);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // supplierIDGV
            // 
            this.supplierIDGV.HeaderText = "SupplierID";
            this.supplierIDGV.Name = "supplierIDGV";
            this.supplierIDGV.ReadOnly = true;
            this.supplierIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "ContactPerson";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // StatusGV
            // 
            this.StatusGV.HeaderText = "Status";
            this.StatusGV.Name = "StatusGV";
            this.StatusGV.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ntnText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone2Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone1Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox personNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox supplierCompanyText;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label supplierNameErrorLabel;
        private System.Windows.Forms.Label contactPersonErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label addressErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGV;
    }
}