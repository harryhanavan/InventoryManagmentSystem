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
            comboBox1 = new ComboBox();
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
            btnAddProduct.Location = new Point(470, 330);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(95, 23);
            btnAddProduct.TabIndex = 25;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(406, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 24;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(287, 280);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(100, 15);
            lblProductCategory.TabIndex = 23;
            lblProductCategory.Text = "Product Category";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(289, 251);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(98, 15);
            lblProductQuantity.TabIndex = 22;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(307, 222);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 21;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(273, 193);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 20;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(301, 164);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 19;
            lblProductName.Text = "Product Name";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(406, 243);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(121, 23);
            txtProductQuantity.TabIndex = 18;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(406, 127);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(121, 23);
            txtProductID.TabIndex = 17;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(406, 185);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(121, 23);
            txtProductDescription.TabIndex = 16;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(406, 214);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(121, 23);
            txtProductPrice.TabIndex = 15;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(406, 156);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 14;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(322, 135);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(63, 15);
            lblProductID.TabIndex = 13;
            lblProductID.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(369, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 23);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(406, 301);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(121, 23);
            txtSupplierId.TabIndex = 41;
            // 
            // lblProductSupID
            // 
            lblProductSupID.AutoSize = true;
            lblProductSupID.Location = new Point(321, 309);
            lblProductSupID.Name = "lblProductSupID";
            lblProductSupID.Size = new Size(64, 15);
            lblProductSupID.TabIndex = 42;
            lblProductSupID.Text = "Supplier ID";
            // 
            // ProductAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblProductSupID);
            Controls.Add(txtSupplierId);
            Controls.Add(btnCancel);
            Controls.Add(btnAddProduct);
            Controls.Add(comboBox1);
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
            Name = "ProductAdd";
            Text = "ProductAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private ComboBox comboBox1;
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