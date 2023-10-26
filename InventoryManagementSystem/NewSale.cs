using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class NewSale : UserControl
    {
        public NewSale()
        {
            InitializeComponent();
        }
        public void ExecuteSale(string customerDetails, List<Product> products, List<int> quantities)
        {
            Sale sale = new Sale(customerDetails); // Create a new sale

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                int quantity = quantities[i];

                SaleItem.AddProductToSale(sale, product, quantity); // Add the product to the sale

            }
        }
    }
}
