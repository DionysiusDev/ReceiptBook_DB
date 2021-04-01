using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace YourProject_winForms
{
    public partial class HomeScreen : Form
    {
        private static readonly log4net.ILog myLog4N = log4net.LogManager.GetLogger(
           System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //  Main Menu is our first window
        public HomeScreen()
        {
            InitializeComponent();  //  Here is were we initialize our forms components
            DoubleBuffered = true;  //  Double Buffer should help with background flicker
            myLog4N.Debug("Initializing Components");

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //  This button exits the application
            myLog4N.Debug("Button Exit Clicked");
            myLog4N.Debug("Exiting from the application");

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();          //  this creates a new instance of our settings screen
            frm.ShowDialog();                       //  this will display our settings screen
            myLog4N.Debug("Loading the settings menu");
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {
                // read the new Property settings of the ColorTheme
                this.BackColor = Properties.Settings.Default.ColorTheme;
            
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductDetails frm = new ProductDetails();              //  this creates a new instance of our tools screen
            frm.ShowDialog();                                       //  this creates a new instance of our tools screen
            myLog4N.Debug("Loading the Product Details Screen");
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            ServiceDetailsScreen frm = new ServiceDetailsScreen();              //  this creates a new instance of our tools screen
            frm.ShowDialog();                                                   //  this creates a new instance of our tools screen
            myLog4N.Debug("Loading the Service Details Screen");
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            myLog4N.Debug("Logging out of application..");

            CollectGarbage();                       // calls for garbage collection

            this.Dispose();                         // dispose form after logging out.

            LoginMenu frmload = new LoginMenu();    //  Load our Login window
            frmload.ShowDialog();
        }

        private void btnServiceList_Click(object sender, EventArgs e)
        {
            SearchServices frm = new SearchServices();
            frm.Show();
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            SearchProducts frm = new SearchProducts();
            frm.Show();
        }

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

        private void HomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            HomeScreen frm = new HomeScreen();
            frm.Close();
            Application.Exit();
        }
    }
}
