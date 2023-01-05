namespace Coffee_shop
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.GroupAdd = new System.Windows.Forms.GroupBox();
            this.IsIn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttValues = new System.Windows.Forms.RichTextBox();
            this.RichAtt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pquantity = new System.Windows.Forms.TextBox();
            this.Pprice = new System.Windows.Forms.TextBox();
            this.Pdesc = new System.Windows.Forms.TextBox();
            this.Pname = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdminAdd = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.AdminLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdminPrint = new System.Windows.Forms.Button();
            this.AdminDelete = new System.Windows.Forms.Button();
            this.NameDelete = new System.Windows.Forms.TextBox();
            this.AdminStock = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Orders = new System.Windows.Forms.Button();
            this.GroupAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupAdd
            // 
            this.GroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupAdd.Controls.Add(this.IsIn);
            this.GroupAdd.Controls.Add(this.label3);
            this.GroupAdd.Controls.Add(this.AttValues);
            this.GroupAdd.Controls.Add(this.RichAtt);
            this.GroupAdd.Controls.Add(this.label2);
            this.GroupAdd.Controls.Add(this.label1);
            this.GroupAdd.Controls.Add(this.Pquantity);
            this.GroupAdd.Controls.Add(this.Pprice);
            this.GroupAdd.Controls.Add(this.Pdesc);
            this.GroupAdd.Controls.Add(this.Pname);
            this.GroupAdd.Controls.Add(this.cb);
            this.GroupAdd.Controls.Add(this.AdminAdd);
            this.GroupAdd.Controls.Add(this.rtb);
            this.GroupAdd.Location = new System.Drawing.Point(148, 21);
            this.GroupAdd.Name = "GroupAdd";
            this.GroupAdd.Size = new System.Drawing.Size(377, 308);
            this.GroupAdd.TabIndex = 0;
            this.GroupAdd.TabStop = false;
            this.GroupAdd.Text = "Add product";
            this.GroupAdd.Enter += new System.EventHandler(this.GroupAdd_Enter);
            // 
            // IsIn
            // 
            this.IsIn.AutoSize = true;
            this.IsIn.Location = new System.Drawing.Point(9, 141);
            this.IsIn.Name = "IsIn";
            this.IsIn.Size = new System.Drawing.Size(50, 19);
            this.IsIn.TabIndex = 6;
            this.IsIn.Text = "Exist";
            this.IsIn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Values";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AttValues
            // 
            this.AttValues.Location = new System.Drawing.Point(254, 54);
            this.AttValues.Name = "AttValues";
            this.AttValues.Size = new System.Drawing.Size(100, 96);
            this.AttValues.TabIndex = 10;
            this.AttValues.Text = "";
            this.AttValues.TextChanged += new System.EventHandler(this.AttValues_TextChanged);
            // 
            // RichAtt
            // 
            this.RichAtt.Location = new System.Drawing.Point(143, 54);
            this.RichAtt.Name = "RichAtt";
            this.RichAtt.Size = new System.Drawing.Size(100, 96);
            this.RichAtt.TabIndex = 9;
            this.RichAtt.Text = "";
            this.RichAtt.TextChanged += new System.EventHandler(this.RichAtt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Attributes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pquantity
            // 
            this.Pquantity.Location = new System.Drawing.Point(9, 112);
            this.Pquantity.Name = "Pquantity";
            this.Pquantity.Size = new System.Drawing.Size(100, 23);
            this.Pquantity.TabIndex = 5;
            this.Pquantity.Text = "Quantity in stock";
            this.Pquantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pquantity_MouseClick);
            // 
            // Pprice
            // 
            this.Pprice.Location = new System.Drawing.Point(9, 83);
            this.Pprice.Name = "Pprice";
            this.Pprice.Size = new System.Drawing.Size(100, 23);
            this.Pprice.TabIndex = 1;
            this.Pprice.Text = "Price";
            this.Pprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pprice_MouseClick);
            // 
            // Pdesc
            // 
            this.Pdesc.Location = new System.Drawing.Point(9, 54);
            this.Pdesc.Name = "Pdesc";
            this.Pdesc.Size = new System.Drawing.Size(100, 23);
            this.Pdesc.TabIndex = 4;
            this.Pdesc.Text = "Description";
            this.Pdesc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(9, 25);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(100, 23);
            this.Pname.TabIndex = 3;
            this.Pname.Text = "Name";
            this.Pname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pname_MouseClick);
            this.Pname.TextChanged += new System.EventHandler(this.Pname_TextChanged);
            // 
            // cb
            // 
            this.cb.DataSource = this.productBindingSource;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(194, 184);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(100, 23);
            this.cb.TabIndex = 2;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.ComboCategories_SelectedIndexChanged);
            // 
            // AdminAdd
            // 
            this.AdminAdd.Location = new System.Drawing.Point(17, 272);
            this.AdminAdd.Name = "AdminAdd";
            this.AdminAdd.Size = new System.Drawing.Size(75, 30);
            this.AdminAdd.TabIndex = 0;
            this.AdminAdd.Text = "Add";
            this.AdminAdd.UseVisualStyleBackColor = true;
            this.AdminAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(194, 213);
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            this.rtb.Size = new System.Drawing.Size(100, 53);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AdminLog
            // 
            this.AdminLog.Location = new System.Drawing.Point(665, 50);
            this.AdminLog.Name = "AdminLog";
            this.AdminLog.Size = new System.Drawing.Size(105, 23);
            this.AdminLog.TabIndex = 1;
            this.AdminLog.Text = "Admin Log Read";
            this.AdminLog.UseVisualStyleBackColor = true;
            this.AdminLog.Click += new System.EventHandler(this.AdminLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AdminPrint);
            this.groupBox1.Controls.Add(this.AdminDelete);
            this.groupBox1.Controls.Add(this.NameDelete);
            this.groupBox1.Location = new System.Drawing.Point(531, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Product";
            // 
            // AdminPrint
            // 
            this.AdminPrint.Location = new System.Drawing.Point(14, 95);
            this.AdminPrint.Name = "AdminPrint";
            this.AdminPrint.Size = new System.Drawing.Size(75, 23);
            this.AdminPrint.TabIndex = 5;
            this.AdminPrint.Text = "Print";
            this.AdminPrint.UseVisualStyleBackColor = true;
            this.AdminPrint.Click += new System.EventHandler(this.AdminPrint_Click);
            // 
            // AdminDelete
            // 
            this.AdminDelete.Location = new System.Drawing.Point(14, 66);
            this.AdminDelete.Name = "AdminDelete";
            this.AdminDelete.Size = new System.Drawing.Size(75, 23);
            this.AdminDelete.TabIndex = 1;
            this.AdminDelete.Text = "Delete";
            this.AdminDelete.UseVisualStyleBackColor = true;
            this.AdminDelete.Click += new System.EventHandler(this.AdminDelete_Click);
            // 
            // NameDelete
            // 
            this.NameDelete.Location = new System.Drawing.Point(9, 28);
            this.NameDelete.Name = "NameDelete";
            this.NameDelete.Size = new System.Drawing.Size(100, 23);
            this.NameDelete.TabIndex = 0;
            this.NameDelete.Text = "Name";
            // 
            // AdminStock
            // 
            this.AdminStock.Location = new System.Drawing.Point(665, 21);
            this.AdminStock.Name = "AdminStock";
            this.AdminStock.Size = new System.Drawing.Size(86, 23);
            this.AdminStock.TabIndex = 3;
            this.AdminStock.Text = "DisplayStock";
            this.AdminStock.UseVisualStyleBackColor = true;
            this.AdminStock.Click += new System.EventHandler(this.AdminStock_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginFormToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.exitToolStripMenuItem.Text = "Options";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loginFormToolStripMenuItem
            // 
            this.loginFormToolStripMenuItem.Name = "loginFormToolStripMenuItem";
            this.loginFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginFormToolStripMenuItem.Text = "LoginForm";
            this.loginFormToolStripMenuItem.Click += new System.EventHandler(this.loginFormToolStripMenuItem_Click);
            // 
            // Orders
            // 
            this.Orders.Location = new System.Drawing.Point(665, 79);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(75, 23);
            this.Orders.TabIndex = 5;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            this.Orders.Click += new System.EventHandler(this.Orders_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Orders);
            this.Controls.Add(this.AdminStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AdminLog);
            this.Controls.Add(this.GroupAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.GroupAdd.ResumeLayout(false);
            this.GroupAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox GroupAdd;
        private Button AdminAdd;
        private RichTextBox rtb;
        private ComboBox cb;
        private BindingSource productBindingSource;
        private TextBox Pdesc;
        private TextBox Pname;
        private TextBox Pprice;
        private TextBox Pquantity;
        private Button AdminLog;
        private GroupBox groupBox1;
        private Button AdminDelete;
        private TextBox NameDelete;
        private Button AdminStock;
        private Label label1;
        private Label label3;
        private RichTextBox AttValues;
        private RichTextBox RichAtt;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem loginFormToolStripMenuItem;
        private Button AdminPrint;
        private Button Orders;
        private CheckBox IsIn;
    }
}