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
    public partial class Dashboard : Form
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
            ProductManagementForm productManagementForm = new ProductManagementForm();
            productManagementForm.Show();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            // Open the Supplier Management Form
            SupplierManagementForm supplierManagementForm = new SupplierManagementForm();
            supplierManagementForm.Show();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            // Open the Sales Management Form
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            salesManagementForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logout and return to the Login Form
            User.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
