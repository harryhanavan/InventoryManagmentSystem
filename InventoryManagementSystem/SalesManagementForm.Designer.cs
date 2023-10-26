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
            btnSalesAdd = new Button();
            btnSalesView = new Button();
            bntOrderAdd = new Button();
            btnOrderView = new Button();
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
            // btnSalesAdd
            // 
            btnSalesAdd.Location = new Point(487, 257);
            btnSalesAdd.Name = "btnSalesAdd";
            btnSalesAdd.Size = new Size(94, 29);
            btnSalesAdd.TabIndex = 1;
            btnSalesAdd.Text = "Add Sale";
            btnSalesAdd.UseVisualStyleBackColor = true;
            btnSalesAdd.Click += salesAdd_Click;
            // 
            // btnSalesView
            // 
            btnSalesView.Location = new Point(132, 257);
            btnSalesView.Name = "btnSalesView";
            btnSalesView.Size = new Size(94, 29);
            btnSalesView.TabIndex = 2;
            btnSalesView.Text = "View Sales";
            btnSalesView.UseVisualStyleBackColor = true;
            btnSalesView.Click += button2_Click;
            // 
            // bntOrderAdd
            // 
            bntOrderAdd.Location = new Point(648, 257);
            bntOrderAdd.Name = "bntOrderAdd";
            bntOrderAdd.Size = new Size(94, 29);
            bntOrderAdd.TabIndex = 3;
            bntOrderAdd.Text = "Add Order";
            bntOrderAdd.UseVisualStyleBackColor = true;
            bntOrderAdd.Click += button3_Click;
            // 
            // btnOrderView
            // 
            btnOrderView.Location = new Point(292, 257);
            btnOrderView.Name = "btnOrderView";
            btnOrderView.Size = new Size(106, 29);
            btnOrderView.TabIndex = 4;
            btnOrderView.Text = "View Orders";
            btnOrderView.UseVisualStyleBackColor = true;
            btnOrderView.Click += button4_Click;
            // 
            // SalesManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnOrderView);
            Controls.Add(bntOrderAdd);
            Controls.Add(btnSalesView);
            Controls.Add(btnSalesAdd);
            Controls.Add(btnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesManagementForm";
            Size = new Size(914, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private Button btnSalesAdd;
        private Button btnSalesView;
        private Button bntOrderAdd;
        private Button btnOrderView;
    }
}