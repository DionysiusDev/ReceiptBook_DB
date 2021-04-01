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
    public partial class SearchProducts : Form
    {
        #region MyLogger
        //  declaration of logger
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
        System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion

        #region CONSTRUCTOR
        //  Initialise connection string
        public SearchProducts()
        {
            InitializeComponent();
            myLog4N.DebugFormat(CompanyName, ProductName, ProductVersion, "Initializing Components");
        }

        #endregion

        #region FORM EVENTS

        DataTable dtbProductSearchList = new DataTable("Product");

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            myLog4N.DebugFormat("Loading Order Search...");
            //  Try This
            try
            {
                //  Initialise connection string
                string ConnectionString = (ProjectModel.DLL.ProjectContext.ConnectionString = Properties.Settings.Default.ConnectionString);

                //  Initialise new SqlConnection
                //  Establish a connection via the connection string
                SqlConnection sqlConnection = new SqlConnection(ConnectionString);

                //  Open my connection
                sqlConnection.Open();
                myLog4N.DebugFormat("Connection Open...");
                // query for table
                string SqlQuery = "SELECT ProductId, ProductName, ReceiptNum, BusinessName, DatePurchased, DateExpired " +
                                  "FROM Product ORDER BY ProductName ASC";

                //  Initialise data adapter
                using (SqlDataAdapter sqldataAdapter = new SqlDataAdapter(SqlQuery, sqlConnection))
                {
                    myLog4N.DebugFormat("Executing Command Query...");
                    //  Fill the data table
                    sqldataAdapter.Fill(dtbProductSearchList);

                    //  Populate the data grid view
                    ProductListDisplay.DataSource = dtbProductSearchList;
                    myLog4N.DebugFormat("Data source applied to search list");
                }

                //  Close the connection
                sqlConnection.Close();
                myLog4N.DebugFormat("Connection closed..");

            }
            //  Catch This
            catch (Exception orderSearchException)
            {
                //  display exception message - Connect to tool table connection error
                MessageBox.Show(orderSearchException.Message, "Exception Caught!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myLog4N.Debug(orderSearchException.StackTrace);
            }
        }

        #endregion

        #region Control Events

        private void txtProductSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                try
                {
                    // If key '13' is pressed - Enter is pressed
                    if (e.KeyChar == (char)13)
                    {

                        DataView dataTable = dtbProductSearchList.DefaultView;

                        // Repopulate the data grid view dynamically 
                        dataTable.RowFilter = string.Format("ProductName like '%{0}%'", txtProductSearch.Text);

                        ProductListDisplay.DataSource = dataTable.Table;

                    }
                }
                catch (Exception keyCharOne)
                {
                    //  display exception message - "Key Press Event Exception Caught"
                    MessageBox.Show(keyCharOne.Message, "Key [char13] Press Event Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myLog4N.Debug(keyCharOne.StackTrace);
                }
                try
                {

                    //  If key'8' is pressed - Backspace is pressed
                    if (e.KeyChar == (char)8)
                    {
                        // Clear the tool search text box
                        txtProductSearch.Clear();
                    }

                }
                catch (Exception keyCharTwo)
                {
                    //  display exception message - "Key Press Event Exception Caught"
                    MessageBox.Show(keyCharTwo.Message, "Key [char8] Press Event Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myLog4N.Debug(keyCharTwo.StackTrace);
                }

            }
            catch (Exception keyPressException)
            {

                //  display exception message - Connect to tool table connection error
                MessageBox.Show(keyPressException.Message, "Key Press Event Exception Caught", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myLog4N.Debug(keyPressException.StackTrace);
            }
        }

        // Double click event
        //private void ProductListDisplay_DoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (ProductListDisplay.CurrentCell == null) return;  //  if our current cell is null return nothing.
        //    long PKID = long.Parse(ProductListDisplay[0, ProductListDisplay.CurrentCell.RowIndex].Value.ToString());
        //    EditProduct frm = new EditProduct(PKID);
        //    if (frm.ShowDialog() == DialogResult.OK)
        //        PopulateScreen();   //  now we populate the data on the next screen.
        //    myLog4N.Debug(ProductListDisplay);
        //}

        private void ProductListDisplay_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductListDisplay.CurrentCell == null) return;  //  if our current cell is null return nothing.
            long PKID = long.Parse(ProductListDisplay[0, ProductListDisplay.CurrentCell.RowIndex].Value.ToString());
            EditProduct frm = new EditProduct(PKID);
            if (frm.ShowDialog() == DialogResult.OK)
                PopulateScreen();   //  now we populate the data on the next screen.
            myLog4N.Debug(ProductListDisplay);
        }

        // close window
        private void btnClose_Click(object sender, EventArgs e)
        {
            CollectGarbage();
            Close();
            myLog4N.Debug("closing window..");
        }

        #endregion

        #region BUTTON EVENTS

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataView dataTable = dtbProductSearchList.DefaultView;
            // Repopulate the data grid view dynamically 
            dataTable.RowFilter = string.Format("ProductName like '%{0}%'", txtProductSearch.Text);
            ProductListDisplay.DataSource = dataTable.Table;
        }

        #endregion

        #region HELPER METHODS
        /// <summary>
        /// Populate screen is used to populate the data 
        /// on the screen after double click event.
        /// </summary>
        private void PopulateScreen()
        {
            ProjectModel.DLL.ProjectContext.ConnectionString = Properties.Settings.Default.ConnectionString;
            DataTable dbtSearchList = new DataTable();
            dbtSearchList = ProjectModel.DLL.ProjectContext.GetDataTable("Product"); //  we are sourcing our data from the service table
            ProductListDisplay.DataSource = dbtSearchList;
            myLog4N.Debug("Populating screen data..");
        }

        #endregion

        #region FileHandling

        #region Export To CSV File

        private void ExportButton_Click(object sender, EventArgs e)
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
                        catch (IOException ex)
                        {
                            // display export data error.
                            MessageBox.Show("ERROR writing data to disk." + ex.Message);
                        }
                    }
                    // count the columns in the data grid view(DGV).
                    int columnCount = ProductListDisplay.ColumnCount;
                    // Store Column Names in string.
                    string columnNames = "";
                    // Collect data from DGV rows and store in Array.
                    string[] export = new string[ProductListDisplay.RowCount + 1];
                    // Control structure For:
                    // Number of columns starting at the first index position.
                    // Count total number of columns in DGV and, Add.
                    for (int i = 0; i < columnCount; i++)
                    {
                        // Store column names to string - Add comma between column names.
                        columnNames += ProductListDisplay.Columns[i].Name.ToString() + ",";
                    }
                    export[0] += columnNames;
                    for (int i = 1; (i - 1) < ProductListDisplay.RowCount; i++)
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
                                export[i] += ProductListDisplay.Rows[i - 1].Cells[j].Value.ToString() + ",";

                                /////////////////////////////////////////////////////////////////////////////
                                ///  EXAMPLE - FOR 2nd Null Ref Exception.
                                ///  Use a '?' symbol to allow null values on export.
                                ///  **Value?.ToString()**
                                ///  
                                ///  // Add '?' at the end of Value to allow null values.
                                ///  export[i] += dgvTools.Rows[i - 1].Cells[j].Value?.ToString() + ",";
                                /////////////////////////////////////////////////////////////////////////////
                            }
                            catch (IOException ex)
                            {
                                // display error to user.
                                MessageBox.Show("ERROR Null Reference found in data." + ex.Message);
                            }
                        }
                    }
                    // Export data from DGV to CSV file.
                    System.IO.File.WriteAllLines(sfd.FileName, export, System.Text.Encoding.UTF8);
                    // display prompts to the user about the files progress.
                    MessageBox.Show("CSV file generated successfully.");
                }
            }
            catch (IOException CSVFailException)
            {   // display catch message to user
                MessageBox.Show("ERROR writing data CSV." + CSVFailException.Message);
            }
        }


        #endregion Export To CSV File

        #endregion FileHandling

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

        private void SearchProducts_Paint(object sender, PaintEventArgs e)
        {
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }
    }
}
