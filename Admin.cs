using Coffee_shop.product;

namespace Coffee_shop
{
    public partial class Admin : Form
    {
        public Admin() => InitializeComponent();

        void ResetForm()
        {
            Controls.Clear();
            InitializeComponent();
            cb.DataSource = Enum.GetValues(typeof(categories));
        }

        void GroupAdd_Enter(object sender, EventArgs e)
        {
        }

        void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dictionary = RichAtt.Lines.Zip(AttValues.Lines, (key, value) => new { key, value }).ToDictionary(t => t.key, t => t.value);
                var list = rtb.Lines.ToList();

                if (Pdesc.Text.ToString() == "Description")
                {
                    Pdesc.Text = "";
                }

                var p = new Product(Pname.Text.ToString(), Pdesc.Text.ToString(), double.Parse(Pprice.Text.ToString()), int.Parse(Pquantity.Text.ToString()), list, dictionary);
                Program.daher.Add(p, true);
                ResetForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Check the type of inputs");
            }
        }

        void ComboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb.SelectedValueChanged += (sender, e) => rtb.AppendText(cb.SelectedValue.ToString() + "\n");
            var lines = rtb.Lines.Distinct().ToArray();
            rtb.Lines = lines;
        }

        void Admin_Load(object sender, EventArgs e)
        {
            cb.DataSource = Enum.GetValues(typeof(categories));
            IsIn.Checked = Program.daher.Contains(Pname.Text);

        }

        void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        void label1_Click(object sender, EventArgs e)
        {
        }

        void label3_Click(object sender, EventArgs e)
        {
        }

        void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        void RichAtt_TextChanged(object sender, EventArgs e)
        {
            var lines = rtb.Lines.Distinct().ToArray();
            rtb.Lines = lines;

        }

        void AttValues_TextChanged(object sender, EventArgs e)
        {
        }

        void AdminStock_Click(object sender, EventArgs e)
        {
            this.Close();
            var pp = new AllProducts();
            pp.Show();
        }

        void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lo = new LoginForm();
            lo.Show();
            this.Close();
        }

        void AdminDelete_Click(object sender, EventArgs e)
        {
            var name = NameDelete.Text.ToString();

            if (Program.daher.Contains(name))
            {
                var message = "The item " + name + " is deleted by " + Program.User + 
                    " at " + Program.datetime + "\n" 
                    + Program.daher.Where(x => x.Name == name).FirstOrDefault().ProductInfo();
                Helper.StreamWriter(message, "AdminDelete.txt");
                Program.daher.Remove(name, true);
            }
            else
            {
                MessageBox.Show("No item named", name);
            }
        }

        void AdminPrint_Click(object sender, EventArgs e)
        {
            var p = NameDelete.Text.ToString();

            if (Program.daher.Contains(p))
            {
                Program.daher.Where(x => x.Name == p).FirstOrDefault().Print(false);
            }
            else
            {
                MessageBox.Show("No item " + p);
            }
        }

       async void AdminLog_Click(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            MessageBox.Show("Edit or Add:\n" + Helper.StreamReader("AdminAdd.txt"));
            MessageBox.Show("Delete:\n" + Helper.StreamReader("AdminDelete.txt"));
        }

        void Price0() => Pprice.Text = "";

        void Quantity0() => Pquantity.Text = "";

        void Pprice_MouseClick(object sender, MouseEventArgs e) => Price0();

        void Pquantity_MouseClick(object sender, MouseEventArgs e) => Quantity0();

        void Pname_MouseClick(object sender, MouseEventArgs e) => Pname.Text = "";

        async void Orders_Click(object sender, EventArgs e)
        {
            await Task.Delay(10000);
            MessageBox.Show(Helper.StreamReader("UserTransactions.txt"));
            
        }

        private void Pname_TextChanged(object sender, EventArgs e)
        {
            IsIn.Checked = Program.daher.Contains(Pname.Text);
        }

        // this.GroupAdd.Enter += new System.EventHandler(this.GroupAdd_Enter);
    }
}