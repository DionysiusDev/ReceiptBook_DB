using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using log4net;
using log4net.Config;
using System.Diagnostics;

namespace YourProject_winForms
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Calls the ProjectInitializer.CreateDatabase method to create the database and populate it with data.
            ProjectModel.DLL.ProjectInitializer.CreateDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            log4net.Config.XmlConfigurator.Configure(); // initialise my logger

            Application.Run(new LoginMenu()); // LoginMenu
            //Application.Run(new PDF_Reader_View()); // PDF_Reader_View

        }
    }
}