using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class SaleItem
    {
        public int SaleID { get; set; }
        public int SaleItemID { get; set; }
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
        public SaleItem(int saleID, int saleItemID, int productID, int quantity, decimal pricePerUnit)
        {
            SaleID = saleID;
            SaleItemID = saleItemID;
            ProductID = productID;
            Quantity = quantity;
            PricePerUnit = pricePerUnit;
        }
        public static SaleItem AddProductToSale(Sale sale, Product product, int quantity)
        {            
            int SaleItemID = SaleItem.GenerateNewSaleItemID();
            int SaleID = sale.SaleID;
            int  ProductID = product.ProductID;
            int Quantity = quantity;
            decimal PricePerUnit = product.Price;
            SaleItem saleItem = new SaleItem(SaleID, SaleItemID, ProductID, Quantity, PricePerUnit);
            sale.AddSaleItem(saleItem); // Add the sale item to the sale
            Product.UpdateQuantity(quantity, product.ProductID);

            return saleItem;// Update the product quantity
        }
        private static int GenerateNewSaleItemID()
        {
            List<SaleItem> saleItems = LoadSaleItems();
            int highestSaleItemID = 0;

            foreach (var saleItem in saleItems)
            {
                if (saleItem.SaleItemID > highestSaleItemID)
                {
                    highestSaleItemID = saleItem.SaleItemID;
                }
            }

            return highestSaleItemID + 1;
        }
        public static List<SaleItem> LoadSaleItems() {
            List<SaleItem> saleItems = new List<SaleItem>();
            List<string[]> data = FileManager.ReadData(saleItemsFilePath);
            foreach (var record in data.Skip(1))
            {
                int saleItemID = int.Parse(record[0]);
                int saleID = int.Parse(record[1]);
                int productID = int.Parse(record[2]);
                int quantity = int.Parse(record[3]);
                decimal pricePerUnit = decimal.Parse(record[4]);
                SaleItem saleItem = new SaleItem(saleID, saleItemID, productID, quantity, pricePerUnit);
                saleItems.Add(saleItem);
            }
            return saleItems;
            
        }

        public string[] ToCSV()
        {
            return new string[]
            {
                 SaleID.ToString(),
                 SaleItemID.ToString(),
                 ProductID.ToString(),
                 Quantity.ToString(),
                 PricePerUnit.ToString(),
            };
        }
    }
}
