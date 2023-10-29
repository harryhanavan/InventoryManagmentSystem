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
    public partial class SalesAddForm : UserControl
    {
        public SalesAddForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaleAdd_Click(object sender, EventArgs e)
        {
            int productID;
            int quantity;
            string customerDetails = txtCustomerDetails.Text;

            //all fields have values
            if (string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text)
                || string.IsNullOrEmpty(txtCustomerDetails.Text))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            //productID and quantity are integers
            if (!int.TryParse(txtProductID.Text, out productID) || !int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Please make sure the productID and quantity are whole numbers.");
                return;
            }

            //check product exists
            if (!Product.Exists(productID))
            {
                MessageBox.Show("ProductID Not Found.");
                return;
            }

            //add sale to sale file and itemsale file:
            Product product = Product.GetProductByID(productID);
            decimal decQuantity = Convert.ToDecimal(quantity);
            decimal price = product.Price;
            decimal totalAmount = price * decQuantity;
            MessageBox.Show(quantity + " converts to " + decQuantity + " multiplied by " + product.Price + " to equal " + totalAmount);
            

            Sale sale = new Sale(customerDetails, totalAmount);
            SaleItem saleItem = SaleItem.AddProductToSale(sale, product, quantity);
            Sale.AddSale(sale);
            Sale.AddItemSale(saleItem);

            MessageBox.Show("Item added successfully");


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            mainForm.LoadUserControl(salesManagementForm);
        }
    }
}
