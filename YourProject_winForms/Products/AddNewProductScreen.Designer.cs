namespace YourProject_winForms
{
    partial class AddNewProductScreen
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProductScreen));
            this.labelNewProductDetailsTitle = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReceiptIMG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReceiptNum = new System.Windows.Forms.TextBox();
            this.labelReceiptNum = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelDateExpired = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxBusinessPhone = new System.Windows.Forms.TextBox();
            this.labelBusinessPhone = new System.Windows.Forms.Label();
            this.labelDatePurchased = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.labelBusinessName = new System.Windows.Forms.Label();
            this.labelProductId = new System.Windows.Forms.Label();
            this.dtpDatePurchased = new System.Windows.Forms.DateTimePicker();
            this.dtpDateExpired = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxReceiptImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblEditImageFile = new System.Windows.Forms.Label();
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.lblPDFFile = new System.Windows.Forms.Label();
            this.lblPDFView = new System.Windows.Forms.Label();
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axAcroPDF_viewer = new AxAcroPDFLib.AxAcroPDF();
            this.btnMaxPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiptImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNewProductDetailsTitle
            // 
            this.labelNewProductDetailsTitle.AutoSize = true;
            this.labelNewProductDetailsTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelNewProductDetailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewProductDetailsTitle.Location = new System.Drawing.Point(655, 20);
            this.labelNewProductDetailsTitle.Name = "labelNewProductDetailsTitle";
            this.labelNewProductDetailsTitle.Size = new System.Drawing.Size(304, 36);
            this.labelNewProductDetailsTitle.TabIndex = 32;
            this.labelNewProductDetailsTitle.Text = "New Product Details";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1282, 652);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 46);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(38, 652);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 46);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.InsertButton_Click_1);
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Location = new System.Drawing.Point(234, 431);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(303, 120);
            this.richTextBoxComments.TabIndex = 107;
            this.richTextBoxComments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 431);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 106;
            this.label1.Text = "Comments:";
            // 
            // textBoxReceiptIMG
            // 
            this.textBoxReceiptIMG.Location = new System.Drawing.Point(234, 366);
            this.textBoxReceiptIMG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiptIMG.MaxLength = 25;
            this.textBoxReceiptIMG.Name = "textBoxReceiptIMG";
            this.textBoxReceiptIMG.Size = new System.Drawing.Size(303, 22);
            this.textBoxReceiptIMG.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 104;
            this.label2.Text = "Receipt Image:";
            // 
            // textBoxReceiptNum
            // 
            this.textBoxReceiptNum.Location = new System.Drawing.Point(234, 172);
            this.textBoxReceiptNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiptNum.MaxLength = 25;
            this.textBoxReceiptNum.Name = "textBoxReceiptNum";
            this.textBoxReceiptNum.Size = new System.Drawing.Size(303, 22);
            this.textBoxReceiptNum.TabIndex = 103;
            // 
            // labelReceiptNum
            // 
            this.labelReceiptNum.AutoSize = true;
            this.labelReceiptNum.BackColor = System.Drawing.Color.Transparent;
            this.labelReceiptNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptNum.Location = new System.Drawing.Point(35, 172);
            this.labelReceiptNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceiptNum.Name = "labelReceiptNum";
            this.labelReceiptNum.Size = new System.Drawing.Size(134, 18);
            this.labelReceiptNum.TabIndex = 102;
            this.labelReceiptNum.Text = "Receipt Number:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(234, 141);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.MaxLength = 25;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(303, 22);
            this.textBoxProductName.TabIndex = 101;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.BackColor = System.Drawing.Color.Transparent;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(35, 142);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(121, 18);
            this.labelProductName.TabIndex = 100;
            this.labelProductName.Text = "Product Name:";
            // 
            // labelDateExpired
            // 
            this.labelDateExpired.AutoSize = true;
            this.labelDateExpired.BackColor = System.Drawing.Color.Transparent;
            this.labelDateExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateExpired.Location = new System.Drawing.Point(35, 337);
            this.labelDateExpired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateExpired.Name = "labelDateExpired";
            this.labelDateExpired.Size = new System.Drawing.Size(109, 18);
            this.labelDateExpired.TabIndex = 98;
            this.labelDateExpired.Text = "Date Expired:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(234, 272);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocation.MaxLength = 25;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(303, 22);
            this.textBoxLocation.TabIndex = 97;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(35, 273);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(78, 18);
            this.labelLocation.TabIndex = 96;
            this.labelLocation.Text = "Location:";
            // 
            // textBoxBusinessPhone
            // 
            this.textBoxBusinessPhone.Location = new System.Drawing.Point(234, 240);
            this.textBoxBusinessPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusinessPhone.MaxLength = 25;
            this.textBoxBusinessPhone.Name = "textBoxBusinessPhone";
            this.textBoxBusinessPhone.Size = new System.Drawing.Size(303, 22);
            this.textBoxBusinessPhone.TabIndex = 95;
            // 
            // labelBusinessPhone
            // 
            this.labelBusinessPhone.AutoSize = true;
            this.labelBusinessPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelBusinessPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessPhone.Location = new System.Drawing.Point(35, 241);
            this.labelBusinessPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBusinessPhone.Name = "labelBusinessPhone";
            this.labelBusinessPhone.Size = new System.Drawing.Size(135, 18);
            this.labelBusinessPhone.TabIndex = 94;
            this.labelBusinessPhone.Text = "Business Phone:";
            // 
            // labelDatePurchased
            // 
            this.labelDatePurchased.AutoSize = true;
            this.labelDatePurchased.BackColor = System.Drawing.Color.Transparent;
            this.labelDatePurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatePurchased.Location = new System.Drawing.Point(35, 305);
            this.labelDatePurchased.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDatePurchased.Name = "labelDatePurchased";
            this.labelDatePurchased.Size = new System.Drawing.Size(133, 18);
            this.labelDatePurchased.TabIndex = 92;
            this.labelDatePurchased.Text = "Date Purchased:";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(234, 208);
            this.txtBusinessName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusinessName.MaxLength = 25;
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(303, 22);
            this.txtBusinessName.TabIndex = 91;
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(234, 109);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductId.MaxLength = 25;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(66, 22);
            this.txtProductId.TabIndex = 90;
            // 
            // labelBusinessName
            // 
            this.labelBusinessName.AutoSize = true;
            this.labelBusinessName.BackColor = System.Drawing.Color.Transparent;
            this.labelBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusinessName.Location = new System.Drawing.Point(35, 209);
            this.labelBusinessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBusinessName.Name = "labelBusinessName";
            this.labelBusinessName.Size = new System.Drawing.Size(131, 18);
            this.labelBusinessName.TabIndex = 89;
            this.labelBusinessName.Text = "Business Name:";
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.BackColor = System.Drawing.Color.Transparent;
            this.labelProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductId.Location = new System.Drawing.Point(35, 110);
            this.labelProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(93, 18);
            this.labelProductId.TabIndex = 88;
            this.labelProductId.Text = "Product ID:";
            // 
            // dtpDatePurchased
            // 
            this.dtpDatePurchased.Location = new System.Drawing.Point(234, 302);
            this.dtpDatePurchased.Name = "dtpDatePurchased";
            this.dtpDatePurchased.Size = new System.Drawing.Size(303, 22);
            this.dtpDatePurchased.TabIndex = 108;
            // 
            // dtpDateExpired
            // 
            this.dtpDateExpired.Location = new System.Drawing.Point(234, 334);
            this.dtpDateExpired.Name = "dtpDateExpired";
            this.dtpDateExpired.Size = new System.Drawing.Size(303, 22);
            this.dtpDateExpired.TabIndex = 109;
            // 
            // pictureBoxReceiptImage
            // 
            this.pictureBoxReceiptImage.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxReceiptImage.Location = new System.Drawing.Point(638, 142);
            this.pictureBoxReceiptImage.Name = "pictureBoxReceiptImage";
            this.pictureBoxReceiptImage.Size = new System.Drawing.Size(349, 377);
            this.pictureBoxReceiptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReceiptImage.TabIndex = 110;
            this.pictureBoxReceiptImage.TabStop = false;
            this.pictureBoxReceiptImage.Click += new System.EventHandler(this.pictureBoxReceiptImage_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectImage.Location = new System.Drawing.Point(638, 525);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(349, 40);
            this.btnSelectImage.TabIndex = 111;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnUploadReceipt_Click);
            // 
            // lblEditImageFile
            // 
            this.lblEditImageFile.AutoSize = true;
            this.lblEditImageFile.BackColor = System.Drawing.Color.Transparent;
            this.lblEditImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditImageFile.Location = new System.Drawing.Point(719, 108);
            this.lblEditImageFile.Name = "lblEditImageFile";
            this.lblEditImageFile.Size = new System.Drawing.Size(195, 25);
            this.lblEditImageFile.TabIndex = 112;
            this.lblEditImageFile.Text = "Click Image to Zoom.";
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Location = new System.Drawing.Point(234, 400);
            this.txtPDFFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDFFile.MaxLength = 25;
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.Size = new System.Drawing.Size(303, 22);
            this.txtPDFFile.TabIndex = 114;
            // 
            // lblPDFFile
            // 
            this.lblPDFFile.AutoSize = true;
            this.lblPDFFile.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFFile.Location = new System.Drawing.Point(35, 401);
            this.lblPDFFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPDFFile.Name = "lblPDFFile";
            this.lblPDFFile.Size = new System.Drawing.Size(78, 18);
            this.lblPDFFile.TabIndex = 113;
            this.lblPDFFile.Text = "PDF File:";
            // 
            // lblPDFView
            // 
            this.lblPDFView.AutoSize = true;
            this.lblPDFView.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFView.Location = new System.Drawing.Point(1207, 108);
            this.lblPDFView.Name = "lblPDFView";
            this.lblPDFView.Size = new System.Drawing.Size(87, 25);
            this.lblPDFView.TabIndex = 116;
            this.lblPDFView.Text = "PDF File";
            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectPDF.Location = new System.Drawing.Point(1056, 525);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(366, 40);
            this.btnSelectPDF.TabIndex = 115;
            this.btnSelectPDF.Text = "Select PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.axAcroPDF_viewer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1053, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 377);
            this.flowLayoutPanel1.TabIndex = 117;
            // 
            // axAcroPDF_viewer
            // 
            this.axAcroPDF_viewer.Enabled = true;
            this.axAcroPDF_viewer.Location = new System.Drawing.Point(3, 3);
            this.axAcroPDF_viewer.Name = "axAcroPDF_viewer";
            this.axAcroPDF_viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_viewer.OcxState")));
            this.axAcroPDF_viewer.Size = new System.Drawing.Size(366, 374);
            this.axAcroPDF_viewer.TabIndex = 0;
            // 
            // btnMaxPDF
            // 
            this.btnMaxPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaxPDF.Location = new System.Drawing.Point(1056, 571);
            this.btnMaxPDF.Name = "btnMaxPDF";
            this.btnMaxPDF.Size = new System.Drawing.Size(366, 40);
            this.btnMaxPDF.TabIndex = 118;
            this.btnMaxPDF.Text = "Maximize PDF";
            this.btnMaxPDF.UseVisualStyleBackColor = true;
            this.btnMaxPDF.Click += new System.EventHandler(this.btnMaxPDF_Click);
            // 
            // AddNewProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1466, 728);
            this.Controls.Add(this.btnMaxPDF);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPDFView);
            this.Controls.Add(this.btnSelectPDF);
            this.Controls.Add(this.txtPDFFile);
            this.Controls.Add(this.lblPDFFile);
            this.Controls.Add(this.lblEditImageFile);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pictureBoxReceiptImage);
            this.Controls.Add(this.dtpDateExpired);
            this.Controls.Add(this.dtpDatePurchased);
            this.Controls.Add(this.richTextBoxComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReceiptIMG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReceiptNum);
            this.Controls.Add(this.labelReceiptNum);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelDateExpired);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxBusinessPhone);
            this.Controls.Add(this.labelBusinessPhone);
            this.Controls.Add(this.labelDatePurchased);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.labelBusinessName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.labelNewProductDetailsTitle);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.btnInsert);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1484, 775);
            this.MinimumSize = new System.Drawing.Size(1484, 775);
            this.Name = "AddNewProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddUpdateToolScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddNewProductScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiptImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label labelNewProductDetailsTitle;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReceiptIMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReceiptNum;
        private System.Windows.Forms.Label labelReceiptNum;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelDateExpired;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxBusinessPhone;
        private System.Windows.Forms.Label labelBusinessPhone;
        private System.Windows.Forms.Label labelDatePurchased;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label labelBusinessName;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.DateTimePicker dtpDatePurchased;
        private System.Windows.Forms.DateTimePicker dtpDateExpired;
        private System.Windows.Forms.PictureBox pictureBoxReceiptImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblEditImageFile;
        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Label lblPDFFile;
        private System.Windows.Forms.Label lblPDFView;
        private System.Windows.Forms.Button btnSelectPDF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_viewer;
        private System.Windows.Forms.Button btnMaxPDF;
    }
}