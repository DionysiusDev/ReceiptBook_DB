namespace YourProject_winForms
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.labelEditToolTitle = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelBusinessName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.labelDatePurchased = new System.Windows.Forms.Label();
            this.labelBusinessPhone = new System.Windows.Forms.Label();
            this.textBoxBusinessPhone = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelDateExpired = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelReceiptNum = new System.Windows.Forms.Label();
            this.textBoxReceiptNum = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReceiptIMG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.pictureBoxReceipt = new System.Windows.Forms.PictureBox();
            this.dtpDatePurchased = new System.Windows.Forms.DateTimePicker();
            this.dtpDateExpired = new System.Windows.Forms.DateTimePicker();
            this.lblEditImageFile = new System.Windows.Forms.Label();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.btnUpdateImg = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axAcroPDF_viewer = new AxAcroPDFLib.AxAcroPDF();
            this.lblPDFView = new System.Windows.Forms.Label();
            this.btnUpdatePDF = new System.Windows.Forms.Button();
            this.DeletePdf = new System.Windows.Forms.Button();
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.lblPDFFile = new System.Windows.Forms.Label();
            this.btnBigPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceipt)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditToolTitle
            // 
            this.labelEditToolTitle.AutoSize = true;
            this.labelEditToolTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelEditToolTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditToolTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelEditToolTitle.Location = new System.Drawing.Point(648, 19);
            this.labelEditToolTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEditToolTitle.Name = "labelEditToolTitle";
            this.labelEditToolTitle.Size = new System.Drawing.Size(297, 36);
            this.labelEditToolTitle.TabIndex = 61;
            this.labelEditToolTitle.Text = "Edit Product Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(38, 652);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 46);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateButton_Click);
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
            this.labelProductId.TabIndex = 57;
            this.labelProductId.Text = "Product ID:";
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
            this.labelBusinessName.TabIndex = 58;
            this.labelBusinessName.Text = "Business Name:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(234, 109);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductId.MaxLength = 25;
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(66, 22);
            this.txtProductId.TabIndex = 59;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(234, 208);
            this.txtBusinessName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusinessName.MaxLength = 25;
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(303, 22);
            this.txtBusinessName.TabIndex = 60;
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
            this.labelDatePurchased.TabIndex = 62;
            this.labelDatePurchased.Text = "Date Purchased:";
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
            this.labelBusinessPhone.TabIndex = 64;
            this.labelBusinessPhone.Text = "Business Phone:";
            // 
            // textBoxBusinessPhone
            // 
            this.textBoxBusinessPhone.Location = new System.Drawing.Point(234, 240);
            this.textBoxBusinessPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBusinessPhone.MaxLength = 25;
            this.textBoxBusinessPhone.Name = "textBoxBusinessPhone";
            this.textBoxBusinessPhone.Size = new System.Drawing.Size(303, 22);
            this.textBoxBusinessPhone.TabIndex = 65;
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
            this.labelLocation.TabIndex = 66;
            this.labelLocation.Text = "Location:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(234, 272);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLocation.MaxLength = 25;
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(303, 22);
            this.textBoxLocation.TabIndex = 67;
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
            this.labelDateExpired.TabIndex = 72;
            this.labelDateExpired.Text = "Date Expired:";
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
            this.labelProductName.TabIndex = 74;
            this.labelProductName.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(234, 141);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.MaxLength = 25;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(303, 22);
            this.textBoxProductName.TabIndex = 75;
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
            this.labelReceiptNum.TabIndex = 76;
            this.labelReceiptNum.Text = "Receipt Number:";
            // 
            // textBoxReceiptNum
            // 
            this.textBoxReceiptNum.Location = new System.Drawing.Point(234, 172);
            this.textBoxReceiptNum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiptNum.MaxLength = 25;
            this.textBoxReceiptNum.Name = "textBoxReceiptNum";
            this.textBoxReceiptNum.Size = new System.Drawing.Size(303, 22);
            this.textBoxReceiptNum.TabIndex = 77;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1282, 652);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 46);
            this.BackButton.TabIndex = 82;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Comments:";
            // 
            // textBoxReceiptIMG
            // 
            this.textBoxReceiptIMG.Location = new System.Drawing.Point(234, 366);
            this.textBoxReceiptIMG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiptIMG.MaxLength = 25;
            this.textBoxReceiptIMG.Name = "textBoxReceiptIMG";
            this.textBoxReceiptIMG.Size = new System.Drawing.Size(303, 22);
            this.textBoxReceiptIMG.TabIndex = 85;
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
            this.label2.TabIndex = 84;
            this.label2.Text = "Receipt Image:";
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Location = new System.Drawing.Point(234, 435);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(303, 120);
            this.richTextBoxComments.TabIndex = 87;
            this.richTextBoxComments.Text = "";
            // 
            // pictureBoxReceipt
            // 
            this.pictureBoxReceipt.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxReceipt.Location = new System.Drawing.Point(638, 142);
            this.pictureBoxReceipt.Name = "pictureBoxReceipt";
            this.pictureBoxReceipt.Size = new System.Drawing.Size(349, 377);
            this.pictureBoxReceipt.TabIndex = 89;
            this.pictureBoxReceipt.TabStop = false;
            this.pictureBoxReceipt.Click += new System.EventHandler(this.pictureBoxReceipt_Click);
            // 
            // dtpDatePurchased
            // 
            this.dtpDatePurchased.Location = new System.Drawing.Point(234, 302);
            this.dtpDatePurchased.Name = "dtpDatePurchased";
            this.dtpDatePurchased.Size = new System.Drawing.Size(303, 22);
            this.dtpDatePurchased.TabIndex = 90;
            // 
            // dtpDateExpired
            // 
            this.dtpDateExpired.Location = new System.Drawing.Point(234, 333);
            this.dtpDateExpired.Name = "dtpDateExpired";
            this.dtpDateExpired.Size = new System.Drawing.Size(303, 22);
            this.dtpDateExpired.TabIndex = 91;
            // 
            // lblEditImageFile
            // 
            this.lblEditImageFile.AutoSize = true;
            this.lblEditImageFile.BackColor = System.Drawing.Color.Transparent;
            this.lblEditImageFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditImageFile.Location = new System.Drawing.Point(719, 108);
            this.lblEditImageFile.Name = "lblEditImageFile";
            this.lblEditImageFile.Size = new System.Drawing.Size(195, 25);
            this.lblEditImageFile.TabIndex = 92;
            this.lblEditImageFile.Text = "Click Image to Zoom.";
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteImage.Location = new System.Drawing.Point(823, 525);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(164, 40);
            this.btnDeleteImage.TabIndex = 93;
            this.btnDeleteImage.Text = "Delete Image";
            this.btnDeleteImage.UseVisualStyleBackColor = true;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnUpdateImg
            // 
            this.btnUpdateImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateImg.Location = new System.Drawing.Point(638, 525);
            this.btnUpdateImg.Name = "btnUpdateImg";
            this.btnUpdateImg.Size = new System.Drawing.Size(164, 40);
            this.btnUpdateImg.TabIndex = 94;
            this.btnUpdateImg.Text = "Update Image";
            this.btnUpdateImg.UseVisualStyleBackColor = true;
            this.btnUpdateImg.Click += new System.EventHandler(this.btnUpdateImg_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.axAcroPDF_viewer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1048, 141);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 377);
            this.flowLayoutPanel1.TabIndex = 120;
            // 
            // axAcroPDF_viewer
            // 
            this.axAcroPDF_viewer.Enabled = true;
            this.axAcroPDF_viewer.Location = new System.Drawing.Point(3, 3);
            this.axAcroPDF_viewer.Name = "axAcroPDF_viewer";
            this.axAcroPDF_viewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF_viewer.OcxState")));
            this.axAcroPDF_viewer.Size = new System.Drawing.Size(371, 374);
            this.axAcroPDF_viewer.TabIndex = 0;
            // 
            // lblPDFView
            // 
            this.lblPDFView.AutoSize = true;
            this.lblPDFView.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFView.Location = new System.Drawing.Point(1154, 107);
            this.lblPDFView.Name = "lblPDFView";
            this.lblPDFView.Size = new System.Drawing.Size(180, 25);
            this.lblPDFView.TabIndex = 119;
            this.lblPDFView.Text = "Click PDF to Zoom.";
            // 
            // btnUpdatePDF
            // 
            this.btnUpdatePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePDF.Location = new System.Drawing.Point(1051, 524);
            this.btnUpdatePDF.Name = "btnUpdatePDF";
            this.btnUpdatePDF.Size = new System.Drawing.Size(164, 39);
            this.btnUpdatePDF.TabIndex = 118;
            this.btnUpdatePDF.Text = "Update PDF";
            this.btnUpdatePDF.UseVisualStyleBackColor = true;
            this.btnUpdatePDF.Click += new System.EventHandler(this.btnUpdatePDF_Click);
            // 
            // DeletePdf
            // 
            this.DeletePdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeletePdf.Location = new System.Drawing.Point(1258, 524);
            this.DeletePdf.Name = "DeletePdf";
            this.DeletePdf.Size = new System.Drawing.Size(164, 40);
            this.DeletePdf.TabIndex = 121;
            this.DeletePdf.Text = "Delete PDF";
            this.DeletePdf.UseVisualStyleBackColor = true;
            this.DeletePdf.Click += new System.EventHandler(this.DeletePdf_Click);
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Location = new System.Drawing.Point(234, 401);
            this.txtPDFFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDFFile.MaxLength = 25;
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.Size = new System.Drawing.Size(303, 22);
            this.txtPDFFile.TabIndex = 123;
            // 
            // lblPDFFile
            // 
            this.lblPDFFile.AutoSize = true;
            this.lblPDFFile.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFFile.Location = new System.Drawing.Point(35, 402);
            this.lblPDFFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPDFFile.Name = "lblPDFFile";
            this.lblPDFFile.Size = new System.Drawing.Size(78, 18);
            this.lblPDFFile.TabIndex = 122;
            this.lblPDFFile.Text = "PDF File:";
            // 
            // btnBigPDF
            // 
            this.btnBigPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBigPDF.Location = new System.Drawing.Point(1051, 569);
            this.btnBigPDF.Name = "btnBigPDF";
            this.btnBigPDF.Size = new System.Drawing.Size(371, 39);
            this.btnBigPDF.TabIndex = 124;
            this.btnBigPDF.Text = "View Fullsize PDF";
            this.btnBigPDF.UseVisualStyleBackColor = true;
            this.btnBigPDF.Click += new System.EventHandler(this.btnBigPDF_Click);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 736);
            this.Controls.Add(this.btnBigPDF);
            this.Controls.Add(this.txtPDFFile);
            this.Controls.Add(this.lblPDFFile);
            this.Controls.Add(this.DeletePdf);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPDFView);
            this.Controls.Add(this.btnUpdatePDF);
            this.Controls.Add(this.btnUpdateImg);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.lblEditImageFile);
            this.Controls.Add(this.dtpDateExpired);
            this.Controls.Add(this.dtpDatePurchased);
            this.Controls.Add(this.pictureBoxReceipt);
            this.Controls.Add(this.richTextBoxComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReceiptIMG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackButton);
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
            this.Controls.Add(this.labelEditToolTitle);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.labelBusinessName);
            this.Controls.Add(this.labelProductId);
            this.Controls.Add(this.btnUpdate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1488, 783);
            this.MinimumSize = new System.Drawing.Size(1488, 783);
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product Details";
            this.Load += new System.EventHandler(this.UpdateProductScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateProductScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceipt)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEditToolTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labelProductId;
        private System.Windows.Forms.Label labelBusinessName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.Label labelDatePurchased;
        private System.Windows.Forms.Label labelBusinessPhone;
        private System.Windows.Forms.TextBox textBoxBusinessPhone;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelDateExpired;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelReceiptNum;
        private System.Windows.Forms.TextBox textBoxReceiptNum;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReceiptIMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.PictureBox pictureBoxReceipt;
        private System.Windows.Forms.DateTimePicker dtpDatePurchased;
        private System.Windows.Forms.DateTimePicker dtpDateExpired;
        private System.Windows.Forms.Label lblEditImageFile;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.Button btnUpdateImg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_viewer;
        private System.Windows.Forms.Label lblPDFView;
        private System.Windows.Forms.Button btnUpdatePDF;
        private System.Windows.Forms.Button DeletePdf;
        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Label lblPDFFile;
        private System.Windows.Forms.Button btnBigPDF;
    }
}