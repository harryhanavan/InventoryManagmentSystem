﻿using System;
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
    public partial class ProductAdd : UserControl
    {
        public ProductAdd()
        {
            InitializeComponent();
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategory));

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txtProductID.Text);
            if (Product.Exists(productId)) // Assuming you have an Exists method in your Product class
            {
                MessageBox.Show("A product with this ID already exists. Please enter a unique Product ID.");
                return;
            }
            // Load the current list of products
            List<Product> products = Product.LoadProducts();
            // Get and validate inputs (you might want to add more validation here)
            string name = txtProductName.Text;
            string description = txtProductDescription.Text;

            // Check for Empty Fields
            if (string.IsNullOrWhiteSpace(txtProductID.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtProductDescription.Text) ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtProductQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtProductPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // 2. Validate Numerical Values
            if (!int.TryParse(txtProductID.Text, out productId) ||
                !int.TryParse(txtProductQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtProductPrice.Text, out decimal price) ||
                !int.TryParse(txtSupplierId.Text, out int supplierId))
            {
                MessageBox.Show("Please enter valid numerical values for Product ID, Quantity, Price, and Supplier ID.");
                return;
            }
            // 3. Category Selection
            string category = cmbCategory.SelectedItem.ToString();

            // Create and add the product
            Product newProduct = new Product(productId, name, description, (ProductCategory)Enum.Parse(typeof(ProductCategory), category), price, quantity, supplierId);

            // Add the new product to the list
            bool success = Product.AddProduct(newProduct, products);

            if (success)
                MessageBox.Show("Product added successfully!");
            else
                MessageBox.Show("An error occurred while adding the product.");
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            ProductManagementForm productManagementForm = new ProductManagementForm();
            mainForm.LoadUserControl(productManagementForm);
        }
    }
}
