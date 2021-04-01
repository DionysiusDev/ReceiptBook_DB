using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using log4net;
using log4net.Config;
using System.Drawing.Drawing2D;

namespace YourProject_winForms
{
    public partial class LoginMenu : Form
    {
        //  Declaration of multiple Sql Client,
        //  ADO.NET Frame Works.
        private SqlConnection loginConnection;
        private SqlTransaction loginTransaction;

        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoginMenu()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void LoginMenu_Paint(object sender, PaintEventArgs e)
        {
            // read the new Property settings of the ColorTheme
            this.BackColor = Properties.Settings.Default.ColorTheme;
        }

        // Exit the Application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();

            myLog4N.Debug("Closing login Window..");
        }

        //  Connection String
        string cs = ProjectModel.DLL.ProjectContext.ConnectionString =
            Properties.Settings.Default.ConnectionString;


        //  this button controls the login validation method.
        private void LogingButton_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                myLog4N.Debug("Invalid credentials Entered...");
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //  Create SqlConnection
                loginConnection = new SqlConnection(cs);

                //  SqlCommand is used to hold the query linked to our connection
                SqlCommand loginCommand = new SqlCommand("Select * from Login where " +
                                                         "UserName=@UserName and" +
                                                         " Password=@Password",
                                                         loginConnection);

                //  Declaration of required parameters for verifying user login
                loginCommand.Parameters.AddWithValue("@UserName", textBoxUserName.Text);
                loginCommand.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                

                //  This is where we open our connection
                loginConnection.Open();

                myLog4N.Debug("Connection opened...");

                //  we start our transaction after immediately after we open our connection
                loginTransaction = loginConnection.BeginTransaction();

                myLog4N.Debug("Beginning transaction...");

                loginCommand.Transaction = loginTransaction;    //  here we link our transaction to our command

                loginCommand.ExecuteNonQuery(); //  Query must be executed in order to process the roll back

                myLog4N.Debug("Executing Non Query...");

                /*  ---------------------------------------------------------
                 *  the data adapter is used to specify SQL commands that,
                 *  provides elementary CRUD functionality,
                 *  Create, Update, Retrieve(Read), and Delete.
                 *  
                 *  DataAdapter functions as a bridge between a data source,
                 *  and a disconnected data class, such as a DataSet -->
                 *  ---------------------------------------------------------
                */
                SqlDataAdapter dataAdapter = new SqlDataAdapter(loginCommand);


                DataSet loginDataSet = new DataSet(); //  dataset refers to data selected and arranged in rows and columns

                dataAdapter.Fill(loginDataSet);       //  Here we use the data adapter to populate (Fill) the data set with data :-)

               

                /*  ---------------------------------------------
                 *  int is the variable or data type,
                 *  we will set int count to the first index of,
                 *  the table in the data set.
                 *  ---------------------------------------------
                 */
                int count = loginDataSet.Tables[0].Rows.Count;        //  int is the variable or data type

                if (count == 1)                             //  If count is equal to 1, than show frmMain form
                {
                    MessageBox.Show("Login Successful!");
                    myLog4N.Debug("Login Successful!...");

                    loginTransaction.Commit();          //  If we are happy with the results commit the transaction
                    myLog4N.Debug("Transaction Committed...");

                    this.Hide();                        //  Hide our login window
                    HomeScreen frmload = new HomeScreen();  //  Load our main menu form
                    frmload.Show();                     //  Show us the form on screen
                }
                // else do this-->
                else
                {
                    //  used to display a warning about login attempt error
                    MessageBox.Show("Unrecognised User Name and or Password.../nPlease try again..");
                    myLog4N.Debug("Invalid Credentials...");

                    textBoxUserName.Clear();    //  this is here to clear the fields,
                    textBoxPassword.Clear();    //  after an unsuccessful login attempt

                }
            }
            /*  --------------------------------------------------------------
             *  its is important to always catch exceptions
             *  this exception has been named login Exception to,
             *  so we know if there is any errors caught during login attempt.
             *  ---------------------------------------------------------------
            */
            catch (Exception loginException)
            {
                //  we can create a custom error message to catch our exception like so
                MessageBox.Show(loginException.Message, "Exception Caught during login process", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myLog4N.Debug("Exception caught during login process...", loginException);

                /*  -------------------------------------------------------------
                 *  This is where we create our rollback transaction procedure.
                 *  If this 'catch' catches any inconsistency in the transaction, 
                 *  it will perform a transaction roll back on the most recent,
                 *  performed task.
                 *  
                 *  This is safe practice to help maintain database integrity. 
                 *  --------------------------------------------------------------
                 */

                // Try Do This -->
                try
                {
                    //  here the login transaction attempts to roll back
                    loginTransaction.Rollback();

                    myLog4N.Debug("Rolling Back Transaction");

                    //  on successful roll back display confirmation of transaction rollback message
                    MessageBox.Show("Rollback Confirmed..");

                    myLog4N.Debug("Transaction Rolled Back..");
                }

                //  again 'Catch' any inconsistencies - Exceptions
                catch (Exception LoginRollbackException)
                {
                    //  display the error message
                    MessageBox.Show(LoginRollbackException.Message, "Transaction Failed To Rolled Back..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myLog4N.Debug("Transaction Failed To Rolled Back..", LoginRollbackException);
                }
                loginConnection.Close();    //  Once the query is execute and the data has been retrieved we Close the connection 
                //  Throw this:
                throw;

            }

        }

        //  private method used to clear text fields on button event
        private void ClearFields_Click(object sender, EventArgs e)
        {

            textBoxUserName.Clear();    //  Clear User Name
            textBoxPassword.Clear();    //  Clear Password
            textBoxUserName.Focus();    //  Return focus to the User Name text field


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //  This button exits the application
            myLog4N.Debug("Exiting From The Application..");
        }

        private void LoginMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //  This button exits the application
        }
    }
}