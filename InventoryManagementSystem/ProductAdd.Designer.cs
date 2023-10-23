namespace InventoryManagementSystem
{
    partial class ProductAdd
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
            btnAddProduct = new Button();
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
            txtSupplierId = new TextBox();
            lblProductSupID = new Label();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(671, 550);
            btnAddProduct.Margin = new Padding(4, 5, 4, 5);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(136, 38);
            btnAddProduct.TabIndex = 25;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(580, 453);
            cmbCategory.Margin = new Padding(4, 5, 4, 5);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(171, 33);
            cmbCategory.TabIndex = 24;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(410, 467);
            lblProductCategory.Margin = new Padding(4, 0, 4, 0);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(151, 25);
            lblProductCategory.TabIndex = 23;
            lblProductCategory.Text = "Product Category";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(413, 418);
            lblProductQuantity.Margin = new Padding(4, 0, 4, 0);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(147, 25);
            lblProductQuantity.TabIndex = 22;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(439, 370);
            lblProductPrice.Margin = new Padding(4, 0, 4, 0);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(116, 25);
            lblProductPrice.TabIndex = 21;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(390, 322);
            lblProductDescription.Margin = new Padding(4, 0, 4, 0);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(169, 25);
            lblProductDescription.TabIndex = 20;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(430, 273);
            lblProductName.Margin = new Padding(4, 0, 4, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(126, 25);
            lblProductName.TabIndex = 19;
            lblProductName.Text = "Product Name";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(580, 405);
            txtProductQuantity.Margin = new Padding(4, 5, 4, 5);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(171, 31);
            txtProductQuantity.TabIndex = 18;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(580, 212);
            txtProductID.Margin = new Padding(4, 5, 4, 5);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(171, 31);
            txtProductID.TabIndex = 17;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(580, 308);
            txtProductDescription.Margin = new Padding(4, 5, 4, 5);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(171, 31);
            txtProductDescription.TabIndex = 16;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(580, 357);
            txtProductPrice.Margin = new Padding(4, 5, 4, 5);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(171, 31);
            txtProductPrice.TabIndex = 15;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(580, 260);
            txtProductName.Margin = new Padding(4, 5, 4, 5);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(171, 31);
            txtProductName.TabIndex = 14;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(460, 225);
            lblProductID.Margin = new Padding(4, 0, 4, 0);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(97, 25);
            lblProductID.TabIndex = 13;
            lblProductID.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(527, 550);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 38);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(580, 502);
            txtSupplierId.Margin = new Padding(4, 5, 4, 5);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(171, 31);
            txtSupplierId.TabIndex = 41;
            // 
            // lblProductSupID
            // 
            lblProductSupID.AutoSize = true;
            lblProductSupID.Location = new Point(459, 515);
            lblProductSupID.Margin = new Padding(4, 0, 4, 0);
            lblProductSupID.Name = "lblProductSupID";
            lblProductSupID.Size = new Size(100, 25);
            lblProductSupID.TabIndex = 42;
            lblProductSupID.Text = "Supplier ID";
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblProductSupID);
            Controls.Add(txtSupplierId);
            Controls.Add(btnCancel);
            Controls.Add(btnAddProduct);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductAdd";
            Text = "ProductAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
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
        private TextBox txtSupplierId;
        private Label lblProductSupID;
    }
}