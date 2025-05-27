using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace bakk_project_task
{
    public partial class AddNewClient : Form
    {
#pragma warning disable IDE0044
        private int? Id = null;
#pragma warning restore IDE0044
        private string? Email = null;
        private string? FirstName = null;
        private string? LastName = null;
        private string? Address = null;
        private string? PhoneNumber = null;

        public AddNewClient()
        {
            InitializeComponent();
            this.Id = null;
        }
        public AddNewClient(int? id, string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
        {
            InitializeComponent();
            // add window name change?
            // "this" used for clarity, can be omitted
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.FirstNameTextBox.Text = FirstName;
            this.LastNameTextBox.Text = LastName;
            this.EmailtextBox.Text = Email;
            this.AddressTextBox.Text = Address;
            this.PhoneNumberTextBox.Text = PhoneNumber;
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
                var Cmd = conn.CreateCommand();
                string sql;
                if (Id == null)
                {
                    // New record
                    sql = @"
                        INSERT INTO Clients (FirstName, LastName, Email, Address, PhoneNumber)
                        VALUES ($firstname, $lastname, $email, $address, $phonenumber);
                        ";
                }
                else
                {
                    // Existing record
                    sql = @"
                    UPDATE Clients SET FirstName = $firstname, LastName = $lastname,
                    Email = $email, Address = $address, PhoneNumber = $phonenumber WHERE Id = $id
                    ;";
                    
                }
                Cmd.CommandText = sql;
                Cmd.Parameters.AddWithValue("$id", this.Id);
                Cmd.Parameters.AddWithValue("$firstname", this.FirstName);
                Cmd.Parameters.AddWithValue("$lastname", this.LastName);
                Cmd.Parameters.AddWithValue("$email", this.Email ?? (object)DBNull.Value);
                Cmd.Parameters.AddWithValue("$address", this.Address ?? (object)DBNull.Value);
                Cmd.Parameters.AddWithValue("$phonenumber", this.PhoneNumber ?? (object)DBNull.Value);
                int rowsAffected = Cmd.ExecuteNonQuery();                
                conn.Close();
            }
            this.Close();
        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {
            this.Email = EmailtextBox.Text;
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.FirstName = FirstNameTextBox.Text;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.LastName = LastNameTextBox.Text;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Address = AddressTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void AddNewClient_Load(object sender, EventArgs e)
        {

        }
    }
}
