using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace bakk_project_task
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
            // Create the connection
            using var connection = new SqliteConnection(connectionString);

            connection.Open();
            var tableCmd = connection.CreateCommand();
            // Debug truncate table
#if DEBUG
            tableCmd.CommandText =
                @"
            DROP TABLE IF EXISTS Clients ;
            ";
            tableCmd.ExecuteNonQuery();
#endif
            // Create a table if it doesn’t exist
            tableCmd.CommandText =
            @"
            CREATE TABLE IF NOT EXISTS Clients (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                FirstName TEXT NOT NULL,
                LastName TEXT NOT NULL,
                PhoneNumber TEXT,
                Address TEXT,
                Email TEXT,
                Status TEXT
            );
            ";
            tableCmd.ExecuteNonQuery();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
    public static class WindowFlags//critical for passing control between windows
    {
        public static bool NewClient { get; set; }
    }
}