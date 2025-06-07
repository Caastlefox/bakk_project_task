#define CLEAR
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraMap;
using DevExpress.XtraRichEdit.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bakk_project_task
{

    public class ClientRepository : IClientRepository
    {
        private readonly string connectionString;
        public ClientRepository()
        {
            var conn = ConfigurationManager.ConnectionStrings["SQLiteConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(conn))
            {
                throw new InvalidOperationException("Connection string 'SQLiteConnection' is not configured.");
            }
            connectionString = conn;
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
#if CLEAR && DEBUG
            var debugcommand = connection.CreateCommand();

            debugcommand.CommandText = @"
                DROP TABLE IF EXISTS PhoneNumber;
                ;";
            debugcommand.ExecuteNonQuery();
            debugcommand.CommandText = @"
                DROP TABLE IF EXISTS Email;
                ;";
            debugcommand.ExecuteNonQuery();
            debugcommand.CommandText = @"
                DROP TABLE IF EXISTS Client;
                ;";
            debugcommand.ExecuteNonQuery();
#endif
            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Client (
                    Client_Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    Email TEXT,
                    Address TEXT,
                    PhoneNumber TEXT,
                    Status TEXT
                );";
            command.ExecuteNonQuery();

        }

        [SupportedOSPlatform("windows6.1")]
        public async Task<long> AddClient(string? firstName, string? lastName, string? address, string? status)
        {
            try
            {
                using var connection = new SqliteConnection(connectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                INSERT INTO Client(FirstName, LastName, Address, Status)
                VALUES ($firstName, $lastName, $address, $status);
                ";
                command.Parameters.AddWithValue("$firstName", firstName);
                command.Parameters.AddWithValue("$lastName", lastName);
                command.Parameters.AddWithValue("$address", address);
                command.Parameters.AddWithValue("$status", status);
                await command.ExecuteNonQueryAsync();
                command.CommandText = "SELECT last_insert_rowid();";
                var result = command.ExecuteScalar();
                if (result == null)
                {
                    throw new InvalidOperationException("Failed to retrieve the last inserted row ID.");
                    
                }
                return (long)result;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return -1;
        }
        [SupportedOSPlatform("windows6.1")]
        public async Task UpdateClient(long? id, string? firstName, string? lastName, string? address, string? status)
        {
            try
            {
                using var connection = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                UPDATE Client
                SET FirstName = $firstName, LastName = $lastName, Address = $address, Status = $status
                WHERE Client_Id = $id;
            ";
                command.Parameters.AddWithValue("$id", id);
                command.Parameters.AddWithValue("$firstName", firstName);
                command.Parameters.AddWithValue("$lastName", lastName);
                command.Parameters.AddWithValue("$address", address);
                command.Parameters.AddWithValue("$status", status);
                await command.ExecuteNonQueryAsync();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        [SupportedOSPlatform("windows6.1")]
        public async Task LoadClient(DataGridView dataGridView)
        {
            try
            {
                using var conn = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await conn.OpenAsync();
                var command = conn.CreateCommand();
                string sql = "SELECT Client.Client_Id, Client.FirstName, Client.LastName, "
                + "Email.Email,"
                + " PhoneNumber.PhoneNumber as \"Numer Telefonu\", "
                + "Client.Address, Client.Status FROM Client "
                + "LEFT JOIN Email ON Email.Client_Id = Client.Client_Id "
                + "LEFT JOIN PhoneNumber ON PhoneNumber.Client_Id = Client.Client_Id;";

                List<Client> data = [];
                using var cmd = new SqliteCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var client = new Client
                    {
                        Id = reader.IsDBNull(0) ? null : reader.GetInt64(0),
                        FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                        PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Address = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Status = reader.IsDBNull(6) ? null : reader.GetString(6)
                    };
                    data.Add(client);

                }


                dataGridView.DataSource = data;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        [SupportedOSPlatform("windows6.1")]
        public async Task LoadClient(GridControl dataGridView)
        {
            try
            {
                using var conn = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await conn.OpenAsync();
                var command = conn.CreateCommand();

                string sql = "SELECT Client.Client_Id, Client.FirstName, Client.LastName, "
                           + "Email.Email," 
                           + " PhoneNumber.PhoneNumber as \"Numer Telefonu\", "
                           + "Client.Address, Client.Status FROM Client "
                           + "LEFT JOIN Email ON Email.Client_Id = Client.Client_Id "
                           + "LEFT JOIN PhoneNumber ON PhoneNumber.Client_Id = Client.Client_Id;";
                command.CommandText = sql;
                List<Client> data = [];
                using var cmd = new SqliteCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync()) 
                {
                    var client = new Client
                    {
                        Id          = reader.IsDBNull(0) ? null : reader.GetInt64(0),
                        FirstName   = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName    = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Email       = reader.IsDBNull(3) ? null : reader.GetString(3),
                        PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Address     = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Status      = reader.IsDBNull(6) ? null : reader.GetString(6)
                    };
                    data.Add(client);

                }
                
                dataGridView.DataSource = data;
                dataGridView.MainView.PopulateColumns();

                //MessageBox.Show(result, "Query Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        [SupportedOSPlatform("windows6.1")]
        public async Task DeleteClient(long? id)
        {
            try
            {
                using var connection = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                DELETE FROM Client WHERE Client_Id = $id;
            ";
                command.Parameters.AddWithValue("$id", id);
                await command.ExecuteNonQueryAsync();
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        [SupportedOSPlatform("windows6.1")]
        public async Task<List<Client>> SearchClients(string SearchFirstName,
            string SearchLastName, string SearchAddress, string SearchPhoneNumber, 
            string SearchEmail, string? SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false)
        {
            List<Client> data = [];
            try
            {
                using var conn = new SqliteConnection(connectionString);
                await conn.OpenAsync();

                string sql = "SELECT C.Client_Id, C.FirstName, C.LastName, "
                            + "E.Email,"
                            + "P.PhoneNumber as \"Numer Telefonu\", "
                            + "C.Address, C.Status FROM Client C "
                            + "LEFT JOIN Email E ON E.Client_Id = C.Client_Id "
                            + "LEFT JOIN PhoneNumber P ON P.Client_Id = C.Client_Id ";

                sql += " WHERE 1=1 ";
                sql += string.IsNullOrEmpty(SearchFirstName) ? "" : $"AND C.FirstName LIKE \'%{SearchFirstName}%\' ";
                sql += string.IsNullOrEmpty(SearchLastName) ? "" : $"AND C.LastName LIKE \'%{SearchLastName}%\' ";
                sql += string.IsNullOrEmpty(SearchAddress) ? "" : $"AND C.Address LIKE \'%{SearchAddress}%\' ";
                if (blankTelephoneflag)
                {
                    sql += "AND P.PhoneNumber IS NULL OR P.PhoneNumber = \'\' ";
                }
                else
                {
                    sql += string.IsNullOrEmpty(SearchPhoneNumber) ? "" : $"AND P.PhoneNumber LIKE \'%{SearchPhoneNumber}%\' ";
                }
                if (blankEmailflag)
                {
                    sql += "AND E.Email IS NULL OR E.Email = \'\' ";
                }
                else
                {
                    sql += string.IsNullOrEmpty(SearchEmail) ? "" : $"AND E.Email LIKE \'%{SearchEmail}%\' ";
                }

                sql += string.IsNullOrEmpty(SearchStatus) ? "" : $"AND Status LIKE \'%{SearchStatus}%\' ";

                using var cmd = new SqliteCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var client = new Client
                    {
                        Id = reader.IsDBNull(0) ? null : reader.GetInt64(0),
                        FirstName = reader.IsDBNull(1) ? null : reader.GetString(1),
                        LastName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        Email = reader.IsDBNull(3) ? null : reader.GetString(3),
                        PhoneNumber = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Address = reader.IsDBNull(5) ? null : reader.GetString(5),
                        Status = reader.IsDBNull(6) ? null : reader.GetString(6)
                    };
                    data.Add(client);

                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(
                    $"SQLite Error Code: {ex.SqliteErrorCode}\n{ex.Message}",
                    "SQLite Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            catch (InvalidOperationException ex)
            {
                // Connection state issues
                MessageBox.Show(
                    $"Invalid operation: {ex.Message}",
                    "Operation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // All other errors
                MessageBox.Show(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return data;

        }
    }
}
