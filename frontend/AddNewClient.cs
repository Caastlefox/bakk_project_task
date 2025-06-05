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

        private readonly int? Id = null;
        private string? Email = "";
        private string? FirstName = "";
        private string? LastName = "";
        private string? Address = "";
        private string? PhoneNumber = "";
        private string? Status = "Aktualny";
        private readonly ClientRepository clientsRepository;
        public AddNewClient(ClientRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
            InitializeComponent();
            this.Id = null;
            
        }
        public AddNewClient(ClientRepository clientsRepository, int? id, string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
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

        private async void AddClient_Click(object sender, EventArgs e)
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
                await clientsRepository.AddClient(this.FirstName, this.LastName,
                    this.Email, this.Address, this.PhoneNumber, this.Status);
            }
            else
            {
                await clientsRepository.UpdateClient(this.Id, this.FirstName, this.LastName,
                    this.Email, this.Address, this.PhoneNumber, this.Status);
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
