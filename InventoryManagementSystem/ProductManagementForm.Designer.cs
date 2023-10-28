namespace InventoryManagementSystem
{
    partial class ProductManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnAddForm = new Button();
            btnEditForm = new Button();
            btnViewProducts = new Button();
            btnBack = new Button();
            ProductChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)ProductChart).BeginInit();
            SuspendLayout();
            // 
            // btnAddForm
            // 
            btnAddForm.Location = new Point(317, 340);
            btnAddForm.Name = "btnAddForm";
            btnAddForm.Size = new Size(121, 23);
            btnAddForm.TabIndex = 0;
            btnAddForm.Text = "Add Product";
            btnAddForm.UseVisualStyleBackColor = true;
            btnAddForm.Click += btnAddForm_Click;
            // 
            // btnEditForm
            // 
            btnEditForm.Location = new Point(444, 340);
            btnEditForm.Name = "btnEditForm";
            btnEditForm.Size = new Size(121, 23);
            btnEditForm.TabIndex = 2;
            btnEditForm.Text = "Edit Product";
            btnEditForm.UseVisualStyleBackColor = true;
            btnEditForm.Click += btnEditForm_Click;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(169, 340);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(142, 23);
            btnViewProducts.TabIndex = 3;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(307, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ProductChart
            // 
            chartArea1.Name = "ChartArea1";
            ProductChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ProductChart.Legends.Add(legend1);
            ProductChart.Location = new Point(17, 13);
            ProductChart.Name = "ProductChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ProductChart.Series.Add(series1);
            ProductChart.Size = new Size(746, 300);
            ProductChart.TabIndex = 5;
            ProductChart.Text = "chart1";
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductChart);
            Controls.Add(btnBack);
            Controls.Add(btnViewProducts);
            Controls.Add(btnEditForm);
            Controls.Add(btnAddForm);
            Name = "ProductManagementForm";
            Size = new Size(800, 450);
            Load += ProductManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddForm;
        private Button btnEditForm;
        private Button btnViewProducts;
        private Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProductChart;
    }
}