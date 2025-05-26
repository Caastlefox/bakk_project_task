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
            using (var connection = new SqliteConnection(connectionString))
            {
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
                Status TEXT,
                Email TEXT
            );
        ";
                tableCmd.ExecuteNonQuery();

                // 4. Insert some data
                var insertCmd = connection.CreateCommand();
                insertCmd.CommandText =
                @"
            INSERT INTO Clients (FirstName, LastName, Email)
            VALUES ($firstname, $lastname, $email);
        ";
                insertCmd.Parameters.AddWithValue("$firstname", "Alice");
                insertCmd.Parameters.AddWithValue("$lastname", "Doe");
                insertCmd.Parameters.AddWithValue("$email", "alice@example.com");
                insertCmd.ExecuteNonQuery();

                // 5. Read the data
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = "SELECT Id, FirstName, LastName Email FROM Clients;";
                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = reader.GetInt32(0);
                        var name = reader.GetString(1);
                        var email = reader.GetString(2);

                        Console.WriteLine($"ID: {id}, Name: {name}, Email: {email}");
                    }
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
            /*
             * 
            // Create and save a new Blog
            Console.Write("Enter a name for a new Blog: ");
            var name = Console.ReadLine();

            var blog = new Client { Name = name };
            db.Blogs.Add(blog);
            db.SaveChanges();

            // Display all Blogs from the database
            var query = from b in db.Blogs
                        orderby b.Name
                        select b;

            Console.WriteLine("All blogs in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


            */

        }
    }
    public static class WindowFlags//critical for passing control between windows
    {
        public static bool NewClient { get; set; }
    }


}

/* 1.Path to the SQLite database file (will create if it doesn’t exist)
        

// 2. Create the connection
using (var connection = new SqliteConnection(connectionString))
{
    connection.Open();

    // 3. Create a table if it doesn’t exist
    var tableCmd = connection.CreateCommand();
    tableCmd.CommandText =
    @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Email TEXT
                );
            ";
    tableCmd.ExecuteNonQuery();

    // 4. Insert some data
    var insertCmd = connection.CreateCommand();
    insertCmd.CommandText =
    @"
                INSERT INTO Users (Name, Email)
                VALUES ($name, $email);
            ";
    insertCmd.Parameters.AddWithValue("$name", "Alice");
    insertCmd.Parameters.AddWithValue("$email", "alice@example.com");
    insertCmd.ExecuteNonQuery();

    // 5. Read the data
    var selectCmd = connection.CreateCommand();
    selectCmd.CommandText = "SELECT Id, Name, Email FROM Users;";
    using (var reader = selectCmd.ExecuteReader())
    {
        while (reader.Read())
        {
            var id = reader.GetInt32(0);
            var name = reader.GetString(1);
            var email = reader.GetString(2);

            Console.WriteLine($"ID: {id}, Name: {name}, Email: {email}");
        }
    }
}

Console.WriteLine("Done!");
*/