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
    public partial class SupplierAdd : UserControl
    {
        public SupplierAdd()
        {
            InitializeComponent();
            cmbCategory.DataSource = Enum.GetValues(typeof(SupplierCategory));

        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // Load the current list of suppliers
            List<Supplier> suppliers = Supplier.LoadSuppliers();

            // Get and validate inputs (you might want to add more validation here)
            string name = txtSupplierName.Text;
            string description = txtSupplierEmail.Text;

            // Check for Empty Fields
            if (string.IsNullOrWhiteSpace(txtSupplierID.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierEmail.Text) ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSupplierQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // 2. Validate Numerical Values
            if (!int.TryParse(txtSupplierID.Text, out int supplierId) ||
                !int.TryParse(txtSupplierQuantity.Text, out int quantity) ||
                !decimal.TryParse(txtSupplierPrice.Text, out decimal price) ||
                !int.TryParse(txtSupplierIdOLD.Text, out int supplierId))
            {
                MessageBox.Show("Please enter valid numerical values for Supplier ID, Quantity, Price, and Supplier ID.");
                return;
            }

            // 3. Category Selection
            string category = cmbCategory.SelectedItem.ToString();

            // Create and add the supplier
            Supplier newSupplier = new Supplier(supplierId, name, description, (SupplierCategory)Enum.Parse(typeof(SupplierCategory), category), price, quantity, supplierId);

            // Add the new supplier to the list
            bool success = Supplier.AddSupplier(newSupplier, suppliers);

            if (success)
                MessageBox.Show("Supplier added successfully!");
            else
                MessageBox.Show("An error occurred while adding the supplier.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            mainForm.LoadUserControl(supplierManagementForm);
        }
    }
}
