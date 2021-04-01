using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourProject_winForms
{
    public partial class EditService : Form
    {
        #region Variable Declarations

        private long _lngPKID = 0;
        private DataTable _dtbService = null;
        private bool _blnNew = false;
        private string fileName;

        string pdfFile;

        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to create new record
        /// </summary>
        public EditService()
        {
            _blnNew = true;
            InitializeComponent();
            InitializeDataTable();

        }

        /// <summary>
        /// Constructor to open and update existing record
        /// </summary>
        /// <param name="PKID"></param>
        public EditService(long PKID)
        {
            InitializeComponent();
            _lngPKID = PKID;
            InitializeDataTable();
        }
        #endregion

        #region Control Events

        private void EditService_Load(object sender, EventArgs e)
        {
            BindControls();

            // Upon loading the form, loads the saved image from file stream
            LoadImageFromFileStream();

            // pdf should open when this form loads
            LoadPDFFromFilePath();

            CollectGarbage();                   //calls for garbage collection
        }

        private void EditService_Paint(object sender, PaintEventArgs e)
        {
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        #endregion

        #region Accessors
        /// <summary>
        /// This method will initialize the data table by getting the record of an existing tool or,
        /// create a new row when adding a new tool.
        /// </summary>
        private void InitializeDataTable()
        {
            // Get an existing Tool for Update
            _dtbService = ProjectModel.DLL.ProjectContext.GetDataTable(
            $"SELECT * FROM Service WHERE ServiceId = {_lngPKID}", "Service");

            // Create an empty row of Tools so users can fill it with Tool title.
            if (_blnNew)
            {
                DataRow row = _dtbService.NewRow();
                _dtbService.Rows.Add(row);
            }
        }

        #endregion

        #region Button Events

        /// <summary>
        /// Will allow user to view the maximized receipt image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxReceipt_Click(object sender, EventArgs e)
        {
            
            // load file from storage location.
            string filePathName = textBoxReceiptIMG.Text;
            ReceiptView frm = new ReceiptView(filePathName);
            frm.Show();

        }

        /// <summary>
        /// updates receipt image on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateImg_Click(object sender, EventArgs e)
        {
            RemovePBImage();                    //removes current image from picture box

            UpdateReceiptImage(sender);         //opens dialogue box for image selection & updates path

            UpdateImageSavePath();              //saves image to file path

            CollectGarbage();                   //calls for garbage collection
        }

        /// <summary>
        /// deletes receipt image on click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            RemovePBImage();                    //removes current image from picture box
        }

        /// <summary>
        /// Will update the new details to the exsiting record.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //  Establish connection String
            string connectionString = ProjectModel.DLL.ProjectContext.ConnectionString =
                Properties.Settings.Default.ConnectionString;

            //  if these two requirements are not met text length needs to be at least 5 characters
            if (textBoxProductName.Text == "" || textBoxBusinessName.Text == "") //Text == ""
            {
                //  Display a message to the user about missing details
                MessageBox.Show("Please Enter Business Name & Product Name.", MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);

                return;
            }

            try
            {

                // display message to user to verify Insert Success
                MessageBox.Show(textBoxBusinessName.Text + " record updated. : " + DateTime.Now);
                // always do the EndEdit, otherwise the data will not persist.
                _dtbService.Rows[0].EndEdit();
                // calls the method in our Data Access Layer to save the changes to the data table
                ProjectModel.DLL.ProjectContext.SaveDatabaseTable(_dtbService);

                // save image to folder.
                //SaveImageToLocalFolder();

            }

            catch (Exception serviceExists)    //  Catch our exceptions
            {
                //  display our warning message
                MessageBox.Show(serviceExists.Message, "Product Record Not Updated...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Will close this window and return to the previous screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            CollectGarbage();   //calls for garbage collection

            Close(); // close this window
        }

        /// <summary>
        /// Will close this window and return to the previous screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click_1(object sender, EventArgs e)
        {
            CollectGarbage();   //calls for garbage collection

            Close(); // close this window
        }

        #endregion

        #region Helper Methods
        /// <summary>
        /// This method will bind the controls to each field in the data table.
        /// </summary>
        private void BindControls()
        {
            // Binding the text box txtUpdateToolId with the data table '_dtbTool' and
            // map it to the database field called 'ToolId' and use the
            // 'Text' property of the control for binding.
            txtServiceId.DataBindings.Add("Text", _dtbService, "ServiceId");
            textBoxBusinessName.DataBindings.Add("Text", _dtbService, "BusinessName");
            textLocation.DataBindings.Add("Text", _dtbService, "Location");
            txtBoxContactName.DataBindings.Add("Text", _dtbService, "ContactName");
            txtContactEmail.DataBindings.Add("Text", _dtbService, "ContactEmail");
            textContactPhone.DataBindings.Add("Text", _dtbService, "ContactPhone");
            textBoxProductName.DataBindings.Add("Text", _dtbService, "ProductName");
            textBoxAmount.DataBindings.Add("Text", _dtbService, "Amount");
            richTextBoxComments.DataBindings.Add("Text", _dtbService, "Comments");
            textBoxReceiptIMG.DataBindings.Add("Text", _dtbService, "ReceiptIMG");
            txtPDFFile.DataBindings.Add("Text", _dtbService, "PDFFile");

            // display date in day-month-year format.
            dtpDateServiceDate.Format = DateTimePickerFormat.Custom;
            dtpDateServiceDate.CustomFormat = "dd-MMM-yyyy";

            // display date in day-month-year format.
            dtpDateExpired.Format = DateTimePickerFormat.Custom;
            dtpDateExpired.CustomFormat = "dd-MMM-yyyy";

            // bind the dates to the date time picker.
            dtpDateServiceDate.DataBindings.Add("Text", _dtbService, "ServiceDate");
            dtpDateExpired.DataBindings.Add("Text", _dtbService, "WarrantyExpired");
                       

        }

        #endregion

        #region File Handling

        /// <summary>
        /// Removes current image from picture box
        /// </summary>
        private void RemovePBImage()
        {
            try
            {
                if (pictureBoxReceipt.Image != null)
                {
                    pictureBoxReceipt.Image = null;
                    File.Delete(textBoxReceiptIMG.Text);
                }
            }
            catch (Exception e)
            {
                // display error message to user
                MessageBox.Show("Error Removing Image @ " + textBoxReceiptIMG.Text);
            }

        }
        /// <summary>
        /// select new image for updating receipt
        /// </summary>
        /// <param name="sender"></param>
        private void UpdateReceiptImage(object sender)
        {


            Button SelBtn = sender as Button;

            // sets directory path for image file and folder.
            string dirPath = "C:\\Receipt Book\\MyServices\\";
            string folder = textBoxBusinessName.Text;
            string productName = textBoxProductName.Text + ".jpg";

            //checks if directory exists else creates directory
            if (!Directory.Exists(dirPath + folder))
                Directory.CreateDirectory(dirPath + folder);

            //path for folder directory and file
            string filePathName = dirPath + folder + "\\" + productName;

            try
            {
                // if a picture has been uploaded to the screen. Do This -->
                if (pictureBoxReceipt == null || pictureBoxReceipt != null)
                {
                    using (OpenFileDialog open = new OpenFileDialog()
                    {
                        Filter = "All Files (*.*;) | *.*; | JPG Files (*.jpg;)| *.jpg; | JPEG Files (*.jpeg;) | *.jpeg; | BMP Files (*.bmp;) | *.bmp; | PNG files (*.png;) | *.png;",
                        ValidateNames = true,
                        Multiselect = false


                    })
                        // if the dialog contains any of the file types and is successful..
                        if (open.ShowDialog() == DialogResult.OK)
                        {
                            // select the image from file and display to the picture box on screen.
                            pictureBoxReceipt.Image = Image.FromFile(open.FileName);

                            // select the image from file and display to the picture box on screen.
                            textBoxReceiptIMG.Text = filePathName;
                            textBoxReceiptIMG.Focus();
                        }
                }
            }
            catch (FileNotFoundException fne)
            {
                // display error message to user to verify Insert Success
                // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
            }
            catch (Exception e)
            {
                // display error message to user to verify Insert Success
                // MessageBox.Show("Error Updating Image @ " + textBoxReceiptIMG.Text);
            }
        }

        private void UpdateImageSavePath()
        {
            if (pictureBoxReceipt.Image != null)
            {
                try
                {
                    // sets directory path for image file and folder.
                    string productName = textBoxProductName.Text;
                    string folder = "C:\\Receipt Book\\MyServices\\" + textBoxBusinessName.Text;
                    string fileName = productName + ".jpg";

                    //checks if directory exists else creates directory
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    //path for folder directory and file
                    string filePathName = folder + "\\";

                    string filePath = Path.Combine(filePathName, fileName);

                    Image receiptFile = pictureBoxReceipt.Image;
                    receiptFile.Save(filePath);

                }
                catch (FileNotFoundException fne)
                {
                    // display error message to user to verify Insert Success
                    // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
                }
                catch (Exception e)
                {
                    // display error message to user to verify Insert Success
                    // MessageBox.Show("Error Saving File @ " + textBoxReceiptIMG.Text);
                }
            }
        }

        /// <summary>
        /// Loads the image from file to stream as read only.
        /// </summary>
        private void LoadImageFromFileStream()
        {
            try
            {
                if (textBoxReceiptIMG.Text != null)
                {
                    // load file from storage location.
                    string fileDirPath = textBoxReceiptIMG.Text;

                    FileStream fs = File.OpenRead(fileDirPath);

                    pictureBoxReceipt.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            catch (FileNotFoundException fne)
            {
                // display error message to user to verify Insert Success
                // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
            }
            catch (Exception e)
            {
                // display error message to user to verify Insert Success
                // MessageBox.Show("Error Loading File @ " + textBoxReceiptIMG.Text);
            }
        }

        #endregion

        #region Memory Management Method

        /// <summary>
        /// This method will call for garbage collection.
        /// </summary>
        private void CollectGarbage()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }




        #endregion

        #region PDF File Handling

        private void btnUpdatePDF_Click(object sender, EventArgs e)
        {
            // RemovePDFImage();        //removes current image from pdf viewer

            UpdatePDFFile(sender);      //opens dialogue box for pdf selection & updates path

            UpdatePDFSavePath();        //saves pdf to file path

            CollectGarbage();           //calls for garbage collection
        }

        /// <summary>
        /// Removes current image from picture box
        /// </summary>
        private void RemovePDFImage()
        {
            try
            {
                if (axAcroPDF_viewer.src != null)
                {
                    axAcroPDF_viewer.src = null;
                    File.Delete(txtPDFFile.Text);
                }
            }
            catch (Exception e)
            {
                // display error message to user
                // MessageBox.Show("Error Removing Image @ " + txtPDFFile.Text + " " + e.Message);
            }

        }

        /// <summary>
        /// select new image for updating receipt
        /// </summary>
        /// <param name="sender"></param>
        private void UpdatePDFFile(object sender)
        {


            Button SelectButton = sender as Button;

            // sets directory path for image file and folder.
            string dirPath = "C:\\Receipt Book\\MyReceipts\\";
            string folder = textBoxBusinessName.Text;
            string productName = textBoxProductName.Text + ".pdf";

            //checks if directory exists else creates directory
            if (!Directory.Exists(dirPath + folder))
                Directory.CreateDirectory(dirPath + folder);

            //path for folder directory and file
            string filePathName = dirPath + folder + "\\" + productName;

            try
            {
                // if a picture has been uploaded to the screen. Do This -->
                if (axAcroPDF_viewer.src == null || axAcroPDF_viewer.src != null)
                {
                    using (OpenFileDialog ofd = new OpenFileDialog()
                    {
                        ValidateNames = true,
                        Multiselect = false,
                        Filter = "PDF files|*.pdf"
                    })

                    {
                        // if the dialog box result is not cancel
                        if (ofd.ShowDialog() != DialogResult.Cancel)
                        {
                            try
                            {

                                // set the pdf viewer source to the file name opened.
                                axAcroPDF_viewer.src = ofd.FileName;

                                // select the pdf from file and display to the pdf viewer box on screen.
                                txtPDFFile.Text = filePathName;
                                txtPDFFile.Focus();

                                pdfFile = ofd.FileName;

                            }
                            catch (Exception pdf_Read_Exception)
                            {
                                MessageBox.Show(pdf_Read_Exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        //the dialog box result is cancel
                        else
                        {
                            //DO Nothing stooge
                        }
                    }
                }
            }
            catch (FileNotFoundException fne)
            {
                // display error message to user
                // MessageBox.Show("File Not Found @ " + txtPDFFile.Text);
            }
            catch (Exception e)
            {
                // display error message to user
                // MessageBox.Show("Error Selecting Product File @ " + txtPDFFile.Text);
            }
        }

        private void UpdatePDFSavePath()
        {
            if (axAcroPDF_viewer.src != null)
            {
                try
                {
                    // sets directory path for image file and folder.
                    string dirPath = "C:\\Receipt Book\\MyReceipts\\";
                    string folder = textBoxBusinessName.Text;
                    string productName = textBoxProductName.Text + ".pdf";

                    //checks if directory exists else creates directory
                    if (!Directory.Exists(dirPath + folder))
                        Directory.CreateDirectory(dirPath + folder);

                    //path for folder directory and file
                    string filePathName = dirPath + folder + "\\";

                    string filePath = Path.Combine(filePathName, productName);

                    //TODO - fix!! this deletes the file even if user presses cancel?????
                    File.Delete(filePath);

                    File.Copy(pdfFile, filePath);
                }
                catch (FileNotFoundException fne)
                {
                    // display error message to user
                    MessageBox.Show("File Not Found @ " + txtPDFFile.Text);
                }
                catch (Exception e)
                {
                    // display error message to user
                    MessageBox.Show("Error Setting File Path @ " + txtPDFFile.Text);
                }
            }
        }

        /// <summary>
        /// Will allow user to view the maximized receipt PDF.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBigPDF_Click(object sender, EventArgs e)
        {
            // load file from storage location.
            string filePathName = txtPDFFile.Text;
            PDF_Reader_View frm = new PDF_Reader_View(filePathName);
            frm.Show();
        }

        private void DeletePdf_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtPDFFile.Text;
                File.Delete(filePath);
                axAcroPDF_viewer.src = null; //"E:\\Assessments\\Larissa_DB_Project\\YourProject_winForms\\Resources\\NO_PDF.pdf";
                txtPDFFile.Text = "";
                txtPDFFile.Focus();
            }
            catch (FileNotFoundException fne)
            {
                // display error message to user
                //MessageBox.Show("File Not Found @ " + txtPDFFile.Text);
            }
            catch (Exception ex)
            {
                // display error message to user
                MessageBox.Show("PDF File has already been deleted." + txtPDFFile.Text);
            }
        }

        /// <summary>
        /// Loads the image from file to stream as read only.
        /// </summary>
        private void LoadPDFFromFilePath()
        {
            try
            {
                if (txtPDFFile.Text != null)
                {
                    // load file from storage location.
                    string pdfFileDirPath = txtPDFFile.Text;
                    axAcroPDF_viewer.src = pdfFileDirPath;
                    axAcroPDF_viewer.Refresh();
                    CollectGarbage();

                }
            }

            // catch exceptions blanked to hide user message when no image is saved,
            // better for reading pdf and image files
            catch (FileNotFoundException fne)
            {
                // display error message to user
                // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
            }
            catch (Exception e)
            {
                // display error message to user
                // MessageBox.Show("Error loading File @ " + textBoxReceiptIMG.Text);
            }
        }

        #endregion

    }
}
