namespace InventoryManagementSystem
{
    partial class SalesViewForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            dataGridViewSales = new DataGridView();
            dataGridViewItemSales = new DataGridView();
            lblSupplierCategory = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItemSales).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(830, 276);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(212, 37);
            dataGridViewSales.Margin = new Padding(3, 4, 3, 4);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.RowTemplate.Height = 25;
            dataGridViewSales.Size = new Size(598, 235);
            dataGridViewSales.TabIndex = 6;
            dataGridViewSales.CellContentClick += dataGridViewSales_CellContentClick;
            // 
            // dataGridViewItemSales
            // 
            dataGridViewItemSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItemSales.Location = new Point(212, 311);
            dataGridViewItemSales.Margin = new Padding(3, 4, 3, 4);
            dataGridViewItemSales.Name = "dataGridViewItemSales";
            dataGridViewItemSales.RowHeadersWidth = 51;
            dataGridViewItemSales.RowTemplate.Height = 25;
            dataGridViewItemSales.Size = new Size(598, 239);
            dataGridViewItemSales.TabIndex = 7;
            dataGridViewItemSales.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSupplierCategory
            // 
            lblSupplierCategory.AutoSize = true;
            lblSupplierCategory.Location = new Point(458, 13);
            lblSupplierCategory.Name = "lblSupplierCategory";
            lblSupplierCategory.Size = new Size(122, 20);
            lblSupplierCategory.TabIndex = 53;
            lblSupplierCategory.Text = "Customer Details";
            lblSupplierCategory.Click += lblSupplierCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 287);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 54;
            label1.Text = "Item Details";
            // 
            // SalesViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(lblSupplierCategory);
            Controls.Add(dataGridViewItemSales);
            Controls.Add(dataGridViewSales);
            Controls.Add(btnBack);
            Name = "SalesViewForm";
            Size = new Size(1033, 613);
            Load += SalesViewForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItemSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button;
        private Button btnBack;
        private DataGridView dataGridViewSales;
        private DataGridView dataGridViewItemSales;
        private Label lblSupplierCategory;
        private Label label1;
    }
}
