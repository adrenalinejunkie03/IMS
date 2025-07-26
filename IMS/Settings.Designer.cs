
namespace Inventory_Management_System
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.serverTEXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseTEXT = new System.Windows.Forms.TextBox();
            this.userIDTEXT = new System.Windows.Forms.TextBox();
            this.pswdTEXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.integratedsecurityCHECKBOX = new System.Windows.Forms.CheckBox();
            this.saveBUTTON = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBUTTON);
            this.leftPanel.Controls.Add(this.integratedsecurityCHECKBOX);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.pswdTEXT);
            this.leftPanel.Controls.Add(this.userIDTEXT);
            this.leftPanel.Controls.Add(this.databaseTEXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTEXT);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(221, 450);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIDTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.pswdTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.integratedsecurityCHECKBOX, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBUTTON, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(579, 450);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // serverTEXT
            // 
            this.serverTEXT.Location = new System.Drawing.Point(13, 159);
            this.serverTEXT.MaxLength = 50;
            this.serverTEXT.Name = "serverTEXT";
            this.serverTEXT.Size = new System.Drawing.Size(202, 21);
            this.serverTEXT.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // databaseTEXT
            // 
            this.databaseTEXT.Location = new System.Drawing.Point(13, 214);
            this.databaseTEXT.MaxLength = 50;
            this.databaseTEXT.Name = "databaseTEXT";
            this.databaseTEXT.Size = new System.Drawing.Size(202, 21);
            this.databaseTEXT.TabIndex = 4;
            // 
            // userIDTEXT
            // 
            this.userIDTEXT.Location = new System.Drawing.Point(13, 271);
            this.userIDTEXT.MaxLength = 30;
            this.userIDTEXT.Name = "userIDTEXT";
            this.userIDTEXT.Size = new System.Drawing.Size(202, 21);
            this.userIDTEXT.TabIndex = 5;
            // 
            // pswdTEXT
            // 
            this.pswdTEXT.Location = new System.Drawing.Point(12, 327);
            this.pswdTEXT.MaxLength = 30;
            this.pswdTEXT.Name = "pswdTEXT";
            this.pswdTEXT.Size = new System.Drawing.Size(203, 21);
            this.pswdTEXT.TabIndex = 6;
            this.pswdTEXT.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "UserID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // integratedsecurityCHECKBOX
            // 
            this.integratedsecurityCHECKBOX.AutoSize = true;
            this.integratedsecurityCHECKBOX.Location = new System.Drawing.Point(16, 370);
            this.integratedsecurityCHECKBOX.Name = "integratedsecurityCHECKBOX";
            this.integratedsecurityCHECKBOX.Size = new System.Drawing.Size(127, 19);
            this.integratedsecurityCHECKBOX.TabIndex = 9;
            this.integratedsecurityCHECKBOX.Text = "Integrated Security";
            this.integratedsecurityCHECKBOX.UseVisualStyleBackColor = true;
            this.integratedsecurityCHECKBOX.CheckedChanged += new System.EventHandler(this.integratedsecurityCHECKBOX_CheckedChanged);
            // 
            // saveBUTTON
            // 
            this.saveBUTTON.FlatAppearance.BorderSize = 2;
            this.saveBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBUTTON.Location = new System.Drawing.Point(13, 396);
            this.saveBUTTON.Name = "saveBUTTON";
            this.saveBUTTON.Size = new System.Drawing.Size(202, 42);
            this.saveBUTTON.TabIndex = 10;
            this.saveBUTTON.Text = "SAVE";
            this.saveBUTTON.UseVisualStyleBackColor = true;
            this.saveBUTTON.Click += new System.EventHandler(this.saveBUTTON_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBUTTON;
        private System.Windows.Forms.CheckBox integratedsecurityCHECKBOX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pswdTEXT;
        private System.Windows.Forms.TextBox userIDTEXT;
        private System.Windows.Forms.TextBox databaseTEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTEXT;
    }
}