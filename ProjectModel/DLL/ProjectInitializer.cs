using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourProjectDBConnection;

namespace ProjectModel.DLL
{
    // Make this a static class so we can call it without creating an instance of it
    public static class ProjectInitializer
    {
        //TODO: Replace the ServerName with the name of your database instance
        private static string _ServerName = @"DESKTOP-51EGPI0\SSSDB2016MSSQL", _DatabaseName = "ReceiptBook_DB";
        static SQL _sql = new SQL();

        /// <summary>
        /// This method will create the database on the specified SQL Server
        /// </summary>
        public static void CreateDatabase()
        {
            // Create the Database
            _sql.CreateDatabase($"{_ServerName}", $"{_DatabaseName}");
            CreateDatabaseTables();
            SeedDatabaseTables();
        }

        /// <summary>
        /// This method will create the database tables required on SQL server
        /// </summary>
        private static void CreateDatabaseTables()
        {
            string connectionString = $"Data Source={_ServerName}; Initial Catalog={_DatabaseName}; Integrated Security=True";

            // Create Admin table
            string LoginDataStructure = " AdminId int IDENTITY(1,1) PRIMARY KEY, UserName NVARCHAR(50) NOT NULL," +
                                        " Password NVARCHAR(MAX) NOT NULL ";

            if (!_sql.IsDatabaseTableExists(_ServerName, _DatabaseName, "Login"))
            {
                _sql.CreateDatabaseTable(_ServerName, _DatabaseName, "Login", LoginDataStructure);
            }


            // Create Product table
            string ProductDataStructure =   " ProductId int IDENTITY(1,1) PRIMARY KEY,     ProductName NVARCHAR(70) NULL," +
                                            " ReceiptNum NVARCHAR(70) NULL,                BusinessName VARCHAR(70) NULL," +
                                            " Location NVARCHAR(70) NULL,                  BusinessPhone NVARCHAR(MAX) NULL," +
                                            " DatePurchased DATETIME NULL,                 DateExpired DATETIME NULL," +
                                            " ReceiptIMG NVARCHAR(MAX) NULL,               PDFFile NVARCHAR(MAX) NULL," +
                                            " Comments NVARCHAR(MAX) NULL,";

            if (!_sql.IsDatabaseTableExists(_ServerName, _DatabaseName, "Product"))
            {
                _sql.CreateDatabaseTable(_ServerName, _DatabaseName, "Product", ProductDataStructure);
            }


            // Create Services table
            string MyServiceDataStructure =  " ServiceId int IDENTITY(1,1) PRIMARY KEY,     BusinessName NVARCHAR(70) NULL," +
                                             " Location NVARCHAR(70) NULL,                  ContactName VARCHAR(50) NULL," +
                                             " ContactEmail VARCHAR(70) NULL,               ContactPhone VARCHAR(70) NULL," +
                                             " ProductName NVARCHAR(70) NULL,               ServiceDate DATETIME NULL," +
                                             " WarrantyExpired DATETIME NULL,               ReceiptIMG NVARCHAR(MAX) NULL," +
                                             " PDFFile NVARCHAR(MAX) NULL,                       Amount NVARCHAR(MAX) NULL," +
                                             " Comments NVARCHAR(MAX) NULL,";

            if (!_sql.IsDatabaseTableExists(_ServerName, _DatabaseName, "Service"))
            {
                _sql.CreateDatabaseTable(_ServerName, _DatabaseName, "Service", MyServiceDataStructure);
            }
        
        }


        /// <summary>
        /// Will populate the database tables and their related data.
        /// </summary>
        private static void SeedDatabaseTables() {

            SeedLoginDetails();
            //SeedServices();
            //SeedProducts();

        }


        /// <summary>
        /// Seeds login data.
        /// </summary>
        private static void SeedLoginDetails()
        {
            List<string> logins = new List<string>
            {
                "1, 'Dion2021', 'D10nY$1u$'",

            };

            foreach (var login in logins)
            {
                _sql.InsertRecord(_ServerName, _DatabaseName, "Login", "AdminId, UserName," +
                    " Password", login);

            }
        }


        /// <summary>
        /// Seeds Product data.
        /// </summary>
        private static void SeedProducts()
        {
            List<string> products = new List<string>
            {
                $"1,'MetaBox-Laptop-1', '#101011', 'Metabox.com', 'South Australia', 'null', '{DateTime.Parse("10/12/2019")}', '{DateTime.Parse("10/12/2022")}', 'E:\\Receipt_Tracker_Images\\MyReceipts\\MetaBox-Laptop-1.jpg', 'null', 'Good Pic.'"

            };

            foreach (var product in products)
            {
                _sql.InsertRecord(_ServerName, _DatabaseName,   "Product", "ProductId, ProductName," +
                                                                " ReceiptNum, BusinessName, Location, " +
                                                                " BusinessPhone, DatePurchased, DateExpired, " +
                                                                " ReceiptIMG, PDFFile, Comments", product);
            }

        }


        /// <summary>
        /// Seeds Service data.
        /// </summary>
        private static void SeedServices()
        {
            List<string> services = new List<string>
            {
                $"1,'Solar Hart','Kawanna','Ben Gill','ben@gmail.com','null','Solar System','{DateTime.Parse("10/12/2019")}','{DateTime.Parse("10/12/2022")}','E:\\Receipt_Tracker_Images\\MyServices\\Solar System.jpg', 'null', '$10,000','Technician is a stooge.'"

            };

            foreach (var service in services)
            {
                _sql.InsertRecord(_ServerName, _DatabaseName, "Service", "ServiceId, BusinessName," +
                                                                " Location, ContactName, ContactEmail, " +
                                                                " ContactPhone, ProductName, ServiceDate, " +
                                                                " WarrantyExpired, ReceiptIMG, PDFFile, Amount, " +
                                                                " Comments", service);
            }
        }

    }
}
