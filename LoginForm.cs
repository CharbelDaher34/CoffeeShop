namespace Coffee_shop
{
    public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();
        public delegate void Login();

        void LoginAdmin()
        {
            Hide();
            var ad = new Admin();
            ad.Show();
        }

        void LoginUser()
        {
            Hide();
            var u = new User();
            u.Show();
        }

        List<string> AdminsFN = new List<string> { "Charbel", "Paul" };
        List<string> AdminsLN = new List<string> { "Daher", "Attalah" };
        List<string> Password = new List<string> { "OOP", "Info" };

        void button1_Click(object sender, EventArgs e)
        {
            if (LoginUsername.Text == "Username")
            {
                LoginUsername.Text = "";
                LoginPassword.Text = "";
            }

            var zipped = AdminsFN.Zip(AdminsLN, (s1, s2) => (s1, s2)).Zip(Password, (tuple, s3) => (tuple.s1, tuple.s2, s3));
            Login lo;

            // Loop through the zipped list
            foreach ((string s1, string s2, string s3) in zipped)
            {
                if (s1 == LoginUsername.Text.Split(" ")[0] && s2 == LoginUsername.Text.Split(" ")[1] && s3 == LoginPassword.Text)
                {
                    lo = LoginAdmin;
                    lo();
                    MessageBox.Show("Hello Admin");
                    Program.User = LoginUsername.Text.ToString();

                    return;
                }
            }

            if (LoginUsername.Text != "")
            {
                lo = LoginUser;
                lo();
                MessageBox.Show("You are welcome customer!");
                Program.User = LoginUsername.Text.ToString();

                return;
            }

            MessageBox.Show("Enter your Name!");
        }

        void label1_Click(object sender, EventArgs e)
        {
        }

        void LoginForm_Load(object sender, EventArgs e)
        {
        }

        void LoginBt_KeyPress(object sender, KeyPressEventArgs e) => button1_Click(sender, e);
    }
}