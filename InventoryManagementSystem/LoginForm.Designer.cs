namespace InventoryManagementSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameEntry = new TextBox();
            PasswordEntry = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            LoginButton = new Button();
            LoginCancelButton = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // UsernameEntry
            // 
            UsernameEntry.Location = new Point(470, 216);
            UsernameEntry.Multiline = true;
            UsernameEntry.Name = "UsernameEntry";
            UsernameEntry.Size = new Size(100, 23);
            UsernameEntry.TabIndex = 0;
            UsernameEntry.TextChanged += UsernameEntry_TextChanged;
            // 
            // PasswordEntry
            // 
            PasswordEntry.Location = new Point(470, 245);
            PasswordEntry.Name = "PasswordEntry";
            PasswordEntry.PasswordChar = '*';
            PasswordEntry.Size = new Size(100, 23);
            PasswordEntry.TabIndex = 1;
            PasswordEntry.TextChanged += PasswordEntry_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(404, 219);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(407, 248);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(440, 274);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.Location = new Point(521, 274);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(75, 23);
            LoginCancelButton.TabIndex = 5;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = true;
            LoginCancelButton.Click += LoginCancelButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 169);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 6;
            label3.Text = "Inventory Management System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 198);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 7;
            label4.Text = "User Login:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LoginCancelButton);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordEntry);
            Controls.Add(UsernameEntry);
            Name = "LoginForm";
            Size = new Size(1080, 540);
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameEntry;
        private TextBox PasswordEntry;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button LoginButton;
        private Button LoginCancelButton;
        private Label label3;
        private Label label4;
    }
}