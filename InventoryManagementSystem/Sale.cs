using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public Sale(string customerDetails, decimal totalAmount)
        {
            SaleID = GenerateNewSaleID();
            Date = DateTime.Now;
            SaleItems = SaleItem.LoadSaleItems();
            CustomerDetails = customerDetails;
            TotalAmount = totalAmount;
        }
        public Sale(int saleID, DateTime date, List<SaleItem> saleItems, string customerDetails, decimal totalAmount)
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
        public static bool RecordSale(List<Sale> sales)
        {
            try
            {
                FileManager.WriteDataSale(salesFilePath, sales);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the sale: {ex.Message}");
                return false;
            }
        }
        public static bool RecordSaleItem(List<SaleItem> saleItems)
        {
            try
            {
                FileManager.WriteDataSaleItem(saleItemsFilePath, saleItems);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the sale: {ex.Message}");
                return false;
            }
        }

        public static void AddSale(Sale sale)
        {
            List<Sale> saleList = Sale.LoadSales();
            saleList.Add(sale);
            Sale.RecordSale(saleList);
        }

        public static void AddItemSale(SaleItem item)
        {
            List<SaleItem> saleList = SaleItem.LoadSaleItems();
            saleList.Add(item);
            Sale.RecordSaleItem(saleList);
        }
        private int GenerateNewSaleID()
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
               
                sales.Add(new Sale(
                    saleID: int.Parse(record[0]),
                    date: DateTime.Parse(record[1]),
                    saleItems: SaleItem.LoadSaleItems(),
                    customerDetails: record[2],
                    totalAmount: decimal.Parse(record[3])
                ));
            }

            return sales;
        }

        public string[] ToCSV()
        {
            return new string[]
            {
                 SaleID.ToString(),
                 Date.ToString(),
                 CustomerDetails,
                 TotalAmount.ToString(),
            };
        }

    }
}
