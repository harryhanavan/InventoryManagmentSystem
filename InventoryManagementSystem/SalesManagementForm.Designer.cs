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
            btnViewSales = new Button();
            btnAddSale = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(395, 395);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(547, 259);
            btnViewSales.Margin = new Padding(3, 4, 3, 4);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(99, 31);
            btnViewSales.TabIndex = 1;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = true;
            btnViewSales.Click += btnViewSales_Click;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(251, 259);
            btnAddSale.Margin = new Padding(3, 4, 3, 4);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(86, 31);
            btnAddSale.TabIndex = 4;
            btnAddSale.Text = "Add Sale";
            btnAddSale.UseVisualStyleBackColor = true;
            btnAddSale.Click += btnAddSale_Click;
            // 
            // SalesManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddSale);
            Controls.Add(btnViewSales);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesManagementForm";
            Size = new Size(914, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnViewSales;
        private Button btnAddSale;
    }
}