
namespace Inventory_Management_System
{
    partial class login
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
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTEXT = new System.Windows.Forms.TextBox();
            this.passwordTEXT = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.loginButton);
            this.leftPanel.Controls.Add(this.passwordTEXT);
            this.leftPanel.Controls.Add(this.usernameTEXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.nameErrorLabel);
            this.leftPanel.Controls.Add(this.passwordErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(221, 450);
            this.leftPanel.Controls.SetChildIndex(this.passwordErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTEXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.loginButton, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.BackgroundImage = global::Inventory_Management_System.Properties.Resources.users_login;
            this.rightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rightPanel.Size = new System.Drawing.Size(579, 450);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // usernameTEXT
            // 
            this.usernameTEXT.Location = new System.Drawing.Point(16, 150);
            this.usernameTEXT.MaxLength = 30;
            this.usernameTEXT.Name = "usernameTEXT";
            this.usernameTEXT.Size = new System.Drawing.Size(174, 21);
            this.usernameTEXT.TabIndex = 3;
            this.usernameTEXT.TextChanged += new System.EventHandler(this.usernameTEXT_TextChanged);
            // 
            // passwordTEXT
            // 
            this.passwordTEXT.Location = new System.Drawing.Point(16, 199);
            this.passwordTEXT.Name = "passwordTEXT";
            this.passwordTEXT.Size = new System.Drawing.Size(174, 21);
            this.passwordTEXT.TabIndex = 4;
            this.passwordTEXT.UseSystemPasswordChar = true;
            this.passwordTEXT.TextChanged += new System.EventHandler(this.passwordTEXT_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderSize = 2;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(16, 226);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(179, 34);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.nameErrorLabel.Location = new System.Drawing.Point(173, 136);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.nameErrorLabel.TabIndex = 13;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passwordErrorLabel.Location = new System.Drawing.Point(174, 184);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(17, 24);
            this.passwordErrorLabel.TabIndex = 14;
            this.passwordErrorLabel.Text = "*";
            this.passwordErrorLabel.Visible = false;
            // 
            // login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTEXT;
        private System.Windows.Forms.TextBox usernameTEXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
    }
}