namespace YourProject_winForms
{
    partial class SearchProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchButton = new System.Windows.Forms.Button();
            this.lblServiceProduct = new System.Windows.Forms.Label();
            this.txtProductSearch = new System.Windows.Forms.TextBox();
            this.ProductListDisplay = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.SearchButton.Location = new System.Drawing.Point(908, 135);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 33);
            this.SearchButton.TabIndex = 25;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lblServiceProduct
            // 
            this.lblServiceProduct.AutoSize = true;
            this.lblServiceProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceProduct.Location = new System.Drawing.Point(419, 13);
            this.lblServiceProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceProduct.Name = "lblServiceProduct";
            this.lblServiceProduct.Size = new System.Drawing.Size(235, 36);
            this.lblServiceProduct.TabIndex = 23;
            this.lblServiceProduct.Text = "Product Search";
            // 
            // txtProductSearch
            // 
            this.txtProductSearch.Location = new System.Drawing.Point(17, 141);
            this.txtProductSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductSearch.MaxLength = 25;
            this.txtProductSearch.Name = "txtProductSearch";
            this.txtProductSearch.Size = new System.Drawing.Size(884, 22);
            this.txtProductSearch.TabIndex = 22;
            this.txtProductSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductSearch_KeyPress);
            // 
            // ProductListDisplay
            // 
            this.ProductListDisplay.AllowUserToAddRows = false;
            this.ProductListDisplay.AllowUserToDeleteRows = false;
            this.ProductListDisplay.AllowUserToResizeColumns = false;
            this.ProductListDisplay.AllowUserToResizeRows = false;
            this.ProductListDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductListDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductListDisplay.BackgroundColor = System.Drawing.Color.White;
            this.ProductListDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListDisplay.GridColor = System.Drawing.Color.Blue;
            this.ProductListDisplay.Location = new System.Drawing.Point(16, 173);
            this.ProductListDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.ProductListDisplay.Name = "ProductListDisplay";
            this.ProductListDisplay.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductListDisplay.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductListDisplay.RowTemplate.DividerHeight = 4;
            this.ProductListDisplay.RowTemplate.Height = 40;
            this.ProductListDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductListDisplay.Size = new System.Drawing.Size(1035, 313);
            this.ProductListDisplay.TabIndex = 24;
            this.ProductListDisplay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListDisplay_CellContentDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(848, 493);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter Product Name to Search";
            // 
            // SearchProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.lblServiceProduct);
            this.Controls.Add(this.txtProductSearch);
            this.Controls.Add(this.ProductListDisplay);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.Name = "SearchProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchProducts";
            this.Load += new System.EventHandler(this.SearchProducts_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchProducts_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label lblServiceProduct;
        private System.Windows.Forms.TextBox txtProductSearch;
        private System.Windows.Forms.DataGridView ProductListDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}