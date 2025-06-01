using DevExpress.XtraGrid;
using DevExpress.XtraRichEdit.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public class ClientsRepository : IClientRepository
    {
        private readonly string connectionString;
        public ClientsRepository()
        {
            var conn = ConfigurationManager.ConnectionStrings["SQLiteConnection"]?.ConnectionString;
            if (string.IsNullOrEmpty(conn))
            {
                throw new InvalidOperationException("Connection string 'SQLiteConnection' is not configured.");
            }
            connectionString = conn;
        }
        [SupportedOSPlatform("windows6.1")]
        public async Task AddClient(string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
        {
            try
            {
                using var connection = new SqliteConnection(connectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                INSERT INTO Clients (FirstName, LastName, Email, Address, PhoneNumber, Status)
                VALUES ($firstName, $lastName, $email, $address, $phoneNumber, $status);
                ";
                command.Parameters.AddWithValue("$firstName", firstName);
                command.Parameters.AddWithValue("$lastName", lastName);
                command.Parameters.AddWithValue("$email", email);
                command.Parameters.AddWithValue("$address", address);
                command.Parameters.AddWithValue("$phoneNumber", phoneNumber);
                command.Parameters.AddWithValue("$status", status);
                await command.ExecuteNonQueryAsync();
                // Can make it into message, returns rows
                //
                // MessageBox.Show($"Inserted {rows} row(s)!", "Success",
                // MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public async Task UpdateClient(int? id, string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
        {
            try
            {
                using var connection = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                UPDATE Clients
                SET FirstName = $firstName, LastName = $lastName, Email = $email, Address = $address, PhoneNumber = $phoneNumber, Status = $status
                WHERE Id = $id;
            ";
                command.Parameters.AddWithValue("$id", id);
                command.Parameters.AddWithValue("$firstName", firstName);
                command.Parameters.AddWithValue("$lastName", lastName);
                command.Parameters.AddWithValue("$email", email);
                command.Parameters.AddWithValue("$address", address);
                command.Parameters.AddWithValue("$phoneNumber", phoneNumber);
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
#if DEBUG
                string sql = "SELECT * FROM Clients";
#else
                string sql = "SELECT Id, FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif
                command.CommandText = sql;
                using var cmd = new SqliteCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                var dt = new DataTable();
                await reader.ReadAsync();

                dt.Load(reader);

                dataGridView.DataSource = dt;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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
        public async Task LoadClient(GridControl dataGridView)
        {
            try
            {
                using var conn = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await conn.OpenAsync();
                var command = conn.CreateCommand();
#if DEBUG
                string sql = "SELECT * FROM Clients";
#else
                string sql = "SELECT Id, FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif
                command.CommandText = sql;
                using var cmd = new SqliteCommand(sql, conn);
                using var reader = await cmd.ExecuteReaderAsync();
                await reader.ReadAsync();

                var dt = new DataTable("Clients");
                dt.Load(reader);

                dataGridView.DataSource = dt;
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
        public async Task DeleteClient(int? id)
        {
            try
            {
                using var connection = new SqliteConnection(ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString);
                await connection.OpenAsync();
                var command = connection.CreateCommand();
                command.CommandText = @"
                DELETE FROM Clients WHERE Id = $id;
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
        public void SearchClients(DataGridView dataGridView, string SearchFirstName, string SearchLastName, string SearchAddress, string SearchPhoneNumber, string SearchEmail, string? SearchStatus)
        {

            using var conn = new SqliteConnection(connectionString);
            conn.Open();
#if DEBUG
            string sql = "SELECT * FROM Clients";
#else
            string sql = "SELECT Id, FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif
            sql += " WHERE 1=1";
            sql += string.IsNullOrEmpty(SearchFirstName) ? "" : " AND FirstName LIKE $firstname";
            sql += string.IsNullOrEmpty(SearchLastName) ? "" : " AND LastName LIKE $lastname";
            sql += string.IsNullOrEmpty(SearchAddress) ? "" : " AND Address LIKE $address";
            sql += string.IsNullOrEmpty(SearchPhoneNumber) ? "" : " AND PhoneNumber LIKE $phonenumber";
            sql += string.IsNullOrEmpty(SearchEmail) ? "" : " AND Email LIKE $email";
            sql += string.IsNullOrEmpty(SearchStatus) ? "" : " AND Status LIKE $status";
            using var cmd = new SqliteCommand(sql, conn);

            cmd.Parameters.AddWithValue("$firstname", '%' + SearchFirstName + '%');
            cmd.Parameters.AddWithValue("$lastname", '%' + SearchLastName + '%');
            cmd.Parameters.AddWithValue("$email", '%' + SearchEmail + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$address", '%' + SearchAddress + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$phonenumber", '%' + SearchPhoneNumber + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$status", '%' + SearchStatus + '%' ?? (object)DBNull.Value);
            using var reader = cmd.ExecuteReader();

            // Creates a DataTable to hold the data
            var dt = new DataTable();

            // Loads data directly from reader
            dt.Load(reader);

            // Binds data to DataGridView
            dataGridView.DataSource = dt;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void SearchClients(GridControl dataGridView, string SearchFirstName,
            string SearchLastName, string SearchAddress, string SearchPhoneNumber, 
            string SearchEmail, string? SearchStatus, bool blankEmailflag = false,
            bool blankTelephoneflag = false)
        {
            try
            {
                using var conn = new SqliteConnection(connectionString);
                conn.Open();
#if DEBUG
                string sql = "SELECT * FROM Clients";
#else
                string sql = "SELECT Id, FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif

                sql += " WHERE 1=1";
                sql += string.IsNullOrEmpty(SearchFirstName) ? "" : " AND FirstName LIKE $firstname";
                sql += string.IsNullOrEmpty(SearchLastName) ? "" : " AND LastName LIKE $lastname";
                sql += string.IsNullOrEmpty(SearchAddress) ? "" : " AND Address LIKE $address";
                if (blankTelephoneflag)
                {
                    sql += string.IsNullOrEmpty(SearchEmail) ? " AND Email = \"\"" : "";
                }
                {
                    sql += string.IsNullOrEmpty(SearchPhoneNumber) ? "" : " AND PhoneNumber LIKE $phonenumber";
                }
                if (blankEmailflag)
                {
                    sql += string.IsNullOrEmpty(SearchEmail) ? " AND Email = \"\"": "";
                }
                else
                {
                    sql += string.IsNullOrEmpty(SearchEmail) ? "" : " AND Email LIKE $email";
                }
                sql += string.IsNullOrEmpty(SearchStatus) ? "" : " AND Status LIKE $status";
                using var cmd = new SqliteCommand(sql, conn);

                cmd.Parameters.AddWithValue("$firstname", '%' + SearchFirstName + '%');
                cmd.Parameters.AddWithValue("$lastname", '%' + SearchLastName + '%');
                cmd.Parameters.AddWithValue("$email", '%' + SearchEmail + '%' ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("$address", '%' + SearchAddress + '%' ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("$phonenumber", '%' + SearchPhoneNumber + '%' ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("$status", '%' + SearchStatus + '%' ?? (object)DBNull.Value);
                using var reader = cmd.ExecuteReader();

                // Creates a DataTable to hold the data
                var dt = new DataTable();

                // Loads data directly from reader
                dt.Load(reader);

                // Binds data to DataGridView
                dataGridView.DataSource = dt;
                dataGridView.MainView.PopulateColumns();
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
    }
}
