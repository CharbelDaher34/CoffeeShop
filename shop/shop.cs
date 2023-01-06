using Coffee_shop.product;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Coffee_shop.shop
{
    public class Shop : List<Product>
    {
        float benefitrate;
        public Shop(float benefitrate) => this.benefitrate = benefitrate;
        public float Benefitrate => benefitrate;
        public void Edit(Product p)
        {
            Product e = this.Where(x => x.Name == p.Name).FirstOrDefault();

            ref Product reference = ref e;
            // Product e = this[IndexOf((Product)this.Where(x => x.Name == p.Name))];
            e.QuantityInStock += p.QuantityInStock;
            e.Price = p.Price;
            e.Description += " " + p.Description;

            try
            {
                foreach (KeyValuePair<string, string> item in p.Attributes)
                    e.Attributes.Add(item.Key, item.Value);
            }
            catch
            {
                e.Attributes = p.Attributes;
            }

            e.Attributes = e.Attributes.GroupBy(x => x.Key).ToDictionary(x => x.Key, x => x.Last().Value);

            foreach (string item in p.Categories)
                e.Categories.Add(item);

            e.Categories = e.Categories.Distinct().ToList();
            // this[IndexOf((Product)this.Where(x => x.Name == p.Name))] = e;
            // this.Single(x => x.Name == p.Name) = e;
            // var element = this.Where(x => x.Name == p.Name).FirstOrDefault();
            // element = e;
            reference = e;
        }

        public new void Add(Product p, bool show)
        {
            string path = "AdminAdd.txt";

            if (Contains(p.Name))
            {
                Edit(p);
                p = this.Where(x => x.Name == p.Name).FirstOrDefault() as Product;

                if (show)
                {
                    MessageBox.Show("The item " + p.Name + " is successfully edited!");
                }

                string StreamMessage = "The item " + p.Name + " is edited by " + Program.User + " at " + Program.datetime + "\n" + p.ProductInfo();
                Helper.StreamWriter(StreamMessage, path);
            }
            else
            {
                base.Add(p);

                if (show)
                {
                    MessageBox.Show("The item " + p.Name + " is successfully added!");
                }

                string StreamMessage = "The item " + p.Name + " is added successfully by " + Program.User + " at " + Program.datetime + "\n" + p.ProductInfo();
                Helper.StreamWriter(StreamMessage, path);
            }
        }

        public new bool Contains(string p)
        {
            var result = this.Any(x => x.Name == p);
            return result;
        }

        public new void Remove(string p, bool show)
        {
            base.Remove((Product)this.Where(x => x.Name == p).FirstOrDefault());

            if (show)
            {
                MessageBox.Show("The item " + p + " is successfully deleted!");
            }
        }

        public void BindToDataGridView2(DataGridView dataGridView)
        {
            // Clear the DataGridView and add the new columns
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Description", "Description");
            dataGridView.Columns.Add("Price", "Price");
            dataGridView.Columns.Add("QuantityInStock", "Quantity In Stock");
            dataGridView.Columns.Add("Categories", "Categories");
            dataGridView.Columns.Add("Attributes", "Attributes");

            // Add the rows to the DataGridView
            foreach (Product product in this)
            {
                dataGridView.Rows
                    .Add(product.Name, product.Description, product.Price, product.QuantityInStock,
                    string.Join(", ", product.Categories), string.Join(", ", product.Attributes.Select(x => x.Key + "=" + x.Value)));
            }

        }

        public bool equal0(Product p)
        {
            if (p.QuantityInStock == 0)
                return true;

            return false;
        }

        public void RemoveOutOfStockProducts(bool show)
        {
            Predicate<Product> p = equal0;

            // Get a list of the out-of-stock products
            var outOfStockProducts = this.FindAll(equal0);

            // Print the names of the out-of-stock products
            string a = "Out-of-stock products:";

            foreach (Product product in outOfStockProducts)
                a += " , " + product.Name;

            if (show)
            {
                MessageBox.Show(a);
            }

            // Remove the out-of-stock products from the Shop
            this.RemoveAll(p);
        }

        public void ReadAllData(string addpath, string deletepath, string orderspath)
        {
            Dictionary<string, string> rr = new Dictionary<string, string>()
{
    {"", ""},

};

            string line;
            Product product = new();
            List<string> names = new();
            List<string> descriptions = new();
            List<string> prices = new();
            List<string> quantities = new();
            List<List<string>> categories = new();
            List<Dictionary<string, string>> attributes = new();
            Dictionary<string, DateTime> dates = new();
            StreamReader streamReader = new StreamReader(addpath);
            // string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.Trim().StartsWith("Name:"))
                {
                    // names.Add(line.Split(": ")[1]);//.Substring("Name: ".Length);
                    product.Name = line.Split(": ")[1];
                }

                if (line.Trim().StartsWith("Description:"))
                {
                    if (line.Split(": ").Count() < 2)
                    {
                        product.Description = "";
                    }
                    else
                    {
                        product.Description = line.Split(": ")[1];

                        // descriptions.Add(line.Split(": ")[1]);
                    }
                }

                if (line.Trim().StartsWith("Price:"))
                {
                    product.Price = Convert.ToDouble(line.Split(": ")[1]);
                    // prices.Add(Convert.ToDouble(line.Split(": ")[1]).ToString());//double.Parse(line.Substring("Price: ".Length));
                }

                if (line.Trim().StartsWith("Quantity in stock:"))
                {
                    product.QuantityInStock = Convert.ToInt32(line.Split(": ")[1]);
                    // quantities.Add(Convert.ToInt32(line.Split(": ")[1]).ToString());//.Substring("Quantity in stock: ".Length));
                }

                if (line.Trim().StartsWith("Categories:"))
                {
                    if (line.Split(": ").Count() < 2)
                    {
                        product.Categories.Add("coffee");
                    }
                    else
                    {
                        product.Categories = line.Split(": ")[1].Split(",").Select(x => x.Trim()).ToList();

                        // categories.Add(line.Split(": ")[1].Split(",").Select(x => x.Trim()).ToList());//line.Substring("Categories: ".Length).Split(',').Select(x => x.Trim()).ToList();
                    }
                }

                if (line.Trim().StartsWith("Attributes:"))
                {
                    if (line.Split(": ")[1] != "")
                    {
                        product.Attributes = line.Split(": ")[1]
                             .Split(',')
                             .Select(x => x.Trim())
                             .ToDictionary(x => x.Split('=')[0], x => x.Split('=')[1]);

                        // attributes.Add(line.Split(": ")[1].Split(',').Select(x => x.Trim()).ToDictionary(x => x.Split('=')[0], x => x.Split('=')[1]));
                    }
                    else
                    {
                        product.Attributes = rr;
                    }

                    if (this.Contains(product.Name))
                    {
                        this.Remove(product.Name, false);
                        this.Add(product, false);
                    }
                    else
                    {
                        this.Add(product, false);
                    }
                }

                if (line.Trim().StartsWith("The item"))
                {
                    Regex regex = new Regex(@"\b(\d{2}:\d{2}:\d{2})\b");
                    Match match = regex.Match(line);
                    product = new();

                    if (match.Success)
                    {
                        string timeString = match.Groups[1].Value;
                        DateTime time = DateTime.ParseExact(timeString, "HH:mm:ss", CultureInfo.InvariantCulture);

                        if (dates.ContainsKey(line.Split(" ")[2]))
                        {
                            dates[line.Split(" ")[2]] = time;
                        }
                        else
                        {
                            dates.Add(line.Split(" ")[2], time);
                        }
                    }
                }
            }

            var productLists = (names, descriptions, prices, quantities, categories, attributes);

            // for (int i = 0; i < productLists.Item1.Count; i++)
            // {
            //    var product = new Product();
            //    product.Name = productLists.Item1[i];
            //        product.Description = productLists.Item2[i].ToString();
            //    product.Price = Convert.ToDouble(productLists.Item3[i]);
            //    product.QuantityInStock = Convert.ToInt32(productLists.Item4[i]);
            //        product.Categories = productLists.Item5[i];
            //        product.Attributes = productLists.Item6[i];
            //    Program.daher.Add(product);
            // }
            // for (int i = 0; i < productLists.Item1.Count; i++)
            // {
            //    var product = new Product();
            //    product.Name = productLists.Item1[i];

            // if(productLists.Item2[i].ToString()=="")
            //    {
            //        product.Description = "";
            //    }
            //    else
            //    {
            //        product.Description = productLists.Item2[i].ToString();

            //    }

            //    product.Price = Convert.ToDouble(productLists.Item3[i]);
            //    product.QuantityInStock = Convert.ToInt32(productLists.Item4[i]);
            //    if (productLists.Item5[i].Count == 0)
            //    {
            //        product.Categories = new List<string> { };
            //    }
            //    else
            //    {
            //        product.Categories = productLists.Item5[i];

            //    }

            //    if (productLists.Item6.Count==0)
            //    {
            //        product.Attributes = productLists.Item6[i];
            //    }
            //    else
            //    {
            //        product.Attributes = new Dictionary<string, string> {};
            //    }

            //    Program.daher.Add(product);
            // }

            streamReader.Close();

            streamReader = new StreamReader(deletepath);

            // string line;
            Dictionary<string, DateTime> Deletedates = new();

            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();

                if (line.Trim().StartsWith("The item"))
                {
                    Regex regex = new Regex(@"\b(\d{2}:\d{2}:\d{2})\b");
                    Match match = regex.Match(line);

                    if (match.Success)
                    {
                        string timeString = match.Groups[1].Value;
                        DateTime time = DateTime.ParseExact(timeString, "HH:mm:ss", CultureInfo.InvariantCulture);

                        if (Deletedates.ContainsKey(line.Split(" ")[2]))
                        {
                            Deletedates[line.Split(" ")[2]] = time;
                        }
                        else
                        {
                            Deletedates.Add(line.Split(" ")[2], time);
                        }
                    }
                }
            }

            streamReader.Close();

            foreach (var x in Deletedates)
            {
                if (dates.ContainsKey(x.Key))
                {
                    Dictionary<string, DateTime> tmp;
                    var tmp1 = dates[x.Key];

                    if (x.Value > tmp1)
                    {
                        this.Remove(x.Key, false);
                    }
                }
            }

            DateTime ordertime = Convert.ToDateTime(Program.datetime);
            streamReader = new StreamReader(orderspath);
            List<Tuple<string, DateTime, int>> orders = new();

            string name;
            int qty;

            while (!streamReader.EndOfStream)
            {
                line = streamReader.ReadLine();
                line = line.Trim();

                if (line.StartsWith("At"))
                {
                    ordertime = DateTime.ParseExact(line.Split(" ")[1], "HH:mm:ss", CultureInfo.InvariantCulture);
                }

                if (line.StartsWith("The new quantity"))
                {
                    name = line.Split("of:")[1].Split(" ")[0];
                    qty = Convert.ToInt32(line.Split("is:")[1].Split(" ")[0]);
                    Tuple<string, DateTime, int> tmp = new Tuple<string, DateTime, int>(name, ordertime, qty);
                    orders.Add(tmp);
                }
            }

            foreach (var x in orders)
            {
                if (this.Contains(x.Item1))
                {
                    if (dates[x.Item1] < x.Item2)
                    {
                        this.Where(t => t.Name == x.Item1).FirstOrDefault().QuantityInStock = x.Item3;
                    }
                }
            }

            this.RemoveOutOfStockProducts(false);

        }

       
    }
}