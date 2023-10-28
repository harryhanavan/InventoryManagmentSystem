using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Sale
    {
        public int SaleID { get; private set; }
        public DateTime Date { get; set; }
        public List<SaleItem> SaleItems { get; set; }
        public string CustomerDetails { get; set; }
        public decimal TotalAmount { get; set; }

        private static string dataDirectory = "../../../Data/";
        private static string salesFilePath = Path.Combine(dataDirectory, "sales.csv");
        private static string saleItemsFilePath = Path.Combine(dataDirectory, "saleItems.csv");
        public Sale(string customerDetails)
        {
            SaleID = GenerateNewSaleID();
            Date = DateTime.Now;
            SaleItems = new List<SaleItem>();
            CustomerDetails = customerDetails;
            TotalAmount = 0;
        }
        public Sale(int saleID, DateTime date, string customerDetails, List<SaleItem> saleItems, decimal totalAmount)
        {
            SaleID = saleID;
            Date = date;
            SaleItems = saleItems;
            CustomerDetails = customerDetails;
            TotalAmount = totalAmount;
        }

        public void AddSaleItem(SaleItem item)
        {
            SaleItems.Add(item);
        }
        public static bool RecordSale(Sale sale, List<Sale> sales)
        {
            try
            {
                sales.Add(sale);
                FileManager.WriteDataSale(salesFilePath, sales);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the sale: {ex.Message}");
                return false;
            }
        }
        public static bool RecordSaleItem(SaleItem saleItem, List<SaleItem> saleItems)
        {
            try
            {
                Product.UpdateQuantity(saleItem.ProductID, saleItem.Quantity);
                FileManager.WriteDataSaleItem(saleItemsFilePath, saleItems);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the sale: {ex.Message}");
                return false;
            }
        }


        public Sale CreateSale(string customerDetails)
        {
            Sale sale = new Sale(customerDetails);
            return sale;
        }
        public static int GenerateNewSaleID()
        {
            int highestSaleID = 0;
            try
            {
                // Read the sales data from the CSV file
                List<Sale> sales = LoadSales();
                // Identify the highest SaleID
                foreach (var sale in sales)
                {
                    if (sale.SaleID > highestSaleID)
                    {
                        highestSaleID = sale.SaleID;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while generating a new SaleID: {ex.Message}");
            }
            // Return one more than the highest SaleID found, or 1 if no sales are found
            return highestSaleID + 1;
        }
        public static List<Sale> LoadSales()
        {

            List<Sale> sales = new List<Sale>();
            List<string[]> data = FileManager.ReadData(salesFilePath);

            foreach (var record in data.Skip(1)) // Skipping the header
            {
                int saleID = int.Parse(record[0]);
                DateTime saleDate = DateTime.Parse(record[1]);
                List<SaleItem> saleItems = SaleItem.LoadSaleItems(saleID);
                sales.Add(new Sale(
                    saleID: saleID,
                    date: saleDate,
                    customerDetails: record[2],                   
                    saleItems: saleItems,
                    totalAmount: decimal.Parse(record[3])
                ));;
            }

            return sales;
        }
        public override string ToString()
        {
            return $"{SaleID},{Date},{CustomerDetails},{TotalAmount}";
        }
        public static Sale GetSaleById(int saleId)
        {
            try
            {
                // Load all sales
                List<Sale> sales = LoadSales();

                // Find and return the sale that matches the provided SaleID
                return sales.FirstOrDefault(sale => sale.SaleID == saleId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching the sale by ID: {ex.Message}");
                return null; // Returning null if an exception occurred
            }
        }
    }
}
