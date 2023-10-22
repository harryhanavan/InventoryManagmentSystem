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
    public partial class ProductManagementForm : Form
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
            ProductAdd productAddForm = new ProductAdd();
            productAddForm.ShowDialog(); // ShowDialog will open the form as a modal dialog box
        }

        private void btnEditForm_Click(object sender, EventArgs e)
        {
            ProductEdit productEditForm = new ProductEdit();
            productEditForm.ShowDialog();
        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            ProductDelete productDeleteForm = new ProductDelete();
            productDeleteForm.ShowDialog();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ProductView productViewForm = new ProductView();
            productViewForm.ShowDialog();
        }
    }
}
