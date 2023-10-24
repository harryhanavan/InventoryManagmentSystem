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
    public partial class SupplierView : UserControl
    {
        public SupplierView()
        {
            InitializeComponent();
            LoadSuppliersIntoDataGridView();
        }
        private void SuppliersView_Load(object sender, EventArgs e)
        {
            LoadSuppliersIntoDataGridView();
        }
        private void LoadSuppliersIntoDataGridView()
        {
            try
            {
                // Clear existing rows
                dataGridViewSuppliers.Rows.Clear();

                // Load suppliers from the Supplier class method
                List<Supplier> suppliers = Supplier.LoadSuppliers();
                dataGridViewSuppliers.DataSource = suppliers;

            }
            catch (Exception ex)
            {
                // Handle errors such as file not found or issues with reading data
                MessageBox.Show("An error occurred while loading suppliers: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the search term from the text box
                string searchTerm = textBox1.Text.Trim().ToLower();

                // Load all suppliers
                List<Supplier> suppliers = Supplier.LoadSuppliers();

                // If a search term is entered, filter the suppliers based on the search term
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    suppliers = suppliers
                        .Where(s => s.Name.ToLower().Contains(searchTerm) ||
                                    s.EmailAddress.ToLower().Contains(searchTerm) ||
                                    s.PhoneNumber.ToLower().Contains(searchTerm) ||
                                    s.Category.ToLower().Contains(searchTerm) ||
                                    s.Address.ToLower().Contains(searchTerm) ||
                                    s.City.ToLower().Contains(searchTerm))
                        .ToList();
                }

                // Bind the filtered suppliers to the DataGridView
                dataGridViewSuppliers.DataSource = null;
                dataGridViewSuppliers.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                // Handle errors and display an error message
                MessageBox.Show("An error occurred while searching suppliers: " + ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            mainForm.LoadUserControl(supplierManagementForm);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the existing rows in the DataGridView
                dataGridViewSuppliers.Rows.Clear();

                // Load suppliers from the Supplier class method
                List<Supplier> suppliers = Supplier.LoadSuppliers();

                // Bind the suppliers to the DataGridView
                dataGridViewSuppliers.DataSource = null; // Clear previous binding
                dataGridViewSuppliers.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                // Handle errors and display an error message
                MessageBox.Show("An error occurred while refreshing suppliers: " + ex.Message);
            }
        }

    }
}