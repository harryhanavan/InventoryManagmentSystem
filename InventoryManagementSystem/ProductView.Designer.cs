﻿namespace InventoryManagementSystem
{
    partial class ProductView
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
            dataGridViewProducts = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cmbPrice = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cmbSupplier = new ComboBox();
            label5 = new Label();
            btnback = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(151, 167);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(744, 198);
            dataGridViewProducts.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(820, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(640, 123);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(151, 123);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 105);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 71);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Filter by:";
            // 
            // cmbPrice
            // 
            cmbPrice.FormattingEnabled = true;
            cmbPrice.Items.AddRange(new object[] { "Below $50", "$50 - $100", "$100 - $150", "$150-$300", "$300+" });
            cmbPrice.Location = new Point(298, 122);
            cmbPrice.Name = "cmbPrice";
            cmbPrice.Size = new Size(121, 23);
            cmbPrice.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 105);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(483, 105);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Supplier";
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbSupplier.Location = new Point(449, 123);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(121, 23);
            cmbSupplier.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(648, 105);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 10;
            label5.Text = "Search by Product ID or Name";
            // 
            // btnback
            // 
            btnback.Location = new Point(3, 3);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 23);
            btnback.TabIndex = 11;
            btnback.Text = "< Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnback);
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
            Controls.Add(dataGridViewProducts);
            Name = "ProductView";
            Size = new Size(1080, 540);
            Load += ProductView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cmbCategory;
        private Label label1;
        private Label label2;
        private ComboBox cmbPrice;
        private Label label3;
        private Label label4;
        private ComboBox cmbSupplier;
        private Label label5;
        private Button btnback;
    }
}