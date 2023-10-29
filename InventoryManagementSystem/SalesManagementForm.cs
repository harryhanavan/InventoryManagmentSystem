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
    public partial class SalesManagementForm : UserControl
    {
        public SalesManagementForm()
        {
            InitializeComponent();
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

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            // Find the Main form
            Control parentControl = this.Parent;
            while (!(parentControl is Main) && parentControl != null)
            {
                parentControl = parentControl.Parent;
            }

            if (parentControl is Main mainForm)
            {
                NewSale newSale = new NewSale();
                mainForm.LoadUserControl(newSale);
            }
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            // Find the Main form
            Control parentControl = this.Parent;
            while (!(parentControl is Main) && parentControl != null)
            {
                parentControl = parentControl.Parent;
            }

            if (parentControl is Main mainForm)
            {
                SaleView saleView = new SaleView();
                mainForm.LoadUserControl(saleView);
            }
        }
    }
}
