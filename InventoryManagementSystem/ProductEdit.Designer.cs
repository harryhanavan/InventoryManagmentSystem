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
            SuspendLayout();
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.Location = new Point(457, 301);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(95, 23);
            btnSaveProduct.TabIndex = 38;
            btnSaveProduct.Text = "Save Product";
            btnSaveProduct.UseVisualStyleBackColor = true;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(406, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 37;
            // 
            // lblProductCategory
            // 
            lblProductCategory.AutoSize = true;
            lblProductCategory.Location = new Point(285, 275);
            lblProductCategory.Name = "lblProductCategory";
            lblProductCategory.Size = new Size(100, 15);
            lblProductCategory.TabIndex = 36;
            lblProductCategory.Text = "Product Category";
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.AutoSize = true;
            lblProductQuantity.Location = new Point(287, 251);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(98, 15);
            lblProductQuantity.TabIndex = 35;
            lblProductQuantity.Text = "Product Quantity";
            // 
            // lblProductPrice
            // 
            lblProductPrice.AutoSize = true;
            lblProductPrice.Location = new Point(307, 222);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(78, 15);
            lblProductPrice.TabIndex = 34;
            lblProductPrice.Text = "Product Price";
            // 
            // lblProductDescription
            // 
            lblProductDescription.AutoSize = true;
            lblProductDescription.Location = new Point(273, 193);
            lblProductDescription.Name = "lblProductDescription";
            lblProductDescription.Size = new Size(112, 15);
            lblProductDescription.TabIndex = 33;
            lblProductDescription.Text = "Product Description";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(301, 164);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 32;
            lblProductName.Text = "Product Name";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(406, 243);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(121, 23);
            txtProductQuantity.TabIndex = 31;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(406, 127);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(121, 23);
            txtProductID.TabIndex = 30;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(406, 185);
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(121, 23);
            txtProductDescription.TabIndex = 29;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(406, 214);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(121, 23);
            txtProductPrice.TabIndex = 28;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(406, 156);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(121, 23);
            txtProductName.TabIndex = 27;
            // 
            // lblProductID
            // 
            lblProductID.AutoSize = true;
            lblProductID.Location = new Point(322, 135);
            lblProductID.Name = "lblProductID";
            lblProductID.Size = new Size(63, 15);
            lblProductID.TabIndex = 26;
            lblProductID.Text = "Product ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(347, 301);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ProductEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveProduct);
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
            Name = "ProductEdit";
            Text = "ProductEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveProduct;
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
    }
}