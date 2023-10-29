namespace InventoryManagementSystem
{
    partial class Dashboard
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
            ProdMgmntBttn = new Button();
            SupMgmntBttn = new Button();
            SalesMgmntBttn = new Button();
            WelcomeLabel = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // ProdMgmntBttn
            // 
            ProdMgmntBttn.Location = new Point(320, 230);
            ProdMgmntBttn.Name = "ProdMgmntBttn";
            ProdMgmntBttn.Size = new Size(141, 23);
            ProdMgmntBttn.TabIndex = 0;
            ProdMgmntBttn.Text = "Product Management";
            ProdMgmntBttn.UseVisualStyleBackColor = true;
            ProdMgmntBttn.Click += btnManageProducts_Click;
            // 
            // SupMgmntBttn
            // 
            SupMgmntBttn.Location = new Point(467, 230);
            SupMgmntBttn.Name = "SupMgmntBttn";
            SupMgmntBttn.Size = new Size(150, 23);
            SupMgmntBttn.TabIndex = 1;
            SupMgmntBttn.Text = "Supplier Management";
            SupMgmntBttn.UseVisualStyleBackColor = true;
            SupMgmntBttn.Click += btnManageSuppliers_Click;
            // 
            // SalesMgmntBttn
            // 
            SalesMgmntBttn.Location = new Point(623, 230);
            SalesMgmntBttn.Name = "SalesMgmntBttn";
            SalesMgmntBttn.Size = new Size(131, 23);
            SalesMgmntBttn.TabIndex = 2;
            SalesMgmntBttn.Text = "Sales Management";
            SalesMgmntBttn.UseVisualStyleBackColor = true;
            SalesMgmntBttn.Click += btnManageSales_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new Point(513, 212);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(60, 15);
            WelcomeLabel.TabIndex = 3;
            WelcomeLabel.Text = "Welcome:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(498, 259);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(88, 23);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLogout);
            Controls.Add(WelcomeLabel);
            Controls.Add(SalesMgmntBttn);
            Controls.Add(SupMgmntBttn);
            Controls.Add(ProdMgmntBttn);
            Name = "Dashboard";
            Size = new Size(1080, 540);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ProdMgmntBttn;
        private Button SupMgmntBttn;
        private Button SalesMgmntBttn;
        private Label WelcomeLabel;
        private Button btnLogout;
    }
}