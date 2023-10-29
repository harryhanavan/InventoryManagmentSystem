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
using System.Windows.Forms.DataVisualization.Charting;


namespace InventoryManagementSystem
{
    public partial class ProductManagementForm : UserControl
    {
        public ProductManagementForm()
        {
            InitializeComponent();
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategory));
        }
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            LoadProductDataIntoChart();

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
        private void LoadProductDataIntoChart(string category = null, string searchTerm = null)
        {
            ProductChart.Series.Clear();
            Series series = new Series
            {
                Name = "Stock Level",
                ChartType = SeriesChartType.Column
            };

            ProductChart.Series.Add(series);
            List<Product> products = Product.LoadProducts();
            int count = 0;
            foreach (var product in products)
            {
                series.Points.Add(product.Quantity);
                series.Points[count].AxisLabel = product.Name;

                count++;
            }
            // Customize X-axis
            ProductChart.ChartAreas[0].AxisX.Interval = 1; // Set interval for X-axis labels
            ProductChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Angle the X-axis labels for better visibility

            // Customize Series
            ProductChart.Series[0].Color = Color.RoyalBlue; // Set the color of the bars
            ProductChart.Series[0].IsValueShownAsLabel = true; // Display data labels on the bars

            // Customize Chart Area
            ProductChart.ChartAreas[0].Area3DStyle.Enable3D = false; // Disable 3D style for better clarity

            // Customize Legends
            ProductChart.Legends[0].Enabled = false;
            // Adjusting bar width
            ProductChart.Series[0]["PixelPointWidth"] = "40"; // Set the width of the bars

            // Adjusting X-axis label angle
            ProductChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Tilt the X-axis labels

            // Enabling zooming and scrolling
            ProductChart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            ProductChart.ChartAreas[0].CursorX.AutoScroll = true;
            ProductChart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            series.IsXValueIndexed = true; // Treat X values as index values

            // Set AxisX interval and disable auto-fit labels
            var chartArea = ProductChart.ChartAreas[0];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.IsLabelAutoFit = false;
            chartArea.AxisX.LabelStyle.Angle = 0;

            // Refresh the chart
            ProductChart.Invalidate();
            ProductChart.Update();
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            LoadProductDataIntoChart(category: selectedCategory);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchTerm = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem as string;
            string selectedPriceRange = comboBox1.SelectedItem as string;
            int selectedSupplierID = -1; // Default value
            if (cmbSupplier.SelectedItem != null && int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
            {
                selectedSupplierID = parsedSupplierID;

                Console.WriteLine($"Selected Supplier ID: {selectedSupplierID}"); // Debugging output
            }
            else
            {
                Console.WriteLine("No Supplier ID selected or failed to parse."); // Debugging output
            }


            List<Product> products = Product.LoadProducts();

            var filteredProducts = products
                .Where(p => string.IsNullOrEmpty(searchTerm) || p.ProductID.ToString().Contains(searchTerm) || p.Name.ToLower().Contains(searchTerm))
                .Where(p => string.IsNullOrEmpty(selectedCategory) || p.Category.ToString() == selectedCategory)
                .Where(p => string.IsNullOrEmpty(selectedPriceRange) || PriceInRange(p.Price, selectedPriceRange))
                .Where(p => cmbSupplier.SelectedItem == null || (p.SupplierID == selectedSupplierID))
                .ToList();
            // Clear previous data
            ProductChart.Series["Stock Level"].Points.Clear();

            // Load new data into the chart
            foreach (var product in filteredProducts)
            {
                ProductChart.Series["Stock Level"].Points.AddXY(product.Name, product.Quantity);
            }

            // Refresh the chart
            ProductChart.Invalidate();
            ProductChart.Update();

        }
        private bool PriceInRange(decimal price, string selectedPriceRange)
        {
            switch (selectedPriceRange)
            {
                case "Below $50":
                    return price < 50;
                case "$50 - $100":
                    return price >= 50 && price < 100;
                case "$100 - $150":
                    return price >= 100 && price < 150;
                case "$150-$300":
                    return price >= 150 && price < 300;
                case "$300+":
                    return price >= 300;
                default:
                    return true; // If no range is selected or if the range is not recognized, ignore the price filter
            }
        }
    }
}
