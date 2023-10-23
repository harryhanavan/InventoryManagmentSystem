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
    public partial class ProductEdit : Form
    {
        public ProductEdit()
        {
            InitializeComponent();
            cmbProducts.SelectedIndexChanged += new EventHandler(productSelected);
            // Populate the category ComboBox
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategory));
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that the necessary fields are not empty
                if (string.IsNullOrEmpty(txtProductID.Text) ||
                    string.IsNullOrEmpty(txtProductName.Text) ||
                    string.IsNullOrEmpty(txtProductPrice.Text) ||
                    string.IsNullOrEmpty(txtProductQuantity.Text) ||
                    string.IsNullOrEmpty(txtSupplierId.Text) ||
                    cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.");
                    return;
                }

                int productId = int.Parse(txtProductID.Text);
                string name = txtProductName.Text;
                string description = txtProductDescription.Text;
                ProductCategory category = (ProductCategory)cmbCategory.SelectedItem;
                decimal price = decimal.Parse(txtProductPrice.Text);
                int quantity = int.Parse(txtProductQuantity.Text);
                int supplierId = int.Parse(txtSupplierId.Text);

                Product.EditProduct(productId, name, description, category, price, quantity, supplierId, Product.LoadProducts());
                MessageBox.Show("Product updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}");
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            List<Product> products = Product.LoadProducts();

            var matchedProducts = products
                .Where(p => p.ProductID.ToString() == searchTerm || p.Name.ToLower().Contains(searchTerm))
                .ToList();
            cmbProducts.DataSource = null; // Clear previous data source
            cmbProducts.DataSource = matchedProducts; // Set new data source
            cmbProducts.DisplayMember = "Name"; // Assuming you want to display the Name of the product in the ComboBox
            cmbProducts.ValueMember = "ProductID"; // Set the hidden value of ComboBox items to ProductID
        }
        private void productSelected(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)cmbProducts.SelectedItem;
            if (selectedProduct != null)
            {
                txtProductID.Text = selectedProduct.ProductID.ToString();
                txtProductName.Text = selectedProduct.Name;
                txtProductDescription.Text = selectedProduct.Description;
                cmbCategory.SelectedItem = selectedProduct.Category;
                txtProductPrice.Text = selectedProduct.Price.ToString();
                txtProductQuantity.Text = selectedProduct.Quantity.ToString();
                txtSupplierId.Text = selectedProduct.SupplierID.ToString();
            }
            else
            {
                // Clearing the textboxes
                txtProductID.Clear();
                txtProductName.Clear();
                txtProductDescription.Clear();
                cmbCategory.SelectedItem = null; // Assuming you want to clear the ComboBox as well
                txtProductPrice.Clear();
                txtProductQuantity.Clear();
                txtSupplierId.Clear();

                // Showing a MessageBox
                MessageBox.Show("No product found with the given name or ID.");
            }
        }



    }
}
