namespace InventoryManagementSystem
{
    partial class SalesAdd
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
            btnCancel = new Button();
            btnSaleAdd = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            saleIdLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button1_Click;
            // 
            // btnSaleAdd
            // 
            btnSaleAdd.Location = new Point(421, 213);
            btnSaleAdd.Name = "btnSaleAdd";
            btnSaleAdd.Size = new Size(75, 23);
            btnSaleAdd.TabIndex = 1;
            btnSaleAdd.Text = "Add Sale";
            btnSaleAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(371, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(371, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(371, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(371, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // saleIdLabel
            // 
            saleIdLabel.AutoSize = true;
            saleIdLabel.Location = new Point(285, 59);
            saleIdLabel.Name = "saleIdLabel";
            saleIdLabel.Size = new Size(42, 15);
            saleIdLabel.TabIndex = 6;
            saleIdLabel.Text = "Sale ID";
            saleIdLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Product ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 117);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 146);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Date";
            // 
            // SalesAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(saleIdLabel);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSaleAdd);
            Controls.Add(btnCancel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SalesAdd";
            Size = new Size(690, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSaleAdd;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label saleIdLabel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
