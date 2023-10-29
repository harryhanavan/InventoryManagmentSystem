namespace InventoryManagementSystem
{
    partial class SalesAddForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            btnSaleAdd = new Button();
            txtProductID = new TextBox();
            txtQuantity = new TextBox();
            txtCustomerDetails = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(286, 289);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSaleAdd
            // 
            btnSaleAdd.Location = new Point(408, 289);
            btnSaleAdd.Name = "btnSaleAdd";
            btnSaleAdd.Size = new Size(94, 29);
            btnSaleAdd.TabIndex = 1;
            btnSaleAdd.Text = "Add Sale";
            btnSaleAdd.UseVisualStyleBackColor = true;
            btnSaleAdd.Click += btnSaleAdd_Click;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(389, 87);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 2;
            txtProductID.TextChanged += textBox1_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(389, 140);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 3;
            // 
            // txtCustomerDetails
            // 
            txtCustomerDetails.Location = new Point(389, 191);
            txtCustomerDetails.Name = "txtCustomerDetails";
            txtCustomerDetails.Size = new Size(125, 27);
            txtCustomerDetails.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 90);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 5;
            label1.Text = "Product ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 143);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 194);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 7;
            label3.Text = "Customer Details";
            // 
            // SalesAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomerDetails);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductID);
            Controls.Add(btnSaleAdd);
            Controls.Add(btnBack);
            Name = "SalesAddForm";
            Size = new Size(789, 343);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSaleAdd;
        private TextBox txtProductID;
        private TextBox txtQuantity;
        private TextBox txtCustomerDetails;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
