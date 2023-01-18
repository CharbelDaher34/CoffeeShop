namespace Coffee_shop
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // LoginUsername
            // 
            this.LoginUsername.Location = new System.Drawing.Point(500, 273);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(152, 23);
            this.LoginUsername.TabIndex = 0;
            this.LoginUsername.Text = "Username";
            this.LoginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Location = new System.Drawing.Point(500, 302);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.Size = new System.Drawing.Size(152, 23);
            this.LoginPassword.TabIndex = 1;
            this.LoginPassword.Text = "Password";
            this.LoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginPassword.TextChanged += new System.EventHandler(this.LoginPassword_TextChanged);
            // 
            // LoginBt
            // 
            this.LoginBt.Location = new System.Drawing.Point(500, 331);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(75, 23);
            this.LoginBt.TabIndex = 2;
            this.LoginBt.Text = "Log In";
            this.LoginBt.UseVisualStyleBackColor = true;
            this.LoginBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password is necessary if you are an admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 139);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(196, 90);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Admin\nUsername: Charbel Daher\nPassword: OOP\n \nUser: Any username no password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Coffee_shop.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBt);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.LoginUsername);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LoginBt;
        private Label label1;
        public TextBox LoginUsername;
        public TextBox LoginPassword;
        private RichTextBox richTextBox1;
    }
}