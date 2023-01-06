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
            sortbut.Click += new EventHandler(sortt);
            sortbut.Click += new EventHandler(sortbut_Click);
        }
 
        
        void button1_Click(object sender, EventArgs e)
        {
            // bu(sender, e);
        }

        void toolStripMenuItem2_Click(object sender, EventArgs e) => this.Close();
        public  void sortt(object sender, EventArgs e)
        {
            var comparer = new ProductQuantityComparer();

            Program.daher.Sort(comparer);
        }
        public class ProductQuantityComparer : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
 
                if (x.QuantityInStock == y.QuantityInStock)
                    return 0;
                else if (x.QuantityInStock < y.QuantityInStock)
                    return -1;
                else
                    return 1;
            }
        }


        private void sortbut_Click(object sender, EventArgs e)
        {
            //sortt();
            Program.daher.BindToDataGridView2(dataGridView1);
            

        }
 

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shop a = new(2);
            a.AddRange(Program.daher.FindAll(x => x.Price < 10));
            a.BindToDataGridView2(dataGridView1);
        }

        private void All_Click(object sender, EventArgs e)
        {
            Program.daher.BindToDataGridView2(dataGridView1);
        }

        private void sortbut_Click_1(object sender, EventArgs e)
        {

        }


    }

}