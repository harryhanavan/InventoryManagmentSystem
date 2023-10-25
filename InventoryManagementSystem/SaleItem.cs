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

        public decimal TotalPrice
        {
            get
            {
                return Quantity * PricePerUnit;
            }
        }

        public SaleItem(Product product, int quantity)
        {
            ProductID = product.ProductID;
            Quantity = quantity;
            PricePerUnit = product.Price;
        }
        public void AddProductToSale(Product product, int quantity)
        {
            SaleItemID = // generate a new sale item ID
            SaleID = // the ID of the current sale
            ProductID = product.ProductID;
            Quantity = quantity;
            PricePerUnit = product.Price;
        }
    }
}
