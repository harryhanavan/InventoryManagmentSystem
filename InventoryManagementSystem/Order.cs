using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Order
    {
        public int OrderID { get; private set; }
        public int SupplierID { get; private set; }
        public int ProductID { get; set; }
        public int QuantityBought { get; set; }
        public DateTime Date { get; set; }

        private static string dataDirectory = "../../../Data/";
        private static string ordersFilePath = Path.Combine(dataDirectory, "orders.csv");

        public Order(int orderId, int supplierId, int productId, int quantityBought, DateTime date)
        {
            OrderID = orderId;
            SupplierID = supplierId;
            ProductID = productId;
            QuantityBought = quantityBought;
            Date = date;
        }

        public static bool RecordOrder(Order order, List<Order> orders)
        {
            try
            {
                orders.Add(order);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while recording the order: {ex.Message}");
                return false;
            }
        }

        public static List<Order> loadOrders(List<Order> orders)
        {
            List<Order> ordersList = new List<Order>();
            List<string[]> data = FileManager.ReadData(ordersFilePatb);

            foreach (var record in data.Skip(1))
            {
                ordersList.Add(new Order(
                    orderId: int.Parse(record[0]),
                    supplierId: int.Parse(record[1]),
                    productId: int.Parse(record[2]),
                    quantityBought: int.Parse(record[3]),
                    date: DateTime.Parse(record[4])
                ));
            }

            return ordersList;
        }
    }
}
