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
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(360, 251);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewSuppliers
            // 
            btnViewSuppliers.Location = new Point(324, 203);
            btnViewSuppliers.Name = "btnViewSuppliers";
            btnViewSuppliers.Size = new Size(138, 23);
            btnViewSuppliers.TabIndex = 2;
            btnViewSuppliers.Text = "View Suppliers";
            btnViewSuppliers.UseVisualStyleBackColor = true;
            btnViewSuppliers.Click += btnViewSuppliers_Click;
            // 
            // SupplierManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewSuppliers);
            Controls.Add(btnBack);
            Name = "SupplierManagementForm";
            Text = "SupplierManagementForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnViewSuppliers;
    }
}