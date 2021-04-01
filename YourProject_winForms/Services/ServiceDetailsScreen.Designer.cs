namespace YourProject_winForms
{
    partial class ServiceDetailsScreen
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
            this.btnServiceList = new System.Windows.Forms.Button();
            this.btnAddNewService = new System.Windows.Forms.Button();
            this.EditServiceButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.labelToolsDetailsTitle = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServiceList
            // 
            this.btnServiceList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceList.Location = new System.Drawing.Point(1071, 81);
            this.btnServiceList.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceList.Name = "btnServiceList";
            this.btnServiceList.Size = new System.Drawing.Size(170, 32);
            this.btnServiceList.TabIndex = 19;
            this.btnServiceList.Text = "Search Services";
            this.btnServiceList.UseVisualStyleBackColor = true;
            this.btnServiceList.Click += new System.EventHandler(this.btnServiceList_Click);
            // 
            // btnAddNewService
            // 
            this.btnAddNewService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAddNewService.Location = new System.Drawing.Point(13, 121);
            this.btnAddNewService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewService.Name = "btnAddNewService";
            this.btnAddNewService.Size = new System.Drawing.Size(125, 54);
            this.btnAddNewService.TabIndex = 18;
            this.btnAddNewService.Text = "New Service";
            this.btnAddNewService.UseVisualStyleBackColor = true;
            this.btnAddNewService.Click += new System.EventHandler(this.btnAddNewService_Click);
            // 
            // EditServiceButton
            // 
            this.EditServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.EditServiceButton.Location = new System.Drawing.Point(13, 196);
            this.EditServiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditServiceButton.Name = "EditServiceButton";
            this.EditServiceButton.Size = new System.Drawing.Size(125, 54);
            this.EditServiceButton.TabIndex = 17;
            this.EditServiceButton.Text = "Edit Service";
            this.EditServiceButton.UseVisualStyleBackColor = true;
            this.EditServiceButton.Click += new System.EventHandler(this.EditServiceButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Location = new System.Drawing.Point(13, 533);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(125, 54);
            this.HomeButton.TabIndex = 15;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // labelToolsDetailsTitle
            // 
            this.labelToolsDetailsTitle.AutoSize = true;
            this.labelToolsDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelToolsDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToolsDetailsTitle.Location = new System.Drawing.Point(519, 9);
            this.labelToolsDetailsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToolsDetailsTitle.Name = "labelToolsDetailsTitle";
            this.labelToolsDetailsTitle.Size = new System.Drawing.Size(227, 36);
            this.labelToolsDetailsTitle.TabIndex = 14;
            this.labelToolsDetailsTitle.Text = "Service Details";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.GridColor = System.Drawing.Color.Blue;
            this.dgvServices.Location = new System.Drawing.Point(145, 121);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServices.RowTemplate.DividerHeight = 4;
            this.dgvServices.RowTemplate.Height = 40;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(1096, 466);
            this.dgvServices.TabIndex = 13;
            this.dgvServices.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(13, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 52);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Double Click an Entry to View Details";
            // 
            // ServiceDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 610);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnServiceList);
            this.Controls.Add(this.btnAddNewService);
            this.Controls.Add(this.EditServiceButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.labelToolsDetailsTitle);
            this.Controls.Add(this.dgvServices);
            this.Name = "ServiceDetailsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServiceDetailsScreen";
            this.Load += new System.EventHandler(this.ServiceDetailsScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ServiceDetailsScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServiceList;
        private System.Windows.Forms.Button btnAddNewService;
        private System.Windows.Forms.Button EditServiceButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label labelToolsDetailsTitle;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}