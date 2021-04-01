using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourProject_winForms
{
    public partial class AddNewService : Form
    {
        #region MyLogger
        //  declaration of logger
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Variable Declarations

        private long _lngPKID = 0;
        private DataTable _dtbService = null;
        private bool _blnNew = false;
        private SqlConnection sqlConnectionTool;
        string ImagePath = "";

        string pdfFile;

        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to create new record
        /// </summary>
        public AddNewService()
        {
            myLog4N.Debug("LN40: Initializing New Service Form components.."); //logs message
            _blnNew = true;
            InitializeComponent();
            DoubleBuffered = true;
            myLog4N.Debug("LN44: Initializing New Service Data Table.."); //logs message
            InitializeDataTable();

        }

        /// <summary>
        /// Constructor to open and update existing record
        /// </summary>
        /// <param name="PKID"></param>
        public AddNewService(long PKID)
        {
            myLog4N.Debug("LN55: Initializing New Service Form components.."); //logs message
            InitializeComponent();
            DoubleBuffered = true;
            _lngPKID = PKID;
            myLog4N.Debug("LN59: Initializing New Service Data Table.."); //logs message
            InitializeDataTable();
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

        #region Form Events
        private void AddNewService_Load(object sender, EventArgs e)
        {
            myLog4N.Debug("LN88: Binding Service Controls.."); //logs message
            // Upon loading the form, establish the binding of the controls in the form.
            BindControls();
        }

        private void AddNewService_Paint(object sender, PaintEventArgs e)
        {
            myLog4N.Debug("LN96: Painting Service Screen.."); //logs message
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        #endregion

        #region Button Events

        /// <summary>
        /// Select Image Button - allows user to select receipt image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            SelectReceiptImage(sender);         //opens dialogue box for image selection & sets path

            SetImageSavePath();                 //saves image to desired file path

            CollectGarbage();                   //calls for garbage collection
        }
        /// <summary>
        /// Should open file dialog when user clicks the picture box.
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
        /// Insert new record to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //  Establish connection String
            string connectionString = ProjectModel.DLL.ProjectContext.ConnectionString =
                Properties.Settings.Default.ConnectionString;

            //  if these two requirements are not met text length needs to be at least 5 characters
            if (textBoxProductName.Text =="" || textBoxBusinessName.Text == "") //Text == ""
            {
                //  Display a message to the user about missing details
                MessageBox.Show("Please Enter Business Name & Product Name.", MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);

                return;
            }

            try
            {
                //  Create SqlConnection connecting to our database via our connection string
                sqlConnectionTool = new SqlConnection(connectionString);

                //< !--this is example two in case one doesn't work -->
                //< !--SqlConnection con = new SqlConnection(cs); -->

                //  Create a command to query the data base
                SqlCommand cmd = new SqlCommand("Select * from Service where ProductName=@ProductName and BusinessName=@BusinessName", sqlConnectionTool);
                cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text); //  Assert our parameters for integrity
                cmd.Parameters.AddWithValue("@BusinessName", textBoxBusinessName.Text);

                //  Open connection
                sqlConnectionTool.Open();

                //  Create and command query
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                //  this will end the data to the data set
                adapt.Fill(ds);

                // Close connection
                sqlConnectionTool.Close();

                //  This will count through the rows in the queried table
                int count = ds.Tables[0].Rows.Count;

                //  Try this:
                //  Validate product name, ID, and/or receipt number don't exist
                try
                {
                    //  If count is equal to 1
                    if (count == 1)
                    {

                        //  This should display a receipt exists message
                        MessageBox.Show("Insert Product Failed - [" + textBoxProductName.Text + "] -and- [" + textBoxBusinessName.Text +
                            "] - Already exists in the database", MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);

                        //  Than clear the text boxes
                        textBoxProductName.Clear();
                        textBoxBusinessName.Clear();
                    }

                    //  else DO THIS:
                    //  Verify data does not exist than save to data table
                    else
                    {

                        // display message to user to verify Insert Success
                        MessageBox.Show(textBoxBusinessName.Text + " Record Saved. " + DateTime.Now);

                        // always do the EndEdit, otherwise the data will not persist.
                        _dtbService.Rows[0].EndEdit();

                        // calls the method in our Data Access Layer to save the changes to the data table
                        ProjectModel.DLL.ProjectContext.SaveDatabaseTable(_dtbService);

                        CollectGarbage();                           //calls for garbage collection
                    }
                }
                //  Catch our exceptions
                catch (Exception toolExists)
                {
                    //  display our warning message
                    MessageBox.Show(toolExists.Message, MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);
                }
            }
            catch (Exception validationException)
            {
                MessageBox.Show(validationException.Message, MessageBoxIcon.Error.ToString(), MessageBoxButtons.OK);
            }
        }

        private void BackButton_Click_1(object sender, EventArgs e)
        {
            CollectGarbage();                           //calls for garbage collection
            Close();
        }

        #endregion

        #region File Handling

        private void SelectReceiptImage(object sender)
        {
            Button SelectButton = sender as Button;

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
                if (pictureBoxReceipt.Image == null || pictureBoxReceipt.Image != null)
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

                            // stores the image path in the text field
                            textBoxReceiptIMG.Text = filePathName;
                            textBoxReceiptIMG.Focus();
                        }
                }
            }
            catch (FileNotFoundException fne)
            {
                // display error message to user
                // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
            }
            catch (Exception e)
            {
                // display error message to user
                // MessageBox.Show("Error Selecting File @ " + textBoxReceiptIMG.Text);
            }
        }

        private void SetImageSavePath()
        {
            if (pictureBoxReceipt.Image != null)
            {
                try
                {
                    // sets directory path for image file and folder.
                    string dirPath = "C:\\Receipt Book\\MyServices\\";
                    string folder = textBoxBusinessName.Text;
                    string productName = textBoxProductName.Text + ".jpg";

                    //checks if directory exists else creates directory
                    if (!Directory.Exists(dirPath + folder))
                        Directory.CreateDirectory(dirPath + folder);

                    //path for folder directory and file
                    string filePathName = dirPath + folder + "\\";

                    string filePath = Path.Combine(filePathName, productName);

                    Image receiptFile = pictureBoxReceipt.Image;
                    receiptFile.Save(filePath);

                }
                catch (FileNotFoundException fne)
                {
                    // display error message to user
                    // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
                }
                catch (Exception e)
                {
                    // display error message to user
                    // MessageBox.Show("Error Setting File Path @ " + textBoxReceiptIMG.Text);
                }
            }
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

        #region Cleaner Methods

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
        /// <summary>
        /// New PDF Selection Methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPDF_Click(object sender, EventArgs e)
        {
            SelectPDFFile(sender);         //opens dialogue box for pdf selection & sets path

            SetPDFSavePath();              //saves pdf to desired file path

            CollectGarbage();              //calls for garbage collection
        }

        /// <summary>
        /// Select PDF File to View
        /// </summary>
        private void SelectPDFFile(object sender)
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
                    using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "PDF files|*.pdf" })
                    {
                        // if the dialog contains any of the file types and is successful..
                        if (ofd.ShowDialog() == DialogResult.OK)
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


        /// <summary>
        /// set PDF Save Path
        /// </summary>
        private void SetPDFSavePath()
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
        /// Should open PDF file in reader viewer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaxPDF_Click(object sender, EventArgs e)
        {
            // load file from storage location.
            string filePathName = txtPDFFile.Text;
            PDF_Reader_View frm = new PDF_Reader_View(filePathName);
            frm.Show();
        }

        #endregion
    }
}
