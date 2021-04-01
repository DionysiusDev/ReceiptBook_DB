using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourProject_winForms
{
    public partial class ServiceDetailsScreen : Form
    {
        #region MyLogger
        //  declaration of logger
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region Constructors

        public ServiceDetailsScreen()
        {
            myLog4N.Debug("LN27: Initializing Service Details Form components.."); //logs message
            InitializeComponent();
            DoubleBuffered = true;
        }

        #endregion

        #region Form Events

        private void ServiceDetailsScreen_Load(object sender, EventArgs e)
        {
            myLog4N.Debug("LN38: Populating Service Grid.."); //logs message
            PopulateGrid(); // populate grid
        }

        private void ServiceDetailsScreen_Paint(object sender, PaintEventArgs e)
        {
            myLog4N.Debug("LN44: Painting Service Screen.."); //logs message
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }
        #endregion

        #region Control events

        //  this takes us to the add new service screen
        private void btnAddNewService_Click(object sender, EventArgs e)
        {
            AddNewService frm = new AddNewService();
            if (frm.ShowDialog() == DialogResult.OK)
                myLog4N.Debug("LN57: Ok Selected.." + MousePosition.ToString()); //logs message
            myLog4N.Debug("LN58: Populating Service Grid..");                //logs message

            PopulateGrid();
        }

        //  this takes us to the edit service screen
        private void EditServiceButton_Click(object sender, EventArgs e)
        {
            myLog4N.Debug("LN66: Edit Service Button Clicked..");    //logs message

            if (dgvServices.CurrentCell == null) return;
            myLog4N.Debug("LN69: Null Service Cell Selected.."); //logs message

            long PKID = long.Parse(dgvServices[0, dgvServices.CurrentCell.RowIndex].Value.ToString());

            EditService frm = new EditService(PKID);
            if (frm.ShowDialog() == DialogResult.OK)
                myLog4N.Debug("LN75: Edit Service Clicked, Populating Service Grid.."); //logs message
            PopulateGrid();
        }

        //  this loads the clicked cells tool information in the update tool screen
        private void dgvServices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServices.CurrentCell == null) return;
            myLog4N.Debug("LN83: Null Service Cell Selected.."); //logs message

            long PKID = long.Parse(dgvServices[0, dgvServices.CurrentCell.RowIndex].Value.ToString());

            EditService frm = new EditService(PKID);
            if (frm.ShowDialog() == DialogResult.OK)
                myLog4N.Debug("LN89: Ok Selected, Populating Product Grid.."); //logs message
            PopulateGrid();
        }

        //  this button will close this window
        private void HomeButton_Click(object sender, EventArgs e)
        {
            myLog4N.Debug("LN96: Home Button Clicked.."); //logs button clicked message

            CollectGarbage();                           //calls for garbage collection
            Close();                                    //closes the window
        }

        /// <summary>
        /// Will delete the selected service record from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            myLog4N.Debug("LN109: Delete Service Button Clicked.."); //logs button clicked message

            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected service record?", "Service",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    myLog4N.Debug("LN116: Yes Option Selected.."); //logs button clicked message

                    long PKID = long.Parse(dgvServices[0, dgvServices.CurrentCell.RowIndex].Value.ToString());

                    //Use the DeleteRecord method
                    ProjectModel.DLL.ProjectContext.DeleteRecord("Service", "ServiceId", PKID.ToString());
                    myLog4N.Debug("LN122: Service Deleted, Populating Service Grid.."); //logs button clicked message
                    PopulateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LN 127: Error Deleting Service Record ");
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Method used for populating data to our data grid view.
        /// </summary>
        private void PopulateGrid()
        {
            ProjectModel.DLL.ProjectContext.ConnectionString = Properties.Settings.Default.ConnectionString;
            DataTable dtbServices = new DataTable();
            dtbServices = ProjectModel.DLL.ProjectContext.GetDataTable("Service");
            dgvServices.DataSource = dtbServices;
            //added for removing columns from data table
            dtbServices.Columns.Remove("ContactName");
            dtbServices.Columns.Remove("ContactEmail");
            dtbServices.Columns.Remove("Location");
            dtbServices.Columns.Remove("ReceiptIMG");
            dtbServices.Columns.Remove("Amount");
            dtbServices.Columns.Remove("Comments");
            myLog4N.Debug("Populating Grid...");
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

        #region FileHandling

        #region Export To CSV File
        /// <summary>
        /// Export tools to CSV File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExportToolReport_Click(object sender, EventArgs e)
        {
            try
            {
                // create file save structure
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Report.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Message to user to acknowledge data is being prepared.
                    MessageBox.Show("Preparing data for export please wait...");
                    if (File.Exists(filename))
                    {
                        try
                        {
                            // delete file to save file with existing name.
                            File.Delete(filename);
                        }
                        catch (IOException ioCsvException)
                        {
                            // display export data error.
                            MessageBox.Show("ERROR writing data to disk." + ioCsvException.Message);
                            myLog4N.Debug(ioCsvException.StackTrace);
                        }
                    }
                    // count the columns in the data grid view(DGV).
                    int columnCount = dgvServices.ColumnCount;
                    // Store Column Names in string.
                    string columnNames = "";
                    // Collect data from DGV rows and store in Array.
                    string[] export = new string[dgvServices.RowCount + 1];
                    // Control structure For:
                    // Number of columns starting at the first index position.
                    // Count total number of columns in DGV and, Add.
                    for (int i = 0; i < columnCount; i++)
                    {
                        // Store column names to string - Add comma between column names.
                        columnNames += dgvServices.Columns[i].Name.ToString() + ",";
                    }
                    export[0] += columnNames;
                    for (int i = 1; (i - 1) < dgvServices.RowCount; i++)
                    {

                        for (int j = 0; j < columnCount; j++)
                        {

                            try
                            {
                                ////////////////////////////////////////////////////////////////////
                                /// FIX Null Reference Exception.
                                /// DataGridView - set AllowUserToAddRows to False.
                                /// DataGridView - set AllowUserToDeleteRows to False.
                                ///////////////////////////////////////////////////////////////////

                                // Add data rows.
                                export[i] += dgvServices.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                myLog4N.Debug(dgvServices.Rows[i - 1].Cells[j].Value.ToString());

                                /////////////////////////////////////////////////////////////////////////////
                                ///  EXAMPLE - FOR 2nd Null Ref Exception.
                                ///  Use a '?' symbol to allow null values on export.
                                ///  **Value?.ToString()**
                                ///  
                                ///  // Add '?' at the end of Value to allow null values.
                                ///  export[i] += dgvTools.Rows[i - 1].Cells[j].Value?.ToString() + ",";
                                /////////////////////////////////////////////////////////////////////////////
                            }
                            catch (IOException csvWriteException)
                            {
                                // display error to user.
                                MessageBox.Show("ERROR Null Reference found in data." + csvWriteException.Message);
                                myLog4N.Debug(csvWriteException.StackTrace);
                            }
                        }
                    }
                    // Export data from DGV to CSV file.
                    System.IO.File.WriteAllLines(sfd.FileName, export, System.Text.Encoding.UTF8);
                    // display prompts to the user about the files progress.
                    MessageBox.Show("CSV file generated successfully.");
                    myLog4N.Debug("CSV file generated successfully.");
                }
            }
            catch (IOException CSVFailException)
            {   // display catch message to user
                MessageBox.Show("ERROR writing data CSV." + CSVFailException.Message);
                myLog4N.Debug(CSVFailException.StackTrace);
            }
        }








        #endregion

        #endregion

        private void printFile()
        {
            try
            {
                //instantiate print dialog
                PrintDialog PD = new PrintDialog();
                PD.ShowDialog();
                //instantiate print document
                PrintDocument printDoc = new PrintDocument();
                printDoc.DocumentName = "Service_Receipt";
                PD.Document = printDoc;
                PD.AllowSelection = true;
                PD.AllowSomePages = true;
                //Call ShowDialog  and print document
                if (PD.ShowDialog() == DialogResult.OK) printDoc.Print();
            }
            catch (IOException IOE)
            {
                // display export data error.
                MessageBox.Show("ERROR Printing File." + IOE.Message);
                myLog4N.Debug("ERROR Printing File. " + IOE.StackTrace);
            }
        }

        private void btnServiceList_Click(object sender, EventArgs e)
        {
            SearchServices frm = new SearchServices();
            frm.ShowDialog();
        }
        //    private void btnExportService_Click1(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            // create file save structure
        //            string filename = "";
        //            SaveFileDialog sfd = new SaveFileDialog();
        //            sfd.Filter = "CSV (*.csv)|*.csv";
        //            sfd.FileName = "Report.csv";
        //            if (sfd.ShowDialog() == DialogResult.OK)
        //            {
        //                // Message to user to acknowledge data is being prepared.
        //                MessageBox.Show("Preparing data for export please wait...");
        //                if (File.Exists(filename))
        //                {
        //                    try
        //                    {
        //                        // delete file to save file with existing name.
        //                        File.Delete(filename);
        //                    }
        //                    catch (IOException ioCsvException)
        //                    {
        //                        // display export data error.
        //                        MessageBox.Show("ERROR writing data to disk." + ioCsvException.Message);
        //                        myLog4N.Debug(ioCsvException.StackTrace);
        //                    }
        //                }
        //                // count the columns in the data grid view(DGV).
        //                int columnCount = dgvServices.ColumnCount;
        //                // Store Column Names in string.
        //                string columnNames = "";
        //                // Collect data from DGV rows and store in Array.
        //                string[] export = new string[dgvServices.RowCount + 1];
        //                // Control structure For:
        //                // Number of columns starting at the first index position.
        //                // Count total number of columns in DGV and, Add.
        //                for (int i = 0; i < columnCount; i++)
        //                {
        //                    // Store column names to string - Add comma between column names.
        //                    columnNames += dgvServices.Columns[i].Name.ToString() + ",";
        //                }
        //                export[0] += columnNames;
        //                for (int i = 1; (i - 1) < dgvServices.RowCount; i++)
        //                {

        //                    for (int j = 0; j < columnCount; j++)
        //                    {

        //                        try
        //                        {
        //                            ////////////////////////////////////////////////////////////////////
        //                            /// FIX Null Reference Exception.
        //                            /// DataGridView - set AllowUserToAddRows to False.
        //                            /// DataGridView - set AllowUserToDeleteRows to False.
        //                            ///////////////////////////////////////////////////////////////////

        //                            // Add data rows.
        //                            export[i] += dgvServices.Rows[i - 1].Cells[j].Value.ToString() + ",";
        //                            myLog4N.Debug(dgvServices.Rows[i - 1].Cells[j].Value.ToString());

        //                            /////////////////////////////////////////////////////////////////////////////
        //                            ///  EXAMPLE - FOR 2nd Null Ref Exception.
        //                            ///  Use a '?' symbol to allow null values on export.
        //                            ///  **Value?.ToString()**
        //                            ///  
        //                            ///  // Add '?' at the end of Value to allow null values.
        //                            ///  export[i] += dgvTools.Rows[i - 1].Cells[j].Value?.ToString() + ",";
        //                            /////////////////////////////////////////////////////////////////////////////
        //                        }
        //                        catch (IOException csvWriteException)
        //                        {
        //                            // display error to user.
        //                            MessageBox.Show("ERROR Null Reference found in data." + csvWriteException.Message);
        //                            myLog4N.Debug(csvWriteException.StackTrace);
        //                        }
        //                    }
        //                }
        //                // Export data from DGV to CSV file.
        //                System.IO.File.WriteAllLines(sfd.FileName, export, System.Text.Encoding.UTF8);
        //                // display prompts to the user about the files progress.
        //                MessageBox.Show("CSV file generated successfully.");
        //                myLog4N.Debug("CSV file generated successfully.");
        //            }
        //        }
        //        catch (IOException CSVFailException)
        //        {   // display catch message to user
        //            MessageBox.Show("ERROR writing data CSV." + CSVFailException.Message);
        //            myLog4N.Debug(CSVFailException.StackTrace);
        //        }
        //    }
    }
}
