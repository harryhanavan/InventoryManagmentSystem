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
        /// 
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            btnAddForm = new Button();
            btnEditForm = new Button();
            btnViewProducts = new Button();
            btnBack = new Button();
            ProductChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            productBindingSource = new BindingSource(components);
            label5 = new Label();
            label4 = new Label();
            cmbSupplier = new ComboBox();
            label3 = new Label();
            cmbPrice = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbCategory = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAddForm
            // 
            btnAddForm.Location = new Point(477, 360);
            btnAddForm.Name = "btnAddForm";
            btnAddForm.Size = new Size(121, 23);
            btnAddForm.TabIndex = 0;
            btnAddForm.Text = "Add Product";
            btnAddForm.UseVisualStyleBackColor = true;
            btnAddForm.Click += btnAddForm_Click;
            // 
            // btnEditForm
            // 
            btnEditForm.Location = new Point(604, 360);
            btnEditForm.Name = "btnEditForm";
            btnEditForm.Size = new Size(121, 23);
            btnEditForm.TabIndex = 2;
            btnEditForm.Text = "Edit Product";
            btnEditForm.UseVisualStyleBackColor = true;
            btnEditForm.Click += btnEditForm_Click;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(329, 360);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(142, 23);
            btnViewProducts.TabIndex = 3;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(467, 405);
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
            ProductChart.Location = new Point(16, 101);
            ProductChart.Name = "ProductChart";
            ProductChart.Size = new Size(1046, 233);
            ProductChart.TabIndex = 5;
            ProductChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Product Stock Levles";
            ProductChart.Titles.Add(title1);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(815, 54);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 20;
            label5.Text = "Search by Product ID or Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(375, 46);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 19;
            label4.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "All", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbSupplier.Location = new Point(341, 64);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(121, 23);
            cmbSupplier.TabIndex = 18;
            cmbSupplier.SelectedIndexChanged += cmbSupplier_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 46);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 17;
            label3.Text = "Price";
            // 
            // cmbPrice
            // 
            cmbPrice.FormattingEnabled = true;
            cmbPrice.Items.AddRange(new object[] { "All", "Below $50", "$50 - $100", "$100 - $150", "$150-$300", "$300+" });
            cmbPrice.Location = new Point(190, 63);
            cmbPrice.Name = "cmbPrice";
            cmbPrice.Size = new Size(121, 23);
            cmbPrice.TabIndex = 16;
            cmbPrice.SelectedIndexChanged += cmbPrice_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 15;
            label2.Text = "Filter by:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(43, 64);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 13;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(807, 72);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(987, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cmbSupplier);
            Controls.Add(label3);
            Controls.Add(cmbPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategory);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(ProductChart);
            Controls.Add(btnBack);
            Controls.Add(btnViewProducts);
            Controls.Add(btnEditForm);
            Controls.Add(btnAddForm);
            Name = "ProductManagementForm";
            Size = new Size(1080, 540);
            Load += ProductManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProductChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddForm;
        private Button btnEditForm;
        private Button btnViewProducts;
        private Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProductChart;
        private BindingSource productBindingSource;
        private Label label5;
        private Label label4;
        private ComboBox cmbSupplier;
        private Label label3;
        private ComboBox cmbPrice;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategory;
        private TextBox txtSearch;
        private Button btnSearch;

    }
}