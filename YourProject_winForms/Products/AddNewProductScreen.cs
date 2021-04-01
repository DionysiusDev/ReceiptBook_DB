using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YourProject_winForms
{
    public partial class AddNewProductScreen : Form
    {
        #region MyLogger
        //  declaration of logger
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Variable Declarations

        private long _lngPKID = 0;
        private DataTable _dtbProduct = null;
        private bool _blnNew = false;
        private SqlConnection sqlConnectionTool;
        string ImagePath = "";

        string pdfFile;

        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to create new record
        /// </summary>
        public AddNewProductScreen()
        {
            myLog4N.Debug("LN40: Initializing New Product Form components.."); //logs message
            _blnNew = true;
            InitializeComponent();
            DoubleBuffered = true;
            myLog4N.Debug("LN44: Initializing New Product Data Table.."); //logs message
            InitializeDataTable();

        }

        /// <summary>
        /// Constructor to open and update existing record
        /// </summary>
        /// <param name="PKID"></param>
        public AddNewProductScreen(long PKID)
        {
            myLog4N.Debug("LN55: Initializing New Product Form components.."); //logs message
            InitializeComponent();
            DoubleBuffered = true;
            _lngPKID = PKID;
            myLog4N.Debug("LN59: Initializing New Product Data Table.."); //logs message
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
            _dtbProduct = ProjectModel.DLL.ProjectContext.GetDataTable(
            $"SELECT * FROM Product WHERE ProductId = {_lngPKID}", "Product");

            // Create an empty row of Tools so users can fill it with Tool title.
            if (_blnNew)
            {
                DataRow row = _dtbProduct.NewRow();
                _dtbProduct.Rows.Add(row);
            }
        }
        #endregion

        #region Form Events
        private void AddUpdateToolScreen_Load(object sender, EventArgs e)
        {
            myLog4N.Debug("LN88: Binding Product Controls.."); //logs message
            // Upon loading the form, establish the binding of the controls in the form.
            BindControls();
            
        }

        private void AddUpdateToolScreen_Paint(object sender, PaintEventArgs e)
        {
            myLog4N.Debug("LN96: Painting Product Screen.."); //logs message
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        private void AddNewProductScreen_Paint(object sender, PaintEventArgs e)
        {
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
        private void btnUploadReceipt_Click(object sender, EventArgs e)
        {
            SelectReceiptImage(sender);         //opens dialogue box for image selection & sets path

            SetImageSavePath();                 //saves image to desired file path

            CollectGarbage();                   //calls for garbage collection
        }
        

        /// <summary>
        /// Should open file in image viewer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxReceiptImage_Click(object sender, EventArgs e)
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
        private void InsertButton_Click_1(object sender, EventArgs e)
        {

            //  Establish connection String
            string connectionString = ProjectModel.DLL.ProjectContext.ConnectionString =
                Properties.Settings.Default.ConnectionString;

            //  if these two requirements are not met display message to user
            if (textBoxProductName.Text == "" || textBoxReceiptNum.Text == "") //Text == ""
            {
                //  Display a message to the user about missing details
                MessageBox.Show("Please Enter Product Name & Reciept Number", MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);
                return;
            }

            //  if these two requirements are not met display message to user
            if (textBoxProductName.Text != "" || textBoxReceiptNum.Text != "") //Text == ""
            {

                try
                {
                    //  Create SqlConnection connecting to our database via our connection string
                    sqlConnectionTool = new SqlConnection(connectionString);

                    //< !--this is example two in case one doesn't work -->
                    //< !--SqlConnection con = new SqlConnection(cs); -->

                    //  Create a command to query the data base
                    SqlCommand cmd = new SqlCommand("Select * from Product where ProductName=@ProductName and ReceiptNum=@ReceiptNum", sqlConnectionTool);
                    cmd.Parameters.AddWithValue("@ProductName", textBoxProductName.Text); //  Assert our parameters for integrity
                    cmd.Parameters.AddWithValue("@ReceiptNum", textBoxReceiptNum.Text);

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
                            MessageBox.Show("Insert Product Failed - [" + textBoxProductName.Text + "] -and- [" + textBoxReceiptNum.Text +
                                "] - Already exists in the database", MessageBoxIcon.Warning.ToString(), MessageBoxButtons.OK);
                        }

                        //  else DO THIS:
                        //  Verify data does not exist than save to data table
                        else
                        {
                            // display message to user to verify Insert Success
                            MessageBox.Show(textBoxProductName.Text + " Record Saved. " + DateTime.Now);

                            // always do the EndEdit, otherwise the data will not persist.
                            _dtbProduct.Rows[0].EndEdit();

                            // calls the method in our Data Access Layer to save the changes to the data table
                            ProjectModel.DLL.ProjectContext.SaveDatabaseTable(_dtbProduct);

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
        }

        // close the current screen
        private void BackButton_Click(object sender, EventArgs e)
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
            string dirPath = "C:\\Receipt Book\\MyReceipts\\";
            string folder = txtBusinessName.Text;
            string productName = textBoxProductName.Text + ".jpg";

            //checks if directory exists else creates directory
            if (!Directory.Exists(dirPath + folder))
                Directory.CreateDirectory(dirPath + folder);

            //path for folder directory and file
            string filePathName = dirPath + folder + "\\" + productName;

            try
            { 
            // if a picture has been uploaded to the screen. Do This -->
            if (pictureBoxReceiptImage.Image == null || pictureBoxReceiptImage.Image != null)
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
                        pictureBoxReceiptImage.Image = Image.FromFile(open.FileName);

                        // select the image from file and display to the picture box on screen.
                        textBoxReceiptIMG.Text = filePathName;
                        textBoxReceiptIMG.Focus();
                    }
            }
            } catch (FileNotFoundException fne)
            {
                // display error message to user
                // MessageBox.Show("File Not Found @ " + textBoxReceiptIMG.Text);
            }
            catch (Exception e)
            {
                // display error message to user
                // MessageBox.Show("Error Selecting Product File @ " + textBoxReceiptIMG.Text);
            }
        }

        private void SetImageSavePath()
        {
            if (pictureBoxReceiptImage.Image != null)
            {
                try
                {
                    // sets directory path for image file and folder.
                    string dirPath = "C:\\Receipt Book\\MyReceipts\\";
                    string folder = txtBusinessName.Text;
                    string productName = textBoxProductName.Text + ".jpg";

                    //checks if directory exists else creates directory
                    if (!Directory.Exists(dirPath + folder))
                        Directory.CreateDirectory(dirPath + folder);

                    //path for folder directory and file
                    string filePathName = dirPath + folder + "\\";

                    string filePath = Path.Combine(filePathName, productName);

                    Image receiptFile = pictureBoxReceiptImage.Image;
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
            // Binding the text box txtUpdateToolId with the data table '_dtbProduct' and
            // map it to the database field called 'ProductId' and use the
            // 'Text' property of the control for binding.

            txtProductId.DataBindings.Add("Text", _dtbProduct, "ProductId");
            textBoxProductName.DataBindings.Add("Text", _dtbProduct, "ProductName");
            textBoxReceiptNum.DataBindings.Add("Text", _dtbProduct, "ReceiptNum");
            txtBusinessName.DataBindings.Add("Text", _dtbProduct, "BusinessName");
            textBoxBusinessPhone.DataBindings.Add("Text", _dtbProduct, "BusinessPhone");
            textBoxLocation.DataBindings.Add("Text", _dtbProduct, "Location");
            richTextBoxComments.DataBindings.Add("Text", _dtbProduct, "Comments");
            textBoxReceiptIMG.DataBindings.Add("Text", _dtbProduct, "ReceiptIMG");
            txtPDFFile.DataBindings.Add("Text", _dtbProduct, "PDFFile");

            // display date in day-month-year format.
            dtpDatePurchased.Format = DateTimePickerFormat.Custom;
            dtpDatePurchased.CustomFormat = "dd-MMM-yyyy";

            // display date in day-month-year format.
            dtpDateExpired.Format = DateTimePickerFormat.Custom;
            dtpDateExpired.CustomFormat = "dd-MMM-yyyy";

            // bind the dates to the date time picker.
            dtpDatePurchased.DataBindings.Add("Text", _dtbProduct, "DatePurchased");
            dtpDateExpired.DataBindings.Add("Text", _dtbProduct, "DateExpired");

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

        #region PDF File Methods

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
            string folder = txtBusinessName.Text;
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
                MessageBox.Show("File Not Found @ " + txtPDFFile.Text);
            }
            catch (Exception e)
            {
                // display error message to user
                MessageBox.Show("Error Selecting Product File @ " + txtPDFFile.Text);
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
                    string folder = txtBusinessName.Text;
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
