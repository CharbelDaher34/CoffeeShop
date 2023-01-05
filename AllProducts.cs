using Coffee_shop.product;
using Coffee_shop.shop;

namespace Coffee_shop
{
    public partial class AllProducts : Form
    {
        public AllProducts() => InitializeComponent();

        void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Hide();
            var a = new Admin();
            a.Show();
        }

        void LoginForm_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm a = new();
            a.Show();
        }

        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        void AllProducts_Load_1(object sender, EventArgs e)
        {
            Program.daher.BindToDataGridView2(dataGridView1);
        }
 
        // private void bu(object sender, EventArgs e)
        // {
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        // Get the values of the cells
        //        string name = (string)row.Cells["Name"].Value;
        //        string description = (string)row.Cells["Description"].Value;
        //        double price = Convert.ToDouble(row.Cells["Price"].Value);
        //        int quantity = Convert.ToInt32(row.Cells["QuantityInStock"].Value);
        //        List<string> cat = new();
        //        Dictionary<string, string> att = new();
        //        int tmp = 0;
        //        int tmp1 = 0;
        //        try
        //        {
        //            cat = (List<string>)row.Cells["Categories"].Value.ToString().Split(',').ToList();
        //            tmp = 1;
        //        }
        //        catch (Exception)
        //        {
        //            if(tmp==0)
        //            {
        //                cat = null;
        //            }
        //        }
        //        try
        //        {

        //            string[] keyValuePairs = row.Cells["Attributes"].Value.ToString().Split(',');

        //            // Create a dictionary to store the key-value pairs
        //            Dictionary<string, string> dictionary = new Dictionary<string, string>();

        //            // Iterate through the key-value pairs and split each pair by "="
        //            foreach (string pair in keyValuePairs)
        //            {
        //                string[] keyValue = pair.Split('=');
        //                string key = keyValue[0];
        //                string value = keyValue[1];

        //                // Add the key and value to the dictionary
        //                dictionary.Add(key, value);
        //            }
        //            att = dictionary;
        //            tmp1 = 1;
        //        }
        //        catch(Exception)
        //        {
        //            if(tmp1==0)
        //            {
        //                att = null;
        //            }

        //        }

        //            // Create a new Product object using the values obtained from the cells
        //            Product product = new Product(name, description, price, quantity, cat, att);

        //            // Add the new Product object to the Shop
        //            Program.daher.Add(product);
        //        }
        //    }
        void button1_Click(object sender, EventArgs e)
        {
            // bu(sender, e);
        }

        void toolStripMenuItem2_Click(object sender, EventArgs e) => this.Close();
             public  void sortt()
        {
            var comparer = new ProductQuantityComparer();

            Program.daher.Sort(comparer);
        }
        public class ProductQuantityComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                // Compare the quantity in stock of the two products
                int result = x.QuantityInStock.CompareTo(y.QuantityInStock);

                // If the quantity in stock is equal, compare the names of the products
                if (result == 0)
                {
                    result = x.Name.CompareTo(y.Name);
                }

                return result;
            }
        }

        private void sortbut_Click(object sender, EventArgs e)
        {
            sortt();
            Program.daher.BindToDataGridView2(dataGridView1);

        }
 

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shop a = new(2);
            a.AddRange(Program.daher.FindAll(x => x.Price < 10));
            a.BindToDataGridView2(dataGridView1);
        }
    }

}