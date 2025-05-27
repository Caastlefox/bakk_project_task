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
                string? FirstName = row.Cells["FirstName"].Value?.ToString();
                string? LastName = row.Cells["LastName"].Value?.ToString();
                string? Email = row.Cells["Email"].Value?.ToString();   
                string? Address = row.Cells["Address"].Value?.ToString();
                string? PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString();
                string? Status = row.Cells["Status"].Value?.ToString();

                // Open edit dialog
                var editForm = new AddNewClient(FirstName,LastName,Email,Address,PhoneNumber,Status);
                // Reloads data if something was updated
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
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

            string sql = "SELECT FirstName, LastName, Email, PhoneNumber, Address, Status FROM Clients";
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
    }
}
