using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace InventoryManagementSystem
{
    public partial class NewSale : UserControl
    {
        public NewSale()
        {
            InitializeComponent();
        }
        private void NewSale_Load(object sender, EventArgs e)
        {
            List<Product> products = Product.LoadProducts();
            productComboBox.DataSource = products;
            productComboBox.DisplayMember = "Name";
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (productComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            // Ensure that the selected item is a Product object
            if (productComboBox.SelectedItem is Product selectedProduct)
            {
                int quantity;

                // Try parsing the quantity and handle invalid input
                if (!int.TryParse(quantityTextBox.Text, out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid quantity.");
                    return;
                }

                CartItem cartItem = new CartItem(selectedProduct, quantity);
                cartListBox.Items.Add(cartItem);
                cartListBox.Refresh();
            }
            else
            {
                MessageBox.Show("An error occurred. Please select a valid product.");
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string customerDetails = customerDetailsTextBox.Text;
                if (string.IsNullOrWhiteSpace(customerDetails))
                {
                    MessageBox.Show("Please enter customer details.");
                    return;
                }
                Sale sale = new Sale(customerDetails);
                decimal totalAmount = 0; // Variable to store total amount of the sale
                if (cartListBox.Items.Count == 0)
                {
                    MessageBox.Show("Cart is empty.");
                    return;
                }
                foreach (var item in cartListBox.Items)
                {
                    if (item is CartItem cartItem)
                    {
                        if (cartItem.Quantity > cartItem.Product.Quantity)
                        {
                            MessageBox.Show($"Not enough stock for product: {cartItem.Product.Name}"); 
                            return;
                        }
                        SaleItem.AddProductToSale(sale, cartItem.Product, cartItem.Quantity);
                        totalAmount += cartItem.Product.Price * cartItem.Quantity; // Calculating total amount
                    }
                }
                sale.TotalAmount = totalAmount;
                if (Sale.RecordSale(sale, Sale.LoadSales()))
                {
                    MessageBox.Show("Sale recorded successfully.");
                }
                else
                {
                    MessageBox.Show("An error occurred while recording the sale.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while recording the sale: {ex.Message}");
            }
        }
        private void productComboBox_TextUpdate(object sender, EventArgs e)
        {
            productComboBox.DroppedDown = true; // Ensure that the dropdown is visible while typing
            string searchText = productComboBox.Text;
            List<Product> filteredProducts = SearchProducts(searchText);
            productComboBox.DataSource = null;
            productComboBox.DataSource = filteredProducts;
            productComboBox.DisplayMember = "Name";
            productComboBox.Text = searchText;
            productComboBox.SelectionStart = searchText.Length;
        }
        public static List<Product> SearchProducts(string searchText)
        {
            List<Product> allProducts = Product.LoadProducts();
            return allProducts.Where(p => p.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public void ExecuteSale(string customerDetails, List<Product> products, List<int> quantities)
        {
            Sale sale = new Sale(customerDetails); // Create a new sale

            for (int i = 0; i < products.Count; i++)
            {
                int saleItemID = SaleItem.GenerateNewSaleItemID();
                int saleID = sale.SaleID;
                int productID = products[i].ProductID;
                int quantity = quantities[i];
                decimal pricePerUnit = products[i].Price;

                SaleItem saleItem = new SaleItem(saleItemID, saleID, productID, quantity, pricePerUnit);
                sale.SaleItems.Add(saleItem);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            mainForm.LoadUserControl(salesManagementForm);
        }
    }
}
