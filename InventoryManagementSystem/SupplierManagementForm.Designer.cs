namespace InventoryManagementSystem
{
    partial class SupplierManagementForm
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
            btnBack = new Button();
            btnViewSuppliers = new Button();
            btnAddSuppliers = new Button();
            btnEditSuppliers = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(473, 279);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back to Dashboard";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewSuppliers
            // 
            btnViewSuppliers.Location = new Point(329, 229);
            btnViewSuppliers.Name = "btnViewSuppliers";
            btnViewSuppliers.Size = new Size(138, 23);
            btnViewSuppliers.TabIndex = 2;
            btnViewSuppliers.Text = "View Suppliers";
            btnViewSuppliers.UseVisualStyleBackColor = true;
            btnViewSuppliers.Click += btnViewSuppliers_Click;
            // 
            // btnAddSuppliers
            // 
            btnAddSuppliers.Location = new Point(473, 229);
            btnAddSuppliers.Name = "btnAddSuppliers";
            btnAddSuppliers.Size = new Size(138, 23);
            btnAddSuppliers.TabIndex = 3;
            btnAddSuppliers.Text = "Add Suppliers";
            btnAddSuppliers.UseVisualStyleBackColor = true;
            btnAddSuppliers.Click += btnAddSuppliers_Click;
            // 
            // btnEditSuppliers
            // 
            btnEditSuppliers.Location = new Point(617, 229);
            btnEditSuppliers.Name = "btnEditSuppliers";
            btnEditSuppliers.Size = new Size(138, 23);
            btnEditSuppliers.TabIndex = 4;
            btnEditSuppliers.Text = "Edit Suppliers";
            btnEditSuppliers.UseVisualStyleBackColor = true;
            btnEditSuppliers.Click += btnEditSuppliers_Click;
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditSuppliers);
            Controls.Add(btnAddSuppliers);
            Controls.Add(btnViewSuppliers);
            Controls.Add(btnBack);
            Name = "SupplierManagementForm";
            Size = new Size(1080, 540);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnViewSuppliers;
        private Button btnAddSuppliers;
        private Button btnEditSuppliers;
    }
}