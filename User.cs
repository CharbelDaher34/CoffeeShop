using Coffee_shop.product;
using FakeItEasy;
using System.Collections.Generic;

namespace Coffee_shop
{
    public partial class User : Form
    {
        public User() => InitializeComponent();

        void label1_Click(object sender, EventArgs e)
        {
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = ItemsCb.Text.ToString();
            ItemPrice.Text = (Program.daher.Find(x => x.Name == selectedValue).Price*Program.daher.Benefitrate).ToString();
            int qty = Program.daher.Find(x => x.Name == selectedValue).QuantityInStock;
            QuantityInStock.Text = qty.ToString();
            NbOrder.Maximum = qty;
            // Append the selected value to the RichTextBox
            // ItemsCb.SelectedValueChanged += (sender, e) => RichOrder.AppendText(ItemsCb.SelectedValue.ToString() + "\n");
            // var lines = RichOrder.Lines.Distinct().ToArray();
            // RichOrder.Lines = lines;
        }

        void button1_Click(object sender, EventArgs e) => MessageBox.Show("");

        void Order_Click(object sender, EventArgs e)
        {
            string message = "At " + Program.datetime + " ," + Program.User + " has bought";

            foreach (string a in RichOrder.Lines)
            {
                if (a != "")
                {
                    string[] sf = a.ToString().Split(' ');

                    string name = sf[0];
                    string q = sf[1];
                    int qty = Convert.ToInt32(q);
                    // message += "\n    " + qty.ToString() + " of " + name;
                    Program.daher.Find(x => x.Name == name).QuantityInStock -= Convert.ToInt32(qty);
                    message += "\n    " + "The new quantity available of:" + name + " is:" + Program.daher.Find(x => x.Name == name).QuantityInStock.ToString() + " (taken:" + q + ")\n";
                    // message += "\n    " + "The new qty available is:" + Program.daher.Find(x => x.Name == name).QuantityInStock.ToString();
                }
            }

            Program.daher.RemoveOutOfStockProducts(false);
            Helper.StreamWriter(message, "UserTransactions.txt");
            ItemsCb.Items.Clear();

            // foreach (Product product in Program.daher)
            //    ItemsCb.Items.Add(product.Name);

            ResetForm();
        }

        void ResetForm()
        {
            Controls.Clear();
            InitializeComponent();

            foreach (Product product in Program.daher)
                ItemsCb.Items.Add(product.Name);
        }

        void User_Load(object sender, EventArgs e)
        {
            ItemsCb.Items.Clear();

            foreach (Product product in Program.daher)
                ItemsCb.Items.Add(product.Name);
        }

        void RichOrder_TextChanged(object sender, EventArgs e)
        {
            var lines = RichOrder.Lines.Distinct().ToArray();
            RichOrder.Lines = lines;
        }

        void AddITem_Click(object sender, EventArgs e)
        {
            double bill = 0;

            if (Convert.ToInt32(NbOrder.Value) <= Convert.ToInt32(QuantityInStock.Text.ToString()))
            {
                RichOrder.AppendText(ItemsCb.Text.ToString() + ' ' + Convert.ToInt32(NbOrder.Value).ToString() + "\n");
                OrderRich();
            }
            else
            {
                MessageBox.Show("There isn't enough in stock!");
            }

            string s = RichOrder.Text;
            ResetForm();
            RichOrder.Text = s;

            foreach (var line in RichOrder.Lines)
            {
                if (line != "")
                {
                    bill += Convert.ToInt32(line.Split(" ")[1]) * Program.daher.Find(x => x.Name == line.Split(" ")[0]).Price * Program.daher.Benefitrate;
                }
            }

            TextBill.Text = bill.ToString();
        }

        void loginFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm f = new();
            f.Show();
        }

        void QuantityInStock_TextChanged(object sender, EventArgs e)
        {
        }

        void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        void OrderRich()
        {
            Dictionary<string, string> namesAndValues = new Dictionary<string, string>();

            foreach (string line in RichOrder.Lines)
            {
                if (line != "")
                {
                    string[] parts = line.Split(' ');
                    string name = parts[0];
                    string value = parts[1];

                    if (namesAndValues.ContainsKey(name))
                    {
                        namesAndValues[name] = value;
                    }
                    else
                    {
                        namesAndValues.Add(name, value);
                    }
                }
            }

            RichOrder.Clear();

            foreach (var nameAndValue in namesAndValues)
            {
                RichOrder.AppendText(nameAndValue.Key + " " + nameAndValue.Value + Environment.NewLine);
            }
        }

        void closeToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void CoffeeProducts_Click(object sender, EventArgs e)
        {
            ItemsCb.Items.Clear();
            List<Product> a = (List<Product>)Program.daher.FindAll(x => x.Categories.Contains("coffee"));
            foreach(var x in a)
            {
                ItemsCb.Items.Add(x.Name);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ItemsCb.Items.Clear();
            foreach (var x in Program.daher)
            {
                ItemsCb.Items.Add(x.Name);
            }
        }

        private void ProductInfo_Click(object sender, EventArgs e)
        {
            if (ItemsCb.Text != "")
            {
                Program.daher.Where(x => x.Name == ItemsCb.Text).FirstOrDefault().Print(true);
            }
            else
            {
                MessageBox.Show("Choose a Product First!");
            }
        }

        private void ItemPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}