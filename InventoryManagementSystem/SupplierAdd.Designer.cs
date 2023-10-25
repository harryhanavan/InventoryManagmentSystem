namespace InventoryManagementSystem
{
    partial class SupplierAdd
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
            lblSupplierCity = new Label();
            txtSupplierCity = new TextBox();
            btnCancel = new Button();
            btnAddSupplier = new Button();
            cmbCategory = new ComboBox();
            lblSupplierAddress = new Label();
            lblSupplierCategory = new Label();
            lblSupplierContact = new Label();
            lblSupplierEmail = new Label();
            lblSupplierName = new Label();
            txtSupplierAddress = new TextBox();
            txtSupplierID = new TextBox();
            txtSupplierEmail = new TextBox();
            txtSupplierContact = new TextBox();
            txtSupplierName = new TextBox();
            lblSupplierID = new Label();
            SuspendLayout();
            // 
            // lblSupplierCity
            // 
            lblSupplierCity.AutoSize = true;
            lblSupplierCity.Location = new Point(283, 197);
            lblSupplierCity.Name = "lblSupplierCity";
            lblSupplierCity.Size = new Size(28, 15);
            lblSupplierCity.TabIndex = 58;
            lblSupplierCity.Text = "City";
            // 
            // txtSupplierCity
            // 
            txtSupplierCity.Location = new Point(332, 189);
            txtSupplierCity.Name = "txtSupplierCity";
            txtSupplierCity.Size = new Size(121, 23);
            txtSupplierCity.TabIndex = 57;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(295, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 23);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(396, 218);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(95, 23);
            btnAddSupplier.TabIndex = 55;
            btnAddSupplier.Text = "Add Supplier";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(332, 131);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 54;
            // 
            // lblSupplierAddress
            // 
            lblSupplierAddress.AutoSize = true;
            lblSupplierAddress.Location = new Point(262, 168);
            lblSupplierAddress.Name = "lblSupplierAddress";
            lblSupplierAddress.Size = new Size(49, 15);
            lblSupplierAddress.TabIndex = 53;
            lblSupplierAddress.Text = "Address";
            // 
            // lblSupplierCategory
            // 
            lblSupplierCategory.AutoSize = true;
            lblSupplierCategory.Location = new Point(256, 139);
            lblSupplierCategory.Name = "lblSupplierCategory";
            lblSupplierCategory.Size = new Size(55, 15);
            lblSupplierCategory.TabIndex = 52;
            lblSupplierCategory.Text = "Category";
            // 
            // lblSupplierContact
            // 
            lblSupplierContact.AutoSize = true;
            lblSupplierContact.Location = new Point(240, 110);
            lblSupplierContact.Name = "lblSupplierContact";
            lblSupplierContact.Size = new Size(71, 15);
            lblSupplierContact.TabIndex = 51;
            lblSupplierContact.Text = "Contact No.";
            // 
            // lblSupplierEmail
            // 
            lblSupplierEmail.AutoSize = true;
            lblSupplierEmail.Location = new Point(275, 81);
            lblSupplierEmail.Name = "lblSupplierEmail";
            lblSupplierEmail.Size = new Size(36, 15);
            lblSupplierEmail.TabIndex = 50;
            lblSupplierEmail.Text = "Email";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(272, 52);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(39, 15);
            lblSupplierName.TabIndex = 49;
            lblSupplierName.Text = "Name";
            // 
            // txtSupplierAddress
            // 
            txtSupplierAddress.Location = new Point(332, 160);
            txtSupplierAddress.Name = "txtSupplierAddress";
            txtSupplierAddress.Size = new Size(121, 23);
            txtSupplierAddress.TabIndex = 48;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(332, 15);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(121, 23);
            txtSupplierID.TabIndex = 47;
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Location = new Point(332, 73);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(121, 23);
            txtSupplierEmail.TabIndex = 46;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Location = new Point(332, 102);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(121, 23);
            txtSupplierContact.TabIndex = 45;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(332, 44);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(121, 23);
            txtSupplierName.TabIndex = 44;
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Location = new Point(247, 23);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(64, 15);
            lblSupplierID.TabIndex = 43;
            lblSupplierID.Text = "Supplier ID";
            // 
            // SupplierAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSupplierCity);
            Controls.Add(txtSupplierCity);
            Controls.Add(btnCancel);
            Controls.Add(btnAddSupplier);
            Controls.Add(cmbCategory);
            Controls.Add(lblSupplierAddress);
            Controls.Add(lblSupplierCategory);
            Controls.Add(lblSupplierContact);
            Controls.Add(lblSupplierEmail);
            Controls.Add(lblSupplierName);
            Controls.Add(txtSupplierAddress);
            Controls.Add(txtSupplierID);
            Controls.Add(txtSupplierEmail);
            Controls.Add(txtSupplierContact);
            Controls.Add(txtSupplierName);
            Controls.Add(lblSupplierID);
            Name = "SupplierAdd";
            Size = new Size(690, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSupplierCity;
        private TextBox txtSupplierCity;
        private Button btnCancel;
        private Button btnAddSupplier;
        private ComboBox cmbCategory;
        private Label lblSupplierAddress;
        private Label lblSupplierCategory;
        private Label lblSupplierContact;
        private Label lblSupplierEmail;
        private Label lblSupplierName;
        private TextBox txtSupplierAddress;
        private TextBox txtSupplierID;
        private TextBox txtSupplierEmail;
        private TextBox txtSupplierContact;
        private TextBox txtSupplierName;
        private Label lblSupplierID;
    }
}
