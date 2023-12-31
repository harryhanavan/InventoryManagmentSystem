﻿using System;
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
    public partial class SupplierManagementForm : UserControl
    {
        public SupplierManagementForm()
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

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            // Find the Main form
            Control parentControl = this.Parent;
            while (!(parentControl is Main) && parentControl != null)
            {
                parentControl = parentControl.Parent;
            }

            if (parentControl is Main mainForm)
            {
                SupplierView supplierView = new SupplierView();
                mainForm.LoadUserControl(supplierView);
            }
        }

        private void btnEditSuppliers_Click(object sender, EventArgs e)
        {
            // Find the Main form
            Control parentControl = this.Parent;
            while (!(parentControl is Main) && parentControl != null)
            {
                parentControl = parentControl.Parent;
            }

            if (parentControl is Main mainForm)
            {
                SupplierEdit supplierEdit = new SupplierEdit();
                mainForm.LoadUserControl(supplierEdit);
            }
        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            // Find the Main form
            Control parentControl = this.Parent;
            while (!(parentControl is Main) && parentControl != null)
            {
                parentControl = parentControl.Parent;
            }

            if (parentControl is Main mainForm)
            {
                SupplierAdd supplierAdd = new SupplierAdd();
                mainForm.LoadUserControl(supplierAdd);
            }
        }
    }
}
