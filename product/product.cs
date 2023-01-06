namespace Coffee_shop.product
{
    enum categories
    {
        coffee,
        food,
        appetizers,
        MainPlatter,
        milkshakes,

    }

    public abstract class BaseClass
    {
        public abstract void Print(bool user);

        public abstract void PrintToFile(string path);
    }

    public class Product : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public List<string> Categories { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public Product(string name, string description, double price, int quantityInStock, List<string> categories, Dictionary<string, string> v)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Categories = categories;
            Attributes = v;
        }
        public Product()
        {
        }
        public override void PrintToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("Name: " + Name);
                writer.WriteLine("Description: " + Description);
                writer.WriteLine("Price: " + Price);
                writer.WriteLine("Quantity in stock: " + QuantityInStock);
                writer.WriteLine("Categories: " + string.Join(", ", Categories));
                writer.WriteLine("Attributes: " + string.Join(", ", Attributes.Select(x => x.Key + "=" + x.Value)));
            }
        }

        public override void Print(bool user)
        {
            var message = "Name: " + Name + Environment.NewLine;
            message += "Description: " + Description + Environment.NewLine;
            if (user)
            {
                message += "Price: " + Price*Program.daher.Benefitrate + Environment.NewLine;
            }
            else
            {
                message += "Price: " + Price  + Environment.NewLine;

            }
            message += "Quantity in stock: " + QuantityInStock + Environment.NewLine;
            message += "Categories: " + string.Join(", ", Categories) + Environment.NewLine;
            message += "Attributes: " + string.Join(", ", Attributes.Select(x => x.Key + "=" + x.Value)) + Environment.NewLine;

            MessageBox.Show(message, "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string ProductInfo()
        {
            var message = "       Name: " + Name + Environment.NewLine;
            message += "        Description: " + Description + Environment.NewLine;
            message += "        Price: " + Price + Environment.NewLine;
            message += "        Quantity in stock: " + QuantityInStock + Environment.NewLine;

            try
            {
                message += "        Categories: " + string.Join(", ", Categories) + Environment.NewLine;
            }
            catch
            {
                message += "      Categories: " + Environment.NewLine;
            }

            message += "        Attributes: " + string.Join(", ", Attributes.Select(x => x.Key + "=" + x.Value)) + Environment.NewLine;
            return message;
        }

        public bool IsProduct()
        {
            if (Name != "" && Price != -1 && QuantityInStock != -1)
            {
                return true;
            }

            return false;
        }
    }
}