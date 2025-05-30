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

        private int? Id;
        private string Email = "";
        private string FirstName = "";
        private string LastName = "";
        private string Address = "";
        private string PhoneNumber = "";
        private string Status = "Aktualny";
        private ClientsRepository clientsRepository;
        public DXAddNewClient(ClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
            InitializeComponent();
            this.Id = null;

        }
        public DXAddNewClient(ClientsRepository clientsRepository, int? id, string firstName, string lastName, string email, string address, string phoneNumber, string status)
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
    }
}