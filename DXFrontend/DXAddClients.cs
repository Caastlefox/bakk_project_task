using DevExpress.Charts.Model;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakk_project_task
{
    public partial class DXAddNewClient : DevExpress.XtraEditors.XtraForm
    {
        private readonly int Id = -1;
        private string? FirstName = "";
        private string? LastName = "";
        private string? Address = "";
        private string? PhoneNumber = "";
        private string? Status = "Aktualny";
        private readonly ClientRepository clientsRepository;
        private TableController EmailController;
        private TableController PhoneNumberController;

        public DXAddNewClient(ClientRepository clientsRepository, TableController EmailController, TableController PhoneNumberController)
        {
            InitializeComponent();
            this.clientsRepository = clientsRepository;
            this.EmailController = EmailController;
            this.PhoneNumberController = PhoneNumberController;
        }

        [SupportedOSPlatform("windows6.1")]
        public DXAddNewClient(ClientRepository clientsRepository, TableController EmailController, TableController PhoneNumberController, int id, string? firstName, string? lastName, string? address, string? phoneNumber, string? status)
        {
            InitializeComponent();
            this.clientsRepository = clientsRepository;
            this.EmailController = EmailController;
            this.PhoneNumberController = PhoneNumberController;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;

            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Status = status;

            this.FirstNameTextBox.Text = firstName;
            this.LastNameTextBox.Text = lastName;
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

            this.EmailController.ReceiveFromDatabase(Id).GetAwaiter().GetResult();
            this.EmailController.SendToGridControl(EmailGridControl);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        [SupportedOSPlatform("windows6.1")]
        private async void AddClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {
                    MessageBox.Show("Pola Imię i Nazwisko muszą być wypełnione.");
                    return;
                }
                //if (!string.IsNullOrWhiteSpace(Email) && !Email.Contains('@'))
                //{
                //    MessageBox.Show("Proszę podać poprawny adres e-mail.");
                //    return;
                //}
                if (!string.IsNullOrWhiteSpace(PhoneNumber) && PhoneNumber.Length != 9)
                {
                    MessageBox.Show("Proszę podać poprawny numer telefonu.");
                    return;
                }
                if (Id == -1)
                {
                    await clientsRepository.AddClient(this.FirstName, this.LastName,
                         this.Address, this.PhoneNumber, this.Status).ConfigureAwait(false);
                }
                else
                {
                    await clientsRepository.UpdateClient(this.Id, this.FirstName, this.LastName,
                         this.Address, this.PhoneNumber, this.Status).ConfigureAwait(false);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private void AddNewClient_Load(object sender, EventArgs e)
        {

        }

        [SupportedOSPlatform("windows6.1")]
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

        [SupportedOSPlatform("windows6.1")]
        private void FirstNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.FirstName = FirstNameTextBox.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void LastNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.LastName = LastNameTextBox.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void AddressTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.Address = AddressTextBox.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void PhoneNumberTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.PhoneNumber = PhoneNumberTextBox.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void EmailTextBox_EditValueChanged(object sender, EventArgs e)
        {
            //this.Email = EmailTextBox.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void PhoneNumberMinusButton_Click(object sender, EventArgs e)
        {
            var gridView = PhoneNumberGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView == null || gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("Zaznacz Dane.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var PhoneNumber = (gridView.GetFocusedRow() as Entry)?.Name;

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                MessageBox.Show("Pole Puste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PhoneNumberController.RemoveElement(PhoneNumber);
                PhoneNumberController.SendToGridControl(PhoneNumberGridControl);
            }
        }

        [SupportedOSPlatform("windows6.1")]
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
                EmailController.AddElement(EmailTextBox.Text);
                EmailController.SendToGridControl(EmailGridControl);
                EmailTextBox.Text = "";
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private void EmailMinusButton_Click(object sender, EventArgs e)
        {
            var gridView = EmailGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView == null || gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("Zaznacz Dane.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Email = (gridView.GetFocusedRow() as Entry)?.Name;

            if (string.IsNullOrWhiteSpace(Email))
            {
                MessageBox.Show("Pole Puste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                EmailController.RemoveElement(Email);
                EmailController.SendToGridControl(EmailGridControl);
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private void PhoneNumberPlusButton_Click(object sender, EventArgs e)
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
                PhoneNumberController.AddElement(PhoneNumberTextBox.Text);
                PhoneNumberController.SendToGridControl(PhoneNumberGridControl);
                PhoneNumberTextBox.Text = "";

            }
        }

        private void EmailGridControl_Click(object sender, EventArgs e)
        {
            var gridView = EmailGridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView == null || gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("ZaznaczDane.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string? Email = gridView.GetFocusedRowCellValue("Email")?.ToString();

        }
    }
}