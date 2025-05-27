using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public partial class MainMenuForm : Form
    {
        private string? SearchFirstName = null;
        private string? SearchLastName = null;
        private string? SearchAddress = null;
        private string? SearchPhoneNumber = null;
        private string? SearchEmail = null;
        private string? SearchStatus = null;

        public MainMenuForm()
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

        }
        private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not header
            {
                // Get data from the clicked row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string? FirstName = row.Cells["FirstName"].Value?.ToString();
                string? LastName = row.Cells["LastName"].Value?.ToString();
                string? Email = row.Cells["Email"].Value?.ToString();
                string? Address = row.Cells["Address"].Value?.ToString();
                string? PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString();
                string? Status = row.Cells["Status"].Value?.ToString();
                if (FirstName == "" || LastName == "")
                {
                    return;
                }
                // Open edit dialog
                var editForm = new AddNewClient(id, FirstName, LastName, Email, Address, PhoneNumber, Status);
                editForm.FormClosed += AddNewClientFormClosed;
                editForm.Show();
                WindowFlags.NewClient = true;
            }
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            if (!WindowFlags.NewClient)
            {
                var form = new AddNewClient();
                form.FormClosed += AddNewClientFormClosed;
                form.Show();
                WindowFlags.NewClient = true;
            }
        }

        private void AddNewClientFormClosed(object? sender, FormClosedEventArgs e)
        {
            this.LoadData();
            WindowFlags.NewClient = false; //INFO remember to replace global flag with local flag in AddNewClient.cs
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
        public void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;

            using var conn = new SqliteConnection(connectionString);
            conn.Open();
#if DEBUG
            string sql = "SELECT * FROM Clients";
#else
            string sql = "SELECT FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif

            using var cmd = new SqliteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            // Creates a DataTable to hold the data
            var dt = new DataTable();

            // Loads data directly from reader
            dt.Load(reader);

            // Binds data to DataGridView
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {

        }

        private void SearchMailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchEmail = SearchMailTextBox.Text;
        }

        private void SearchAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchAddress = SearchAddressTextBox.Text;
        }

        private void SearchFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchFirstName = SearchFirstNameTextBox.Text;
        }

        private void CleanFilters_Click(object sender, EventArgs e)
        {
            SearchFirstNameTextBox.Text = string.Empty;
            SearchLastNameTextBox.Text = string.Empty;
            SearchAddressTextBox.Text = string.Empty;
            SearchPhoneNumberTextBox.Text = string.Empty;
            SearchMailTextBox.Text = string.Empty;
            comboBox1.SelectedIndex = -1; // Clear the selected item in the combo box
            LoadData();
        }

        private void SearchLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchLastName = SearchLastNameTextBox.Text;
        }

        private void SearchPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchPhoneNumber = SearchPhoneNumberTextBox.Text;
        }


        private void Search_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;

            using var conn = new SqliteConnection(connectionString);
            conn.Open();
#if DEBUG
            string sql = "SELECT * FROM Clients";
#else
            string sql = "SELECT FirstName as Imię, LastName as Nazwisko, Email as Mail, PhoneNumber as \"Numer Telefonu\", Address as Adres, Status FROM Clients";
#endif
            sql += " WHERE 1=1";
            sql += string.IsNullOrEmpty(SearchFirstName) ? "" : " AND FirstName LIKE $firstname";
            sql += string.IsNullOrEmpty(SearchLastName) ? "" : " AND LastName LIKE $lastname";
            sql += string.IsNullOrEmpty(SearchAddress) ? "" : " AND Address LIKE $address";
            sql += string.IsNullOrEmpty(SearchPhoneNumber) ? "" : " AND PhoneNumber LIKE $phonenumber";
            sql += string.IsNullOrEmpty(SearchEmail) ? "" : " AND Email LIKE $email";
            sql += string.IsNullOrEmpty(SearchStatus) ? "" : " AND Status LIKE $status";
            using var cmd = new SqliteCommand(sql, conn);

            cmd.Parameters.AddWithValue("$firstname", '%' + this.SearchFirstName + '%');
            cmd.Parameters.AddWithValue("$lastname", '%' + this.SearchLastName + '%');
            cmd.Parameters.AddWithValue("$email", '%' + this.SearchEmail + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$address", '%' + this.SearchAddress + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$phonenumber", '%' + this.SearchPhoneNumber + '%' ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("$status", '%' + this.SearchStatus + '%' ?? (object)DBNull.Value);
            using var reader = cmd.ExecuteReader();

            // Creates a DataTable to hold the data
            var dt = new DataTable();

            // Loads data directly from reader
            dt.Load(reader);

            // Binds data to DataGridView
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchStatus = comboBox1.SelectedItem?.ToString();
        }
    }
}
