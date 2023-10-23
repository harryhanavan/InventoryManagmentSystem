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
            btnAddForm = new Button();
            btnEditForm = new Button();
            btnViewProducts = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnAddForm
            // 
            btnAddForm.Location = new Point(283, 160);
            btnAddForm.Name = "btnAddForm";
            btnAddForm.Size = new Size(121, 23);
            btnAddForm.TabIndex = 0;
            btnAddForm.Text = "Add Product";
            btnAddForm.UseVisualStyleBackColor = true;
            btnAddForm.Click += btnAddForm_Click;
            // 
            // btnEditForm
            // 
            btnEditForm.Location = new Point(410, 160);
            btnEditForm.Name = "btnEditForm";
            btnEditForm.Size = new Size(121, 23);
            btnEditForm.TabIndex = 2;
            btnEditForm.Text = "Edit Product";
            btnEditForm.UseVisualStyleBackColor = true;
            btnEditForm.Click += btnEditForm_Click;
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(135, 160);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(142, 23);
            btnViewProducts.TabIndex = 3;
            btnViewProducts.Text = "View Products";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(273, 205);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(144, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnViewProducts);
            Controls.Add(btnEditForm);
            Controls.Add(btnAddForm);
            Name = "ProductManagementForm";
            Text = "ProductManagementForm";
            Load += ProductManagementForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddForm;
        private Button btnEditForm;
        private Button btnViewProducts;
        private Button btnBack;
    }
}