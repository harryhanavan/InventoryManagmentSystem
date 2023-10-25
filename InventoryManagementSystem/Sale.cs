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
        public int ProductID { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        private static string dataDirectory = "../../../Data/";
        private static string salesFilePath = Path.Combine(dataDirectory, "sales.csv");

        public Sale(int saleId, int productId, int quantitySold, DateTime date, decimal totalAmount)
        {
            SaleID = saleId;
            ProductID = productId;
            QuantitySold = quantitySold;
            Date = date;
            TotalAmount = totalAmount;
        }

        public static bool RecordSale(Sale sale, List<Sale> sales)
        {
            try
            {
                sales.Add(sale);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the sale: {ex.Message}");
                return false;
            }
        }

        public static List<Sale> loadSales(List<Sale> sales)
        {
            List<Sale> salesList = new List<Sale>();
            List<string[]> data = FileManager.ReadData(salesFilePath);

            foreach (var record in data.Skip(1))
            {
                salesList.Add(new Sale(
                    saleId: int.Parse(record[0]),
                    productId: int.Parse(record[1]),
                    quantitySold: int.Parse(record[2]),
                    date: DateTime.Parse(record[3]),
                    totalAmount: decimal.Parse(record[4])
                ));
            }

            return salesList;
        }
    }
}
