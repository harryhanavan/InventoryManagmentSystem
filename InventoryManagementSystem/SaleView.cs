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
    public partial class SaleView : UserControl
    {
        public SaleView()
        {
            InitializeComponent();
            this.Load += SaleView_Load; // Ensure the Load event is correctly wired up

        }

        private void SaleView_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewColumns();
            LoadSales();
            listBoxSaleItems.Font = new Font("Courier New", 9);

        }
        private void InitializeDataGridViewColumns()
        {
            dataGridViewSales.Columns.Add("SaleID", "Sale ID");
            dataGridViewSales.Columns.Add("Date", "Date");
            dataGridViewSales.Columns.Add("CustomerDetails", "Customer Details");
            dataGridViewSales.Columns.Add("TotalAmount", "Total Amount");
        }
        private void LoadSales(string searchText = "")
        {
            dataGridViewSales.Rows.Clear();
            List<Sale> sales = Sale.LoadSales();

            foreach (var sale in sales)
            {
                if (string.IsNullOrEmpty(searchText) || sale.CustomerDetails.Contains(searchText))
                {
                    dataGridViewSales.Rows.Add(sale.SaleID, sale.Date, sale.CustomerDetails, sale.TotalAmount);
                }
            }
        }
        private void dataGridViewSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Check if a valid row is clicked
                {
                    int selectedSaleID = (int)dataGridViewSales.Rows[e.RowIndex].Cells[0].Value;
                    Sale selectedSale = Sale.GetSaleById(selectedSaleID);
                    if (selectedSale != null) // Check if a sale is found
                    {
                        listBoxSaleItems.Items.Clear();
                        listBoxSaleItems.Items.Add("Product Name           |Quantity  |Price");
                        foreach (var saleItem in selectedSale.SaleItems)
                        {
                            listBoxSaleItems.Items.Add(saleItem.ListBoxToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sale not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the sale items: {ex.Message}");
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadSales(searchTextBox.Text);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSales(searchTextBox.Text);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = ""; // Clearing the search text box
            LoadSales(); // Loading all sales
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            mainForm.LoadUserControl(salesManagementForm);
        }

    }
}
