using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace bakk_project_task
{
    public partial class AddNewClient : Form
    {

        private int? Id = null;
        private string? Email = "";
        private string? FirstName = "";
        private string? LastName = "";
        private string? Address = "";
        private string? PhoneNumber = "";
        private string? Status = "Aktualny";
        private ClientsRepository clientsRepository;
        public AddNewClient(ClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
            InitializeComponent();
            this.Id = null;
            
        }
        public AddNewClient(ClientsRepository clientsRepository, int? id, string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
        {
            InitializeComponent();
            this.clientsRepository = clientsRepository;
            // "this" used for clarity, can be omitted
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Status = status;
            
            this.FirstNameTextBox.Text = FirstName;
            this.LastNameTextBox.Text = LastName;
            this.EmailtextBox.Text = Email;
            this.AddressTextBox.Text = Address;
            this.PhoneNumberTextBox.Text = PhoneNumber;
            if (Status != "Aktualny")
            {
                checkBox1.Checked = true;
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Status = "Potencjalny";
            }
            else
            {
                this.Status = "Aktualny";
            }

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
            if (Id == null)
            {
                clientsRepository.AddClient(this.FirstName, this.LastName,
                this.Email, this.Address, this.PhoneNumber, this.Status);
            }
            else 
            {
                clientsRepository.UpdateClient(this.Id, this.FirstName, this.LastName,
                this.Email, this.Address, this.PhoneNumber, this.Status);
            }
            //string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
            //using (var conn = new SqliteConnection(connectionString))
            ////Insert data
            //{
            //    conn.Open();
            //    var Cmd = conn.CreateCommand();
            //    string sql;
            //    if (Id == null)
            //    {
            //        // New record
            //        sql = @"
            //            INSERT INTO Clients (FirstName, LastName, Email, Address, PhoneNumber, Status)
            //            VALUES ($firstname, $lastname, $email, $address, $phonenumber, $status);
            //            ";
            //    }
            //    else
            //    {
            //        // Existing record
            //        sql = @"
            //        UPDATE Clients SET FirstName = $firstname, LastName = $lastname,
            //        Email = $email, Address = $address, PhoneNumber = $phonenumber, Status = $status WHERE Id = $id
            //        ;";
                    
            //    }
            //    Cmd.CommandText = sql;
            //    Cmd.Parameters.AddWithValue("$id", this.Id);
            //    Cmd.Parameters.AddWithValue("$firstname", this.FirstName);
            //    Cmd.Parameters.AddWithValue("$lastname", this.LastName);
            //    Cmd.Parameters.AddWithValue("$email", this.Email ?? (object)DBNull.Value);
            //    Cmd.Parameters.AddWithValue("$address", this.Address ?? (object)DBNull.Value);
            //    Cmd.Parameters.AddWithValue("$phonenumber", this.PhoneNumber ?? (object)DBNull.Value);
            //    Cmd.Parameters.AddWithValue("$status", this.Status);
            //    Cmd.ExecuteNonQuery();                
            //    conn.Close();
            //}
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
