namespace Coffee_shop
{
    partial class User
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
            this.ItemsCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RichOrder = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Button();
            this.AddITem = new System.Windows.Forms.Button();
            this.NbOrder = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CoffeeProducts = new System.Windows.Forms.Button();
            this.AllProducts = new System.Windows.Forms.Button();
            this.ProductInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NbOrder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsCb
            // 
            this.ItemsCb.FormattingEnabled = true;
            this.ItemsCb.Location = new System.Drawing.Point(157, 64);
            this.ItemsCb.Name = "ItemsCb";
            this.ItemsCb.Size = new System.Drawing.Size(140, 23);
            this.ItemsCb.TabIndex = 0;
            this.ItemsCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available items";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RichOrder
            // 
            this.RichOrder.Location = new System.Drawing.Point(452, 64);
            this.RichOrder.Name = "RichOrder";
            this.RichOrder.ReadOnly = true;
            this.RichOrder.Size = new System.Drawing.Size(100, 96);
            this.RichOrder.TabIndex = 2;
            this.RichOrder.Text = "";
            this.RichOrder.TextChanged += new System.EventHandler(this.RichOrder_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your order";
            // 
            // TextBill
            // 
            this.TextBill.Location = new System.Drawing.Point(452, 185);
            this.TextBill.Name = "TextBill";
            this.TextBill.ReadOnly = true;
            this.TextBill.Size = new System.Drawing.Size(100, 23);
            this.TextBill.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Bill";
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(452, 258);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(75, 23);
            this.Order.TabIndex = 6;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.printorder);
            // 
            // AddITem
            // 
            this.AddITem.Location = new System.Drawing.Point(182, 279);
            this.AddITem.Name = "AddITem";
            this.AddITem.Size = new System.Drawing.Size(75, 23);
            this.AddITem.TabIndex = 8;
            this.AddITem.Text = "Add Item";
            this.AddITem.UseVisualStyleBackColor = true;
            this.AddITem.Click += new System.EventHandler(this.AddITem_Click);
            // 
            // NbOrder
            // 
            this.NbOrder.Location = new System.Drawing.Point(303, 65);
            this.NbOrder.Name = "NbOrder";
            this.NbOrder.Size = new System.Drawing.Size(120, 23);
            this.NbOrder.TabIndex = 9;
            this.NbOrder.ValueChanged += new System.EventHandler(this.NbOrder_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of items";
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.Location = new System.Drawing.Point(157, 155);
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.Size = new System.Drawing.Size(100, 23);
            this.QuantityInStock.TabIndex = 11;
            this.QuantityInStock.TextChanged += new System.EventHandler(this.QuantityInStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantity In Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFormToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.loginFormToolStripMenuItem.Text = "LoginForm";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // ItemPrice
            // 
            this.ItemPrice.Location = new System.Drawing.Point(157, 110);
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Size = new System.Drawing.Size(100, 23);
            this.ItemPrice.TabIndex = 14;
            this.ItemPrice.TextChanged += new System.EventHandler(this.ItemPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Price per 1 Item";
            // 
            // CoffeeProducts
            // 
            this.CoffeeProducts.Location = new System.Drawing.Point(274, 109);
            this.CoffeeProducts.Name = "CoffeeProducts";
            this.CoffeeProducts.Size = new System.Drawing.Size(117, 23);
            this.CoffeeProducts.TabIndex = 16;
            this.CoffeeProducts.Text = "Coffee Products";
            this.CoffeeProducts.UseVisualStyleBackColor = true;
            this.CoffeeProducts.Click += new System.EventHandler(this.CoffeeProducts_Click);
            // 
            // AllProducts
            // 
            this.AllProducts.Location = new System.Drawing.Point(274, 138);
            this.AllProducts.Name = "AllProducts";
            this.AllProducts.Size = new System.Drawing.Size(117, 23);
            this.AllProducts.TabIndex = 17;
            this.AllProducts.Text = "AllProducts";
            this.AllProducts.UseVisualStyleBackColor = true;
            this.AllProducts.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProductInfo
            // 
            this.ProductInfo.Location = new System.Drawing.Point(274, 167);
            this.ProductInfo.Name = "ProductInfo";
            this.ProductInfo.Size = new System.Drawing.Size(117, 23);
            this.ProductInfo.TabIndex = 18;
            this.ProductInfo.Text = "Product Info";
            this.ProductInfo.UseVisualStyleBackColor = true;
            this.ProductInfo.Click += new System.EventHandler(this.ProductInfo_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 411);
            this.Controls.Add(this.ProductInfo);
            this.Controls.Add(this.AllProducts);
            this.Controls.Add(this.CoffeeProducts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityInStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NbOrder);
            this.Controls.Add(this.AddITem);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RichOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsCb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NbOrder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ItemsCb;
        private Label label1;
        private RichTextBox RichOrder;
        private Label label2;
        private TextBox TextBill;
        private Label label3;
        private Button Order;
        private Button AddITem;
        private NumericUpDown NbOrder;
        private Label label4;
        private TextBox QuantityInStock;
        private Label label5;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem loginFormToolStripMenuItem;
        private TextBox ItemPrice;
        private Label label6;
        private Button CoffeeProducts;
        private Button AllProducts;
        private Button ProductInfo;
    }
}