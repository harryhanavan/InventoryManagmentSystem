namespace InventoryManagementSystem
{
    partial class SaleView
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
            dataGridViewSales = new DataGridView();
            btnBack = new Button();
            searchTextBox = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            listBoxSaleItems = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(83, 181);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowTemplate.Height = 25;
            dataGridViewSales.Size = new Size(472, 218);
            dataGridViewSales.TabIndex = 10;
            dataGridViewSales.CellClick += dataGridViewSales_CellClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "< Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(164, 152);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(310, 23);
            searchTextBox.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(480, 152);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(83, 152);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // listBoxSaleItems
            // 
            listBoxSaleItems.FormattingEnabled = true;
            listBoxSaleItems.ItemHeight = 15;
            listBoxSaleItems.Location = new Point(616, 181);
            listBoxSaleItems.Name = "listBoxSaleItems";
            listBoxSaleItems.Size = new Size(365, 214);
            listBoxSaleItems.TabIndex = 11;
            // 
            // SaleView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxSaleItems);
            Controls.Add(dataGridViewSales);
            Controls.Add(btnBack);
            Controls.Add(searchTextBox);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Name = "SaleView";
            Size = new Size(1080, 540);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSales;
        private Button btnBack;
        private TextBox searchTextBox;
        private Button btnSearch;
        private Button btnRefresh;
        private ListBox listBoxSaleItems;
    }
}
