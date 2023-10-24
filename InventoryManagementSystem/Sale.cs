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
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int QuantitySold { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }

        public Sale(int saleId, int orderId,int productId, int quantitySold, DateTime date, decimal totalAmount)
        {
            SaleID = saleId;
            OrderID = orderId;
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

        public static List<Sale> ViewSales(List<Sale> sales)
        {
            // This method could be enhanced to filter sales based on dates, products, etc.
            return sales;
        }
    }
}
