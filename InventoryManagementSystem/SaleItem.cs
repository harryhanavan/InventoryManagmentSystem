using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class SaleItem
    {
        public int SaleItemID { get; set; }
        public int SaleID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        private static string dataDirectory = "../../../Data/";
        private static string saleItemsFilePath = Path.Combine(dataDirectory, "saleItems.csv");
        public decimal TotalPrice
        {
            get
            {
                return Quantity * PricePerUnit;
            }
        }
        public SaleItem(int saleItemID, int saleID, int productID, int quantity, decimal pricePerUnit)
        {
            SaleItemID = saleItemID;
            SaleID = saleID;
            ProductID = productID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }
        public static void AddProductToSale(Sale sale, Product product, int quantity)
        {            
            int SaleItemID = SaleItem.GenerateNewSaleItemID();
            int SaleID = sale.SaleID;
            int ProductID = product.ProductID;          
            decimal PricePerUnit = product.Price;

            SaleItem saleItem = new SaleItem(SaleItemID, SaleID, ProductID, quantity, PricePerUnit);
            sale.AddSaleItem(saleItem); // Add the sale item to the sale
            Product.UpdateQuantity(quantity, product.ProductID); // Update the product quantity
            List<SaleItem> saleItems = LoadSaleItems();
            saleItems.Add(saleItem);
            FileManager.WriteDataSaleItem(saleItemsFilePath, saleItems);
        }
        public static int GenerateNewSaleItemID()
        {
            // Load sale items and check if the sale items are loaded successfully
            List<SaleItem> saleItems = LoadSaleItems();
            int highestSaleItemID = 0;
            foreach (var saleItem in saleItems)
            {
                if (saleItem.SaleItemID > highestSaleItemID)
                {
                    highestSaleItemID = saleItem.SaleItemID;
                }
            }

            MessageBox.Show($"Final highest SaleItemID: {highestSaleItemID}. Next SaleItemID: {highestSaleItemID + 1}."); // Debugging MessageBox

            return highestSaleItemID + 1;
        }

        public static List<SaleItem> LoadSaleItems()
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            List<string[]> data = FileManager.ReadData(saleItemsFilePath);

            int recordCount = 0;
            int successCount = 0;

            foreach (var record in data.Skip(1))
            {
                recordCount++; // Count each record processed

                try
                {
                    int saleItemID = int.Parse(record[0]);
                    int saleID = int.Parse(record[1]);
                    int productID = int.Parse(record[2]);
                    int quantity = int.Parse(record[3]);
                    decimal pricePerUnit = decimal.Parse(record[4]);

                    SaleItem saleItem = new SaleItem(saleItemID, saleID, productID, quantity, pricePerUnit);
                    saleItems.Add(saleItem);

                    successCount++; // Count each successful SaleItem creation
                }
                catch (FormatException ex)
                {
                    MessageBox.Show($"Format error in record {recordCount}: {string.Join(',', record)}. Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred in record {recordCount}: {string.Join(',', record)}. Error: {ex.Message}");
                }
            }
            // Show final counts
            MessageBox.Show($"Total records processed: {recordCount}. Successful SaleItems created: {successCount}.");
            return saleItems;
        }

        public static List<SaleItem> LoadSaleItems(int saleID)
        {
            List<SaleItem> saleItems = new List<SaleItem>();
            List<string[]> data = FileManager.ReadData(saleItemsFilePath);

            foreach (var record in data.Skip(1))// Skipping the header
            {

                int recordSaleID = int.Parse(record[1]);
                if (recordSaleID == saleID) // Only load items that match the SaleID
                {
                    int saleItemID = int.Parse(record[0]);
                    int productID = int.Parse(record[2]);
                    int quantity = int.Parse(record[3]);
                    decimal pricePerUnit = decimal.Parse(record[4]);

                    SaleItem saleItem = new SaleItem(saleItemID, saleID, productID, quantity, pricePerUnit);
                    saleItems.Add(saleItem);
                }
            }

            return saleItems;        }
        public override string ToString()
        {
            return $"{SaleItemID},{SaleID},{ProductID},{Quantity},{PricePerUnit}";
        }
        public string ListBoxToString()
        {
            Product product = Product.GetProductByID(ProductID);
            int nameWidth = 23;
            int quantityWidth = 10;
            // Formatting each column with consistent width
            string nameColumn = product.Name.PadRight(nameWidth);
            string quantityColumn = Quantity.ToString().PadRight(quantityWidth);
            string priceColumn = PricePerUnit.ToString("C");
            return $"{nameColumn}|{quantityColumn}|{priceColumn}";
        }
    }
}
