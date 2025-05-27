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

            string sql = "SELECT FirstName, LastName, Email, PhoneNumber, Status FROM Clients";
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
