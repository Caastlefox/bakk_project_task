using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace bakk_project_task
{
    public partial class AddNewClient : Form
    {
        private string Email = string.Empty;
        private string FirstName = string.Empty;
        private string LastName = string.Empty;
        private string Address = string.Empty;
        private string PhoneNumber = string.Empty;

        public AddNewClient()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("Pola Imię i Nazwisko muszą być wypełnione.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(Email) && !Email.Contains('@'))
            {
                MessageBox.Show("Proszę podać poprawny adres e-mail.");
                return;
            }
            if (!string.IsNullOrWhiteSpace(PhoneNumber) && PhoneNumber.Length != 9)
            {
                MessageBox.Show("Proszę podać poprawny numer telefonu.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
            using (var conn = new SqliteConnection(connectionString))
            //Insert data
            {
                conn.Open();
                var insertCmd = conn.CreateCommand();
                insertCmd.CommandText =
                @"
                INSERT INTO Clients (FirstName, LastName, Email)
                VALUES ($firstname, $lastname, $email);
                ";
                insertCmd.Parameters.AddWithValue("$firstname", FirstName);
                insertCmd.Parameters.AddWithValue("$lastname", LastName);
                insertCmd.Parameters.AddWithValue("$email", Email ?? (object)DBNull.Value);
                insertCmd.Parameters.AddWithValue("$address", Address ?? (object)DBNull.Value);
                insertCmd.Parameters.AddWithValue("$phonenumber", PhoneNumber ?? (object)DBNull.Value);
                insertCmd.ExecuteNonQuery();
                conn.Close();
                
            }
            this.Close();
        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {
            Email = EmailtextBox.Text;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FirstName = FirstNameTextBox.Text;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            LastName = LastNameTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            Address = AddressTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void AddNewClient_Load(object sender, EventArgs e)
        {

        }
    }
}
