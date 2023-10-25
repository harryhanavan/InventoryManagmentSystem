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
    public partial class SupplierAdd : UserControl
    {
        public SupplierAdd()
        {
            InitializeComponent();
            cmbCategory.DataSource = Enum.GetValues(typeof(SupplierCategory));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            mainForm.LoadUserControl(supplierManagementForm);
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            int supplierId = int.Parse(txtSupplierID.Text);
            if (Supplier.Exists(supplierId)) // Assuming you have an Exists method in your Supplier class
            {
                MessageBox.Show("A supplier with this ID already exists. Please enter a unique Supplier ID.");
                return;
            }
            // Load the current list of suppliers
            List<Supplier> suppliers = Supplier.LoadSuppliers();

            // Get and validate inputs (you might want to add more validation here)
            string name = txtSupplierName.Text;
            string email = txtSupplierEmail.Text;
            string address = txtSupplierAddress.Text;
            string city = txtSupplierCity.Text;

            // Check for Empty Fields
            if (string.IsNullOrWhiteSpace(txtSupplierID.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierEmail.Text) ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSupplierContact.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierAddress.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierCity.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // 2. Validate Numerical Values
            if (!int.TryParse(txtSupplierID.Text, out supplierId) ||
                !long.TryParse(txtSupplierContact.Text, out long contact)
                )
            {
                MessageBox.Show("Please enter valid numerical values for Supplier ID and Contact No.");
                return;
            }

            // 3. Category Selection
            string category = cmbCategory.SelectedItem.ToString();

            // Create and add the supplier
            Supplier newSupplier = new Supplier(supplierId, name, email, contact, (SupplierCategory)Enum.Parse(typeof(SupplierCategory), category), address, city);

            // Add the new supplier to the list
            bool success = Supplier.AddSupplier(newSupplier, suppliers);

            if (success)
                MessageBox.Show("Supplier added successfully!");
            else
                MessageBox.Show("An error occurred while adding the supplier.");
        }
    }
}
