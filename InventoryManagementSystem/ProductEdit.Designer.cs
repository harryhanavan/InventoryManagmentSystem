namespace InventoryManagementSystem
{
    partial class ProductEdit
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
            btnSaveProduct = new Button();
            cmbCategory = new ComboBox();
            lblProductCategory = new Label();
            lblProductQuantity = new Label();
            lblProductPrice = new Label();
            lblProductDescription = new Label();
            lblProductName = new Label();
            txtProductQuantity = new TextBox();
            txtProductID = new TextBox();
            txtProductDescription = new TextBox();
            txtProductPrice = new TextBox();
            txtProductName = new TextBox();
            lblProductID = new Label();
            btnBack = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblProductSupID = new Label();
            txtSupplierId = new TextBox();
            cmbProducts = new ComboBox();
            btnDeleteProduct = new Button();
            SuspendLayout();
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(917, 353);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(95, 23);
            btnSaveProduct.TabIndex = 38;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(856, 289);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 37;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(735, 297);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(100, 15);
            lblProductCategory.TabIndex = 36;
            lblProductCategory.Text = "Product Category";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(737, 268);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(98, 15);
            lblProductQuantity.TabIndex = 35;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(757, 239);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 34;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(723, 210);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 33;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(751, 181);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 32;
            lblProductName.Text = "Product Name";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(856, 260);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(121, 23);
            txtProductQuantity.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(856, 144);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(121, 23);
            txtProductID.TabIndex = 30;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(856, 202);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(121, 23);
            txtProductDescription.TabIndex = 29;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(856, 231);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(121, 23);
            txtProductPrice.TabIndex = 28;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(856, 173);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 27;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(772, 152);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(63, 15);
            lblProductID.TabIndex = 26;
            lblProductID.Text = "Product ID";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 39;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 220);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 40;
            label1.Text = "Search By ID/Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(348, 217);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 23);
            txtSearch.TabIndex = 41;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(494, 215);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 20);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblProductSupID
            // 
            lblProductSupID.AutoSize = true;
            lblProductSupID.Location = new Point(771, 326);
            lblProductSupID.Name = "lblProductSupID";
            lblProductSupID.Size = new Size(64, 15);
            lblProductSupID.TabIndex = 44;
            lblProductSupID.Text = "Supplier ID";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(856, 318);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(121, 23);
            txtSupplierId.TabIndex = 43;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(222, 248);
            cmbProducts.Margin = new Padding(2);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(350, 23);
            cmbProducts.TabIndex = 45;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(816, 353);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(95, 23);
            btnDeleteProduct.TabIndex = 46;
            btnDeleteProduct.Text = "Delete Product\r\n";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // ProductEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeleteProduct);
            Controls.Add(cmbProducts);
            Controls.Add(lblProductSupID);
            Controls.Add(txtSupplierId);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnSaveProduct);
            Controls.Add(cmbCategory);
            Controls.Add(lblProductCategory);
            Controls.Add(lblProductQuantity);
            Controls.Add(lblProductPrice);
            Controls.Add(lblProductDescription);
            Controls.Add(lblProductName);
            Controls.Add(txtProductQuantity);
            Controls.Add(txtProductID);
            Controls.Add(txtProductDescription);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductID);
            Name = "ProductEdit";
            Size = new Size(1080, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveProduct;
        private ComboBox cmbCategory;
        private Label lblProductCategory;
        private Label lblProductQuantity;
        private Label lblProductPrice;
        private Label lblProductDescription;
        private Label lblProductName;
        private TextBox txtProductQuantity;
        private TextBox txtProductID;
        private TextBox txtProductDescription;
        private TextBox txtProductPrice;
        private TextBox txtProductName;
        private Label lblProductID;
        private Button btnBack;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblProductSupID;
        private TextBox txtSupplierId;
        private ComboBox cmbProducts;
        private Button btnDeleteProduct;
    }
}