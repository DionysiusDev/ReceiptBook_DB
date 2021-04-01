namespace YourProject_winForms
{
    partial class SearchServices
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
            this.lblServiceSearch = new System.Windows.Forms.Label();
            this.txtServiceSearch = new System.Windows.Forms.TextBox();
            this.ServiceListDisplay = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.SearchButton.Location = new System.Drawing.Point(908, 135);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(143, 33);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // lblServiceSearch
            // 
            this.lblServiceSearch.AutoSize = true;
            this.lblServiceSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceSearch.Location = new System.Drawing.Point(419, 13);
            this.lblServiceSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceSearch.Name = "lblServiceSearch";
            this.lblServiceSearch.Size = new System.Drawing.Size(230, 36);
            this.lblServiceSearch.TabIndex = 17;
            this.lblServiceSearch.Text = "Service Search";
            // 
            // txtServiceSearch
            // 
            this.txtServiceSearch.Location = new System.Drawing.Point(17, 141);
            this.txtServiceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceSearch.MaxLength = 25;
            this.txtServiceSearch.Name = "txtServiceSearch";
            this.txtServiceSearch.Size = new System.Drawing.Size(884, 22);
            this.txtServiceSearch.TabIndex = 16;
            this.txtServiceSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceSearch_KeyPress);
            // 
            // ServiceListDisplay
            // 
            this.ServiceListDisplay.AllowUserToAddRows = false;
            this.ServiceListDisplay.AllowUserToDeleteRows = false;
            this.ServiceListDisplay.AllowUserToResizeColumns = false;
            this.ServiceListDisplay.AllowUserToResizeRows = false;
            this.ServiceListDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceListDisplay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ServiceListDisplay.BackgroundColor = System.Drawing.Color.White;
            this.ServiceListDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceListDisplay.GridColor = System.Drawing.Color.Blue;
            this.ServiceListDisplay.Location = new System.Drawing.Point(16, 173);
            this.ServiceListDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.ServiceListDisplay.Name = "ServiceListDisplay";
            this.ServiceListDisplay.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceListDisplay.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ServiceListDisplay.RowTemplate.DividerHeight = 4;
            this.ServiceListDisplay.RowTemplate.Height = 40;
            this.ServiceListDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceListDisplay.Size = new System.Drawing.Size(1035, 313);
            this.ServiceListDisplay.TabIndex = 18;
            this.ServiceListDisplay.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceListDisplay_CellContentDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(848, 493);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 48);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Enter Product Name to Search";
            // 
            // SearchServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.lblServiceSearch);
            this.Controls.Add(this.txtServiceSearch);
            this.Controls.Add(this.ServiceListDisplay);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.Name = "SearchServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchServices";
            this.Load += new System.EventHandler(this.SearchServices_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchServices_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceListDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label lblServiceSearch;
        private System.Windows.Forms.TextBox txtServiceSearch;
        private System.Windows.Forms.DataGridView ServiceListDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}