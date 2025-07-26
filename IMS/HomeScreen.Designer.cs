
namespace Inventory_Management_System
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.priceButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.productDD = new System.Windows.Forms.Button();
            this.stockButton = new System.Windows.Forms.Button();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.supplierButton = new System.Windows.Forms.Button();
            this.salesReturnbutton = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(221, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(579, 450);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.usersButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productDD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.stockButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.salesButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.categoryButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.supplierButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.salesReturnbutton, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 383);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // priceButton
            // 
            this.priceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.priceButton.FlatAppearance.BorderSize = 2;
            this.priceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceButton.Image = global::Inventory_Management_System.Properties.Resources.Product_Pricing;
            this.priceButton.Location = new System.Drawing.Point(233, 79);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(109, 70);
            this.priceButton.TabIndex = 7;
            this.priceButton.Text = "Product Pricing";
            this.priceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.usersButton.FlatAppearance.BorderSize = 2;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.Image = global::Inventory_Management_System.Properties.Resources.users;
            this.usersButton.Location = new System.Drawing.Point(3, 3);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(109, 70);
            this.usersButton.TabIndex = 0;
            this.usersButton.Text = "Users";
            this.usersButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // productDD
            // 
            this.productDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productDD.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.productDD.FlatAppearance.BorderSize = 2;
            this.productDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDD.Image = global::Inventory_Management_System.Properties.Resources.products;
            this.productDD.Location = new System.Drawing.Point(118, 3);
            this.productDD.Name = "productDD";
            this.productDD.Size = new System.Drawing.Size(109, 70);
            this.productDD.TabIndex = 1;
            this.productDD.Text = "Products";
            this.productDD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.productDD.UseVisualStyleBackColor = true;
            this.productDD.Click += new System.EventHandler(this.productDD_Click);
            // 
            // stockButton
            // 
            this.stockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.stockButton.FlatAppearance.BorderSize = 2;
            this.stockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockButton.Image = global::Inventory_Management_System.Properties.Resources.stock1;
            this.stockButton.Location = new System.Drawing.Point(233, 3);
            this.stockButton.Name = "stockButton";
            this.stockButton.Size = new System.Drawing.Size(109, 70);
            this.stockButton.TabIndex = 2;
            this.stockButton.Text = "Stock";
            this.stockButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stockButton.UseVisualStyleBackColor = true;
            this.stockButton.Click += new System.EventHandler(this.stockButton_Click);
            // 
            // purchaseButton
            // 
            this.purchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.purchaseButton.FlatAppearance.BorderSize = 2;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.Image = global::Inventory_Management_System.Properties.Resources.Purchase_Invoice1;
            this.purchaseButton.Location = new System.Drawing.Point(348, 3);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(109, 70);
            this.purchaseButton.TabIndex = 3;
            this.purchaseButton.Text = "Purchase Invoice";
            this.purchaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.salesButton.FlatAppearance.BorderSize = 2;
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesButton.Image = global::Inventory_Management_System.Properties.Resources.Sales1;
            this.salesButton.Location = new System.Drawing.Point(463, 3);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(113, 70);
            this.salesButton.TabIndex = 4;
            this.salesButton.Text = "Sales";
            this.salesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.categoryButton.FlatAppearance.BorderSize = 2;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryButton.Image = global::Inventory_Management_System.Properties.Resources.Categories;
            this.categoryButton.Location = new System.Drawing.Point(3, 79);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(109, 70);
            this.categoryButton.TabIndex = 5;
            this.categoryButton.Text = "Categories";
            this.categoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // supplierButton
            // 
            this.supplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.supplierButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.supplierButton.FlatAppearance.BorderSize = 2;
            this.supplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierButton.Image = global::Inventory_Management_System.Properties.Resources.Supplier2;
            this.supplierButton.Location = new System.Drawing.Point(118, 79);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(109, 70);
            this.supplierButton.TabIndex = 6;
            this.supplierButton.Text = "Suppliers";
            this.supplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.supplierButton.UseVisualStyleBackColor = true;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            // 
            // salesReturnbutton
            // 
            this.salesReturnbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesReturnbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesReturnbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.salesReturnbutton.FlatAppearance.BorderSize = 2;
            this.salesReturnbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesReturnbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesReturnbutton.Image = global::Inventory_Management_System.Properties.Resources.sales_return2;
            this.salesReturnbutton.Location = new System.Drawing.Point(348, 79);
            this.salesReturnbutton.Name = "salesReturnbutton";
            this.salesReturnbutton.Size = new System.Drawing.Size(109, 70);
            this.salesReturnbutton.TabIndex = 8;
            this.salesReturnbutton.Text = "Sales Return";
            this.salesReturnbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.salesReturnbutton.UseVisualStyleBackColor = true;
            this.salesReturnbutton.Click += new System.EventHandler(this.salesReturnbutton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button productDD;
        private System.Windows.Forms.Button stockButton;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button supplierButton;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button salesReturnbutton;
    }
}