namespace InventoryManagementSystem
{
    partial class NewSale
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
            productComboBox = new ComboBox();
            quantityTextBox = new TextBox();
            cartListBox = new ListBox();
            btnAddToCart = new Button();
            btnBuy = new Button();
            searchText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSearch = new Button();
            customerDetailsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // productComboBox
            // 
            productComboBox.FormattingEnabled = true;
            productComboBox.Location = new Point(201, 219);
            productComboBox.Name = "productComboBox";
            productComboBox.Size = new Size(211, 23);
            productComboBox.TabIndex = 0;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(418, 219);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(31, 23);
            quantityTextBox.TabIndex = 1;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(640, 201);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(352, 154);
            cartListBox.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(268, 248);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(121, 23);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(917, 361);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(75, 23);
            btnBuy.TabIndex = 4;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // searchText
            // 
            searchText.Location = new Point(268, 155);
            searchText.Name = "searchText";
            searchText.Size = new Size(100, 23);
            searchText.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 201);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 6;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 158);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 7;
            label2.Text = "Search for Product:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(374, 154);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // customerDetailsTextBox
            // 
            customerDetailsTextBox.Location = new Point(186, 297);
            customerDetailsTextBox.Multiline = true;
            customerDetailsTextBox.Name = "customerDetailsTextBox";
            customerDetailsTextBox.Size = new Size(277, 90);
            customerDetailsTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 279);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 10;
            label3.Text = "Customer Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 183);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 11;
            label4.Text = "Cart";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 12;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // NewSale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(customerDetailsTextBox);
            Controls.Add(btnSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchText);
            Controls.Add(btnBuy);
            Controls.Add(btnAddToCart);
            Controls.Add(cartListBox);
            Controls.Add(quantityTextBox);
            Controls.Add(productComboBox);
            Name = "NewSale";
            Size = new Size(1080, 540);
            Load += NewSale_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox productComboBox;
        private TextBox quantityTextBox;
        private ListBox cartListBox;
        private Button btnAddToCart;
        private Button btnBuy;
        private TextBox searchText;
        private Label label1;
        private Label label2;
        private Button btnSearch;
        private TextBox customerDetailsTextBox;
        private Label label3;
        private Label label4;
        private Button btnBack;
    }
}
