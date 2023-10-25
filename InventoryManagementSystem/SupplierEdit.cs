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
    public partial class SupplierEdit : UserControl
    {
        public SupplierEdit()
        {
            InitializeComponent();
            cmbSuppliers.SelectedIndexChanged += new EventHandler(supplierSelected);
            // Populate the category ComboBox
            cmbCategory.DataSource = Enum.GetValues(typeof(SupplierCategory));
        }
        bool DelInProg = false;
        private void supplierSelected(object sender, EventArgs e)
        {
            Supplier selectedSupplier = (Supplier)cmbSuppliers.SelectedItem;

            if (selectedSupplier == null && DelInProg == false)
            {
                // Only show the message if there are items in the ComboBox but none is selected
                MessageBox.Show("No supplier selected.");
                return;
            }

            if (selectedSupplier != null)
            {
                txtSupplierID.Text = selectedSupplier.SupplierID.ToString();
                txtSupplierName.Text = selectedSupplier.Name;
                txtSupplierEmail.Text = selectedSupplier.EmailAddress;
                cmbCategory.SelectedItem = selectedSupplier.Category;
                txtSupplierContact.Text = selectedSupplier.PhoneNumber.ToString();
                txtSupplierAddress.Text = selectedSupplier.Address.ToString();
                txtSupplierCity.Text = selectedSupplier.City.ToString();
            }
        }
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            // User Confirmation
            // Get the selected supplier
            Supplier selectedSupplier = (Supplier)cmbSuppliers.SelectedItem;
            if (selectedSupplier == null)
            {
                MessageBox.Show("No supplier selected.");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected supplier?",
                                                       "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) return;

            DelInProg = true; // Set flag indicating deletion is in progress

            // Delete the supplier and update the ComboBox
            bool deleted = Supplier.DeleteSupplier(selectedSupplier.SupplierID, Supplier.LoadSuppliers());
            if (deleted)
            {
                cmbSuppliers.DataSource = null;
                cmbSuppliers.DataSource = Supplier.LoadSuppliers();
                cmbSuppliers.DisplayMember = "Name";
                cmbSuppliers.ValueMember = "SupplierID";

                MessageBox.Show("Supplier deleted successfully!");
            }
            else
            {
                MessageBox.Show("An error occurred while deleting the supplier.");
            }

            DelInProg = false; // Reset flag after deletion process
        }

        private void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = int.Parse(txtSupplierID.Text);
                if (Supplier.Exists(supplierId)) // Assuming you have an Exists method in your Supplier class
                {
                    MessageBox.Show("A supplier with this ID already exists. Please enter a unique Supplier ID.");
                    return;
                }
                //Ensure that the necessary fields are not empty
                if (string.IsNullOrEmpty(txtSupplierID.Text) ||
                    string.IsNullOrEmpty(txtSupplierName.Text) ||
                    string.IsNullOrEmpty(txtSupplierEmail.Text) ||
                    string.IsNullOrEmpty(txtSupplierContact.Text) ||
                    cmbCategory.SelectedItem == null ||
                    string.IsNullOrEmpty(txtSupplierAddress.Text) ||
                    string.IsNullOrEmpty(txtSupplierCity.Text))
                {
                    MessageBox.Show("Please ensure all fields are filled out correctly.");
                    return;
                }
                if (!int.TryParse(txtSupplierID.Text, out supplierId) ||
                !long.TryParse(txtSupplierContact.Text, out long contact)
                )
                {
                    MessageBox.Show("Please enter valid numerical values for Supplier ID and Contact No.");
                    return;
                }
                supplierId = int.Parse(txtSupplierID.Text);
                string name = txtSupplierName.Text;
                string email = txtSupplierEmail.Text;
                contact = long.Parse(txtSupplierContact.Text);
                SupplierCategory category = (SupplierCategory)cmbCategory.SelectedItem;
                string address = txtSupplierAddress.Text;
                string city = txtSupplierCity.Text;
                Supplier.EditSupplier(supplierId, name, email, contact, category, address, city, Supplier.LoadSuppliers());
                MessageBox.Show("Supplier updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the supplier: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            mainForm.LoadUserControl(supplierManagementForm);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            List<Supplier> suppliers = Supplier.LoadSuppliers();

            var matchedSuppliers = suppliers
                .Where(p => p.SupplierID.ToString() == searchTerm || p.Name.ToLower().Contains(searchTerm))
                .ToList();
            cmbSuppliers.DataSource = null; // Clear previous data source
            cmbSuppliers.DataSource = matchedSuppliers; // Set new data source
            cmbSuppliers.DisplayMember = "Name"; // Assuming you want to display the Name of the supplier in the ComboBox
            cmbSuppliers.ValueMember = "SupplierID"; // Set the hidden value of ComboBox items to SupplierID
        }
    }
}
