using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSystem
{
    public partial class ProductAdd : Form
    {
        public ProductAdd()
        {
            InitializeComponent();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Load the current list of products
            List<Product> products = Product.LoadProducts();

            // Get and validate inputs (you might want to add more validation here)
            int productId = int.Parse(txtProductID.Text); // Make sure this is a numeric value
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;

            // Assuming category is selected from a ComboBox
            string category = comboBox1.SelectedItem.ToString();

            int quantity;
            decimal price;
            int supplierId;

            if (!int.TryParse(txtProductQuantity.Text, out quantity) || !decimal.TryParse(txtProductPrice.Text, out price) || !int.TryParse(txtSupplierId.Text, out supplierId))
            {
                MessageBox.Show("Please enter valid numbers for quantity, price, and supplier ID.");
                return;
            }

            // Create and add the product
            Product newProduct = new Product(productId, name, description, (ProductCategory)Enum.Parse(typeof(ProductCategory), category), quantity, price, supplierId);

            // Add the new product to the list
            bool success = Product.AddProduct(newProduct, products);

            if (success)
                MessageBox.Show("Product added successfully!");
            else
                MessageBox.Show("An error occurred while adding the product.");
        }
    }
}
