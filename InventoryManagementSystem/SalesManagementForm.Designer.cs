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
            this.btnBack = new Button();
            btnViewSales = new Button();
            btnViewOrders = new Button();
            btnAddOrder = new Button();
            btnAddSale = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new Point(395, 395);
            this.btnBack.Margin = new Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(86, 31);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += this.btnBack_Click;
            // 
            // btnViewSales
            // 
            btnViewSales.Location = new Point(262, 259);
            btnViewSales.Margin = new Padding(3, 4, 3, 4);
            btnViewSales.Name = "btnViewSales";
            btnViewSales.Size = new Size(99, 31);
            btnViewSales.TabIndex = 1;
            btnViewSales.Text = "View Sales";
            btnViewSales.UseVisualStyleBackColor = true;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(701, 259);
            btnViewOrders.Margin = new Padding(3, 4, 3, 4);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(109, 31);
            btnViewOrders.TabIndex = 2;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(559, 259);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(99, 31);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddSale
            // 
            btnAddSale.Location = new Point(121, 259);
            btnAddSale.Margin = new Padding(3, 4, 3, 4);
            btnAddSale.Name = "btnAddSale";
            btnAddSale.Size = new Size(86, 31);
            btnAddSale.TabIndex = 4;
            btnAddSale.Text = "Add Sale";
            btnAddSale.UseVisualStyleBackColor = true;
            // 
            // SalesManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddSale);
            Controls.Add(btnAddOrder);
            Controls.Add(btnViewOrders);
            Controls.Add(btnViewSales);
            Controls.Add(this.btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesManagementForm";
            Size = new Size(914, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnViewSales;
        private Button btnViewOrders;
        private Button btnAddOrder;
        private Button btnAddSale;
    }
}