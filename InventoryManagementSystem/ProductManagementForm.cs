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
        private void LoadProductDataIntoChart(string category = null, string searchTerm = null, string selectedPriceRange = null, int? selectedSupplierID = null)
        {
            ProductChart.Series.Clear();
            Series series = new Series
            {
                Name = "Stock Level",
                ChartType = SeriesChartType.Column
            };
            ProductChart.Series.Add(series);
            List<Product> products = Product.LoadProducts();
            // Filtering products based on the selected category, search term, price range, and supplier ID.
            var filteredProducts = products
                .Where(p => string.IsNullOrEmpty(searchTerm) || p.ProductID.ToString().Contains(searchTerm) || p.Name.ToLower().Contains(searchTerm))
                .Where(p => category == "All" || string.IsNullOrEmpty(category) || p.Category.ToString() == category)
                .Where(p => string.IsNullOrEmpty(selectedPriceRange) || PriceInRange(p.Price, selectedPriceRange))
                .Where(p => selectedSupplierID == -1 || !selectedSupplierID.HasValue || p.SupplierID == selectedSupplierID.Value)
                .ToList();
            int count = 0;
            foreach (var product in filteredProducts)
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
            string selectedPriceRange = cmbPrice.SelectedItem as string;
            int? selectedSupplierID = null;
            if (cmbSupplier.SelectedItem != null) // Checking if SelectedItem is not null
            {
                if (int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
                {
                    selectedSupplierID = parsedSupplierID;
                }
                else if (cmbSupplier.SelectedItem.ToString() == "All") // Assuming "All" is a string in the ComboBox
                {
                    selectedSupplierID = -1;
                }
            }
            LoadProductDataIntoChart(category: selectedCategory, selectedPriceRange: selectedPriceRange, selectedSupplierID: selectedSupplierID);
        }
        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            string selectedPriceRange = cmbPrice.SelectedItem?.ToString();
            int? selectedSupplierID = null;

            if (cmbSupplier.SelectedItem != null)
            {
                if (int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
                {
                    selectedSupplierID = parsedSupplierID;
                }
                else if (cmbSupplier.SelectedItem.ToString() == "All") // Assuming "All" is a string in the ComboBox
                {
                    selectedSupplierID = -1;
                }
            }

            LoadProductDataIntoChart(category: selectedCategory, selectedPriceRange: selectedPriceRange, selectedSupplierID: selectedSupplierID);
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            string selectedPriceRange = cmbPrice.SelectedItem?.ToString();
            int? selectedSupplierID = null;
            if (cmbSupplier.SelectedItem != null) // Checking if SelectedItem is not null
            {
                if (int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
                {
                    selectedSupplierID = parsedSupplierID;
                }
                else if (cmbSupplier.SelectedItem.ToString() == "All") // Assuming "All" is a string in the ComboBox
                {
                    selectedSupplierID = -1;
                }
            }
            LoadProductDataIntoChart(category: selectedCategory, selectedPriceRange: selectedPriceRange, selectedSupplierID: selectedSupplierID);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            string selectedPriceRange = cmbPrice.SelectedItem as string;
            int? selectedSupplierID = null;

            if (cmbSupplier.SelectedItem != null)
            {
                if (int.TryParse(cmbSupplier.SelectedItem.ToString(), out int parsedSupplierID))
                {
                    selectedSupplierID = parsedSupplierID;
                }
                else if (cmbSupplier.SelectedItem.ToString() == "All") // Assuming "All" is a string in the ComboBox
                {
                    selectedSupplierID = -1; // Or you can keep it null
                }
            }

            List<Product> products = Product.LoadProducts();
            var filteredProducts = products
                .Where(p => string.IsNullOrEmpty(searchTerm) || p.ProductID.ToString().Contains(searchTerm) || p.Name.ToLower().Contains(searchTerm))
                .Where(p => selectedCategory == "All" || string.IsNullOrEmpty(selectedCategory) || p.Category.ToString() == selectedCategory)
                .Where(p => string.IsNullOrEmpty(selectedPriceRange) || PriceInRange(p.Price, selectedPriceRange))
                .Where(p => selectedSupplierID == -1 || !selectedSupplierID.HasValue || p.SupplierID == selectedSupplierID.Value)
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
                case "All":
                    return true; // No price filter
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
