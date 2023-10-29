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
    public partial class SalesViewForm : UserControl
    {
        public SalesViewForm()
        {
            InitializeComponent();
            LoadSalesIntoDataGridView();
            LoadItemSalesIntoDataGridView();
        }

        private void SalesViewForm_Load(object sender, EventArgs e)
        {
            LoadSalesIntoDataGridView();
            LoadItemSalesIntoDataGridView();
        }


        private void LoadSalesIntoDataGridView()
        {
            try
            {
                dataGridViewSales.Rows.Clear();

                List<Sale> sales = Sale.LoadSales();
                dataGridViewSales.DataSource = sales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured while loading sales: " + ex.Message + "\n" + ex.StackTrace);

            }
        }

        private void LoadItemSalesIntoDataGridView()
        {
            try
            {
                dataGridViewItemSales.Rows.Clear();

                List<SaleItem> itemSales = SaleItem.LoadSaleItems();
                dataGridViewItemSales.DataSource = itemSales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("an error occured while loading item sales: " + ex.Message + "\n" + ex.StackTrace);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)ParentForm;
            SalesManagementForm salesManagementForm = new SalesManagementForm();
            mainForm.LoadUserControl(salesManagementForm);
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalesViewForm_Load_1(object sender, EventArgs e)
        {

        }

        private void lblSupplierCategory_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
