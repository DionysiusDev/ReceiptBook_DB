namespace YourProject_winForms
{
    partial class AddNewService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewService));
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.pictureBoxReceipt = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBoxBusinessName = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dtpDateExpired = new System.Windows.Forms.DateTimePicker();
            this.dtpDateServiceDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReceiptIMG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.labelDateExpired = new System.Windows.Forms.Label();
            this.textContactPhone = new System.Windows.Forms.TextBox();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.labelAddServiceTitle = new System.Windows.Forms.Label();
            this.txtBoxContactName = new System.Windows.Forms.TextBox();
            this.txtServiceId = new System.Windows.Forms.TextBox();
            this.lblContactlName = new System.Windows.Forms.Label();
            this.labelServiceId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaxPDF = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axAcroPDF_viewer = new AxAcroPDFLib.AxAcroPDF();
            this.lblPDFView = new System.Windows.Forms.Label();
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.txtPDFFile = new System.Windows.Forms.TextBox();
            this.lblPDFFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceipt)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectImage.Location = new System.Drawing.Point(638, 525);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(349, 40);
            this.btnSelectImage.TabIndex = 154;
            this.btnSelectImage.Text = "Select Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pictureBoxReceipt
            // 
            this.pictureBoxReceipt.BackColor = System.Drawing.Color.Snow;
            this.pictureBoxReceipt.Location = new System.Drawing.Point(638, 142);
            this.pictureBoxReceipt.Name = "pictureBoxReceipt";
            this.pictureBoxReceipt.Size = new System.Drawing.Size(349, 377);
            this.pictureBoxReceipt.TabIndex = 152;
            this.pictureBoxReceipt.TabStop = false;
            this.pictureBoxReceipt.Click += new System.EventHandler(this.pictureBoxReceipt_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1276, 652);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 46);
            this.BackButton.TabIndex = 151;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(38, 652);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 46);
            this.btnSave.TabIndex = 126;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBoxBusinessName
            // 
            this.textBoxBusinessName.Location = new System.Drawing.Point(234, 142);
            this.textBoxBusinessName.Name = "textBoxBusinessName";
            this.textBoxBusinessName.Size = new System.Drawing.Size(303, 22);
            this.textBoxBusinessName.TabIndex = 148;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(234, 338);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAmount.MaxLength = 25;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(303, 22);
            this.textBoxAmount.TabIndex = 147;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(35, 339);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 18);
            this.lblAmount.TabIndex = 146;
            this.lblAmount.Text = "Amount:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(234, 306);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProductName.MaxLength = 25;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(303, 22);
            this.textBoxProductName.TabIndex = 145;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(35, 307);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(121, 18);
            this.lblProductName.TabIndex = 144;
            this.lblProductName.Text = "Product Name:";
            // 
            // dtpDateExpired
            // 
            this.dtpDateExpired.Location = new System.Drawing.Point(234, 403);
            this.dtpDateExpired.Name = "dtpDateExpired";
            this.dtpDateExpired.Size = new System.Drawing.Size(303, 22);
            this.dtpDateExpired.TabIndex = 143;
            // 
            // dtpDateServiceDate
            // 
            this.dtpDateServiceDate.Location = new System.Drawing.Point(234, 372);
            this.dtpDateServiceDate.Name = "dtpDateServiceDate";
            this.dtpDateServiceDate.Size = new System.Drawing.Size(303, 22);
            this.dtpDateServiceDate.TabIndex = 142;
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Location = new System.Drawing.Point(234, 501);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(303, 96);
            this.richTextBoxComments.TabIndex = 141;
            this.richTextBoxComments.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 501);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "Comments:";
            // 
            // textBoxReceiptIMG
            // 
            this.textBoxReceiptIMG.Location = new System.Drawing.Point(234, 436);
            this.textBoxReceiptIMG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReceiptIMG.MaxLength = 25;
            this.textBoxReceiptIMG.Name = "textBoxReceiptIMG";
            this.textBoxReceiptIMG.Size = new System.Drawing.Size(303, 22);
            this.textBoxReceiptIMG.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 437);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 138;
            this.label2.Text = "Receipt Image:";
            // 
            // textLocation
            // 
            this.textLocation.Location = new System.Drawing.Point(234, 172);
            this.textLocation.Margin = new System.Windows.Forms.Padding(4);
            this.textLocation.MaxLength = 25;
            this.textLocation.Name = "textLocation";
            this.textLocation.Size = new System.Drawing.Size(303, 22);
            this.textLocation.TabIndex = 137;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(35, 172);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(78, 18);
            this.lblLocation.TabIndex = 136;
            this.lblLocation.Text = "Location:";
            // 
            // lblBusinessName
            // 
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.BackColor = System.Drawing.Color.Transparent;
            this.lblBusinessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessName.Location = new System.Drawing.Point(35, 142);
            this.lblBusinessName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusinessName.Name = "lblBusinessName";
            this.lblBusinessName.Size = new System.Drawing.Size(131, 18);
            this.lblBusinessName.TabIndex = 135;
            this.lblBusinessName.Text = "Business Name:";
            // 
            // labelDateExpired
            // 
            this.labelDateExpired.AutoSize = true;
            this.labelDateExpired.BackColor = System.Drawing.Color.Transparent;
            this.labelDateExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateExpired.Location = new System.Drawing.Point(35, 407);
            this.labelDateExpired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateExpired.Name = "labelDateExpired";
            this.labelDateExpired.Size = new System.Drawing.Size(109, 18);
            this.labelDateExpired.TabIndex = 134;
            this.labelDateExpired.Text = "Date Expired:";
            // 
            // textContactPhone
            // 
            this.textContactPhone.Location = new System.Drawing.Point(234, 272);
            this.textContactPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textContactPhone.MaxLength = 25;
            this.textContactPhone.Name = "textContactPhone";
            this.textContactPhone.Size = new System.Drawing.Size(303, 22);
            this.textContactPhone.TabIndex = 133;
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactPhone.Location = new System.Drawing.Point(35, 273);
            this.lblContactPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(125, 18);
            this.lblContactPhone.TabIndex = 132;
            this.lblContactPhone.Text = "Contact Phone:";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(234, 240);
            this.txtContactEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactEmail.MaxLength = 25;
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(303, 22);
            this.txtContactEmail.TabIndex = 131;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblContactEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactEmail.Location = new System.Drawing.Point(35, 241);
            this.lblContactEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(119, 18);
            this.lblContactEmail.TabIndex = 130;
            this.lblContactEmail.Text = "Contact Email:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.BackColor = System.Drawing.Color.Transparent;
            this.lblServiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDate.Location = new System.Drawing.Point(35, 375);
            this.lblServiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(109, 18);
            this.lblServiceDate.TabIndex = 129;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // labelAddServiceTitle
            // 
            this.labelAddServiceTitle.AutoSize = true;
            this.labelAddServiceTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelAddServiceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddServiceTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAddServiceTitle.Location = new System.Drawing.Point(672, 37);
            this.labelAddServiceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddServiceTitle.Name = "labelAddServiceTitle";
            this.labelAddServiceTitle.Size = new System.Drawing.Size(260, 36);
            this.labelAddServiceTitle.TabIndex = 128;
            this.labelAddServiceTitle.Text = "Add New Service";
            // 
            // txtBoxContactName
            // 
            this.txtBoxContactName.Location = new System.Drawing.Point(234, 208);
            this.txtBoxContactName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxContactName.MaxLength = 25;
            this.txtBoxContactName.Name = "txtBoxContactName";
            this.txtBoxContactName.Size = new System.Drawing.Size(303, 22);
            this.txtBoxContactName.TabIndex = 127;
            // 
            // txtServiceId
            // 
            this.txtServiceId.Location = new System.Drawing.Point(234, 109);
            this.txtServiceId.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceId.MaxLength = 25;
            this.txtServiceId.Name = "txtServiceId";
            this.txtServiceId.ReadOnly = true;
            this.txtServiceId.Size = new System.Drawing.Size(66, 22);
            this.txtServiceId.TabIndex = 149;
            // 
            // lblContactlName
            // 
            this.lblContactlName.AutoSize = true;
            this.lblContactlName.BackColor = System.Drawing.Color.Transparent;
            this.lblContactlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactlName.Location = new System.Drawing.Point(35, 209);
            this.lblContactlName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactlName.Name = "lblContactlName";
            this.lblContactlName.Size = new System.Drawing.Size(121, 18);
            this.lblContactlName.TabIndex = 125;
            this.lblContactlName.Text = "Contact Name:";
            // 
            // labelServiceId
            // 
            this.labelServiceId.AutoSize = true;
            this.labelServiceId.BackColor = System.Drawing.Color.Transparent;
            this.labelServiceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServiceId.Location = new System.Drawing.Point(35, 110);
            this.labelServiceId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServiceId.Name = "labelServiceId";
            this.labelServiceId.Size = new System.Drawing.Size(90, 18);
            this.labelServiceId.TabIndex = 124;
            this.labelServiceId.Text = "Service ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 155;
            this.label3.Text = "Click Image to Zoom.";
            // 
            // btnMaxPDF
            // 
            this.btnMaxPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMaxPDF.Location = new System.Drawing.Point(1050, 571);
            this.btnMaxPDF.Name = "btnMaxPDF";
            this.btnMaxPDF.Size = new System.Drawing.Size(366, 40);
            this.btnMaxPDF.TabIndex = 159;
            this.btnMaxPDF.Text = "Maximize PDF";
            this.btnMaxPDF.UseVisualStyleBackColor = true;
            this.btnMaxPDF.Click += new System.EventHandler(this.btnMaxPDF_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.axAcroPDF_viewer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1047, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 377);
            this.flowLayoutPanel1.TabIndex = 158;
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
            // lblPDFView
            // 
            this.lblPDFView.AutoSize = true;
            this.lblPDFView.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFView.Location = new System.Drawing.Point(1201, 108);
            this.lblPDFView.Name = "lblPDFView";
            this.lblPDFView.Size = new System.Drawing.Size(87, 25);
            this.lblPDFView.TabIndex = 157;
            this.lblPDFView.Text = "PDF File";
            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectPDF.Location = new System.Drawing.Point(1050, 525);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(366, 40);
            this.btnSelectPDF.TabIndex = 156;
            this.btnSelectPDF.Text = "Select PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = true;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);
            // 
            // txtPDFFile
            // 
            this.txtPDFFile.Location = new System.Drawing.Point(234, 468);
            this.txtPDFFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDFFile.MaxLength = 25;
            this.txtPDFFile.Name = "txtPDFFile";
            this.txtPDFFile.Size = new System.Drawing.Size(303, 22);
            this.txtPDFFile.TabIndex = 161;
            // 
            // lblPDFFile
            // 
            this.lblPDFFile.AutoSize = true;
            this.lblPDFFile.BackColor = System.Drawing.Color.Transparent;
            this.lblPDFFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDFFile.Location = new System.Drawing.Point(35, 469);
            this.lblPDFFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPDFFile.Name = "lblPDFFile";
            this.lblPDFFile.Size = new System.Drawing.Size(78, 18);
            this.lblPDFFile.TabIndex = 160;
            this.lblPDFFile.Text = "PDF File:";
            // 
            // AddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 728);
            this.Controls.Add(this.txtPDFFile);
            this.Controls.Add(this.lblPDFFile);
            this.Controls.Add(this.btnMaxPDF);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPDFView);
            this.Controls.Add(this.btnSelectPDF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pictureBoxReceipt);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxBusinessName);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dtpDateExpired);
            this.Controls.Add(this.dtpDateServiceDate);
            this.Controls.Add(this.richTextBoxComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReceiptIMG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.labelDateExpired);
            this.Controls.Add(this.textContactPhone);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.labelAddServiceTitle);
            this.Controls.Add(this.txtBoxContactName);
            this.Controls.Add(this.txtServiceId);
            this.Controls.Add(this.lblContactlName);
            this.Controls.Add(this.labelServiceId);
            this.MaximumSize = new System.Drawing.Size(1484, 775);
            this.MinimumSize = new System.Drawing.Size(1484, 775);
            this.Name = "AddNewService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewService";
            this.Load += new System.EventHandler(this.AddNewService_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddNewService_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceipt)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.PictureBox pictureBoxReceipt;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBoxBusinessName;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DateTimePicker dtpDateExpired;
        private System.Windows.Forms.DateTimePicker dtpDateServiceDate;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReceiptIMG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label labelDateExpired;
        private System.Windows.Forms.TextBox textContactPhone;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblContactEmail;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label labelAddServiceTitle;
        private System.Windows.Forms.TextBox txtBoxContactName;
        private System.Windows.Forms.TextBox txtServiceId;
        private System.Windows.Forms.Label lblContactlName;
        private System.Windows.Forms.Label labelServiceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaxPDF;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF_viewer;
        private System.Windows.Forms.Label lblPDFView;
        private System.Windows.Forms.Button btnSelectPDF;
        private System.Windows.Forms.TextBox txtPDFFile;
        private System.Windows.Forms.Label lblPDFFile;
    }
}