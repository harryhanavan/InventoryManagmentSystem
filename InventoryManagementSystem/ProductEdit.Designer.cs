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
            btnCancel = new Button();
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
            btnSaveProduct.Location = new Point(627, 302);
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
            cmbCategory.Location = new Point(566, 238);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 37;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(445, 246);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(100, 15);
            lblProductCategory.TabIndex = 36;
            lblProductCategory.Text = "Product Category";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(447, 217);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(98, 15);
            lblProductQuantity.TabIndex = 35;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(467, 188);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 34;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(433, 159);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 33;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(461, 130);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 32;
            lblProductName.Text = "Product Name";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(566, 209);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(121, 23);
            txtProductQuantity.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(566, 93);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(121, 23);
            txtProductID.TabIndex = 30;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(566, 151);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(121, 23);
            txtProductDescription.TabIndex = 29;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(566, 180);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(121, 23);
            txtProductPrice.TabIndex = 28;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(566, 122);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 27;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(482, 101);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(63, 15);
            lblProductID.TabIndex = 26;
            lblProductID.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(517, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 130);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 40;
            label1.Text = "Search By ID/Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(172, 127);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 23);
            txtSearch.TabIndex = 41;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(318, 125);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
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
            lblProductSupID.Location = new Point(481, 275);
            lblProductSupID.Name = "lblProductSupID";
            lblProductSupID.Size = new Size(64, 15);
            lblProductSupID.TabIndex = 44;
            lblProductSupID.Text = "Supplier ID";
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(566, 267);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(121, 23);
            txtSupplierId.TabIndex = 43;
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(46, 158);
            cmbProducts.Margin = new Padding(2, 2, 2, 2);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(350, 23);
            cmbProducts.TabIndex = 45;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(578, 331);
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
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteProduct);
            Controls.Add(cmbProducts);
            Controls.Add(lblProductSupID);
            Controls.Add(txtSupplierId);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnCancel);
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
            Text = "ProductEdit";
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
        private Button btnCancel;
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblProductSupID;
        private TextBox txtSupplierId;
        private ComboBox cmbProducts;
        private Button btnDeleteProduct;
    }
}