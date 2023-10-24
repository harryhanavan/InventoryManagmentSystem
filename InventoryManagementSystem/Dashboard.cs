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
    public partial class Dashboard : UserControl
    {
        private User loggedInUser;
        public Dashboard(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            WelcomeLabel.Text = $"Welcome, {loggedInUser.Username}!";
        }
        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            // Open the Product Management Form
            Main mainForm = (Main)this.ParentForm; // Getting reference to Main form
            ProductManagementForm productManagementForm = new ProductManagementForm();
            mainForm.LoadUserControl(productManagementForm);
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            // Open the Supplier Management Form
            Main mainForm = (Main)this.ParentForm; // Getting reference to Main form
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            mainForm.LoadUserControl(supplierManagementForm);
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            // Open the Sales Management Form
            Main mainForm = (Main)this.ParentForm; // Getting reference to Main form
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            mainForm.LoadUserControl(salesManagementForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout
            User.Logout();

            // Get reference to the parent form or container
            Main mainForm = (Main)this.ParentForm;
            LoginForm loginForm = new LoginForm();
            mainForm.LoadUserControl(loginForm);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

    }
}
