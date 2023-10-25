using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public enum ProductCategory
    {
        Laptop,
        Smartphone,
        Tablet,
        Accessories,
        Audio,
        Wearables
        // Add more categories as needed
    }
    internal class Product
    {
        public int ProductID { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SupplierID { get; set; }

        private static string dataDirectory = "../../../Data/";
        private static string productsFilePath = Path.Combine(dataDirectory, "products.csv");

        public Product(int productId, string name, string description, ProductCategory category,
                       decimal price,int quantity, int supplierId)
        {
            ProductID = productId;
            Name = name;
            Description = description;
            Category = category;
            Quantity = quantity;
            Price = price;
            SupplierID = supplierId;
        }
        public static bool AddProduct(Product product, List<Product> products)
        {
            try
            {
                products.Add(product);

                FileManager.WriteDataProduct(productsFilePath, products); // Save changes to CSV

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the product: {ex.Message}");
                return false;
            }
        }
        public static bool EditProduct(int productId, string newName, string newDescription,
                       ProductCategory newCategory,decimal newPrice, int newQuantity,
                       int newSupplierId, List<Product> products)
        {
            try
            {
                Product product = products.Find(p => p.ProductID == productId);
                if (product != null)
                {
                    product.Name = newName;
                    product.Description = newDescription;
                    product.Category = newCategory;
                    product.Quantity = newQuantity;
                    product.Price = newPrice;
                    product.SupplierID = newSupplierId;

                    FileManager.WriteDataProduct(productsFilePath, products); // Save changes to CSV

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while editing the product: {ex.Message}");
                return false;
            }
        }

        public static bool DeleteProduct(int productId, List<Product> products)
        {
            try
            {
                Product product = products.Find(p => p.ProductID == productId);
                if (product != null)
                {
                    products.Remove(product);


                    FileManager.WriteDataProduct(productsFilePath, products); // Save changes to CSV

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the product: {ex.Message}");
                return false;
            }
        }
        

        public static List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            List<string[]> data = FileManager.ReadData(productsFilePath);

            foreach (var record in data.Skip(1)) // Skipping the header
            {
                products.Add(new Product(
                    productId: int.Parse(record[0]),
                    name: record[1],
                    description: record[2],
                    category: (ProductCategory)Enum.Parse(typeof(ProductCategory), record[3]),
                    price: decimal.Parse(record[4]),
                    quantity: int.Parse(record[5]),
                    supplierId: int.Parse(record[6])
                ));
            }

            return products;
        }
        public override string ToString()
        {
            return $"{ProductID} - {Name}";
        }
        public static bool Exists(int id)
        {
            List<Product> products = LoadProducts();
            return products.Any(p => p.ProductID == id);
        }
        public string[] ToCSV()
        {
            return new string[]
            {
                 ProductID.ToString(),
                 Name,
                 Description,
                 Category.ToString(),
                 Price.ToString(),
                 Quantity.ToString(),
                 SupplierID.ToString()
            };
        }
    }
}
