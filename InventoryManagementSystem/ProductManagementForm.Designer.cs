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
            btnDeleteForm = new Button();
            btnEditForm = new Button();
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
            // btnDeleteForm
            // 
            btnDeleteForm.Location = new Point(543, 160);
            btnDeleteForm.Name = "btnDeleteForm";
            btnDeleteForm.Size = new Size(121, 23);
            btnDeleteForm.TabIndex = 1;
            btnDeleteForm.Text = "Delete Product";
            btnDeleteForm.UseVisualStyleBackColor = true;
            btnDeleteForm.Click += btnDeleteForm_Click;
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
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditForm);
            Controls.Add(btnDeleteForm);
            Controls.Add(btnAddForm);
            Name = "ProductManagementForm";
            Text = "ProductManagementForm";
            Load += ProductManagementForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddForm;
        private Button btnDeleteForm;
        private Button btnEditForm;
    }
}