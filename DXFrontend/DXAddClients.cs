using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public partial class DXAddNewClient : DevExpress.XtraEditors.XtraForm
    {

        private readonly int? Id;
        private string? Email = "";
        private string? FirstName = "";
        private string? LastName = "";
        private string? Address = "";
        private string? PhoneNumber = "";
        private string? Status = "Aktualny";
        private readonly ClientsRepository clientsRepository;
        public DXAddNewClient(ClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
            InitializeComponent();
            this.Id = null;

        }
        public DXAddNewClient(ClientsRepository clientsRepository, int? id, string? firstName, string? lastName, string? email, string? address, string? phoneNumber, string? status)
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

            this.FirstNameTextBox.Text = firstName;
            this.LastNameTextBox.Text = lastName;
            this.EmailTextBox.Text = email;
            this.AddressTextBox.Text = address;
            this.PhoneNumberTextBox.Text = phoneNumber;
            if (status != "Aktualny")
            {
                StatusCheckEdit.Checked = true;
            }
            else
            {
                StatusCheckEdit.Checked = false;
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void AddClient_Click(object sender, EventArgs e)
        {
            try
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
                        this.Email, this.Address, this.PhoneNumber, this.Status).ConfigureAwait(false);
                }
                else
                {
                    await clientsRepository.UpdateClient(this.Id, this.FirstName, this.LastName,
                        this.Email, this.Address, this.PhoneNumber, this.Status).ConfigureAwait(false);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void AddNewClient_Load(object sender, EventArgs e)
        {

        }

        private void StatusCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusCheckEdit.Checked)
            {
                this.Status = "Potencjalny";
            }
            else
            {
                this.Status = "Aktualny";
            }
        }

        private void FirstNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.FirstName = FirstNameTextBox.Text;
        }

        private void LastNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.LastName = LastNameTextBox.Text;
        }

        private void AddressTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.Address = AddressTextBox.Text;
        }

        private void PhoneNumberTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void EmailTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.Email = EmailTextBox.Text;
        }

        private void PhoneNumberplus_Click(object sender, EventArgs e)
        {
            if (PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Proszę najpierw wpisać numer telefonu.");
                return;
            }
            if (PhoneNumberTextBox.Text.Length != 9)
            {
                MessageBox.Show("Proszę podać poprawny numer telefonu.");
                return;
            }
            else
            {
                PhoneNumberListBox.Items.Add(PhoneNumberTextBox.Text);
                PhoneNumberTextBox.Text = "";
            }
        }

        private void PhoneNumberMinusButton_Click(object sender, EventArgs e)
        {
            PhoneNumberListBox.Items.Remove(PhoneNumberListBox.SelectedItem);
        }

        private void EmailPlusButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Proszę najpierw wpisać adres e-mail.");
                return;
            }
            if (!EmailTextBox.Text.Contains('@'))
            {
                MessageBox.Show("Proszę podać poprawny adres e-mail.");
                return;
            }
            else
            {
                EmailListBox.Items.Add(EmailTextBox.Text);
                EmailTextBox.Text = "";
            }   
        }
        private void EmailMinusButton_Click(object sender, EventArgs e)
        {
            EmailListBox.Items.Remove(EmailListBox.SelectedItem);
        }

    }
}