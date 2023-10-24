using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ProductManagementForm : UserControl
    {
        public ProductManagementForm()
        {
            InitializeComponent();
        }
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {

        }
        private void btnAddForm_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm; // Getting reference to Main form
            ProductAdd productAdd = new ProductAdd();
            mainForm.LoadUserControl(productAdd);
        }
        private void btnEditForm_Click(object sender, EventArgs e)
        {
            Main mainFrom = (Main)this.ParentForm; // Getting reference to Main form
            ProductEdit productEdit = new ProductEdit();
            mainFrom.LoadUserControl(productEdit);
        }
        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            Main mainFrom = (Main)this.ParentForm;
            ProductView productView = new ProductView();
            mainFrom.LoadUserControl(productView);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            User currentUser = User.CurrentUser;
            if (currentUser != null)
            {
                Dashboard dashboard = new Dashboard(currentUser);
                mainForm.LoadUserControl(dashboard);
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                mainForm.LoadUserControl(loginForm);
            }
        }
    }
}
