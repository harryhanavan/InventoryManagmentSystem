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
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
            LoadProductsIntoDataGridView();
        }
        private void ProductView_Load(object sender, EventArgs e)
        {
            LoadProductsIntoDataGridView();
        }
        private void LoadProductsIntoDataGridView()
        {
            try
            {
                // Load products from the data source
                List<Product> products = Product.LoadProducts();


                // Bind the products to the DataGridView
                dataGridViewProducts.DataSource = products;

                // Set column headers
                dataGridViewProducts.Columns["ProductID"].HeaderText = "Product ID";
                dataGridViewProducts.Columns["Name"].HeaderText = "Name";
                dataGridViewProducts.Columns["Description"].HeaderText = "Description";
                dataGridViewProducts.Columns["Category"].HeaderText = "Category";
                dataGridViewProducts.Columns["Price"].HeaderText = "Price";
                dataGridViewProducts.Columns["Quantity"].HeaderText = "Quantity";
                dataGridViewProducts.Columns["SupplierID"].HeaderText = "Supplier ID";

                // Format Price column as currency
                dataGridViewProducts.Columns["Price"].DefaultCellStyle.Format = "c";

                // Auto-resize columns
                dataGridViewProducts.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Set DataGridView as read-only
                dataGridViewProducts.ReadOnly = true;
                dataGridViewProducts.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the products: {ex.Message}");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchTerm = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem as string;
            string selectedPriceRange = comboBox1.SelectedItem as string;
            int selectedSupplierID = -1; // Default value
            if (cmbSupplier.SelectedItem != null && int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
            {
                selectedSupplierID = parsedSupplierID;

                Console.WriteLine($"Selected Supplier ID: {selectedSupplierID}"); // Debugging output
            }
            else
            {
                Console.WriteLine("No Supplier ID selected or failed to parse."); // Debugging output
            }


            List<Product> products = Product.LoadProducts();

            var filteredProducts = products
                .Where(p => string.IsNullOrEmpty(searchTerm) || p.ProductID.ToString().Contains(searchTerm) || p.Name.ToLower().Contains(searchTerm))
                .Where(p => string.IsNullOrEmpty(selectedCategory) || p.Category.ToString() == selectedCategory)
                .Where(p => string.IsNullOrEmpty(selectedPriceRange) || PriceInRange(p.Price, selectedPriceRange))
                .Where(p => cmbSupplier.SelectedItem == null || (p.SupplierID == selectedSupplierID))
                .ToList();

            dataGridViewProducts.DataSource = filteredProducts;
            // Refresh the DataGridView to reflect changes
            dataGridViewProducts.Refresh();
        
    }

        // You can create a method to handle the price range filtering
        private bool PriceInRange(decimal price, string selectedPriceRange)
        {
            switch (selectedPriceRange)
            {
                case "Below $50":
                    return price < 50;
                case "$50 - $100":
                    return price >= 50 && price < 100;
                case "$100 - $150":
                    return price >= 100 && price < 150;
                case "$150-$300":
                    return price >= 150 && price < 300;
                case "$300+":
                    return price >= 300;
                default:
                    return true; // If no range is selected or if the range is not recognized, ignore the price filter
            }
        }



    }
}