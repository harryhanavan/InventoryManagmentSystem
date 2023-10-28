namespace InventoryManagementSystem
{
    partial class SalesManagementForm
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
            btnNewSale = new Button();
            btnViewSales = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(346, 296);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNewSale
            // 
            btnNewSale.Location = new Point(249, 141);
            btnNewSale.Name = "btnNewSale";
            btnNewSale.Size = new Size(75, 23);
            btnNewSale.TabIndex = 1;
            btnNewSale.Text = "New Sale";
            btnNewSale.UseVisualStyleBackColor = true;
            btnNewSale.Click += btnNewSale_Click;
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(526, 148);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(75, 23);
            btnViewSales.TabIndex = 2;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = true;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // SalesManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnViewSales);
            Controls.Add(btnNewSale);
            Controls.Add(btnBack);
            Name = "SalesManagementForm";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnNewSale;
        private Button btnViewSales;
    }
}