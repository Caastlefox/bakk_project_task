using DevExpress.Charts.Model;
using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraRichEdit.Tables.Native;
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
        private long Id = -1;
        private string? FirstName = "";
        private string? LastName = "";
        private string? Address = "";
        private string? PhoneNumber = "";
        private string? Status = "Aktualny";
        private readonly ClientRepository clientsRepository;
        private readonly TableController EmailController;
        private readonly TableController PhoneNumberController;

        public DXAddNewClient(ClientRepository clientsRepository, TableController EmailController, TableController PhoneNumberController)
        {
            InitializeComponent();
            this.clientsRepository = clientsRepository;
            this.EmailController = EmailController;
            this.PhoneNumberController = PhoneNumberController;
        }

        [SupportedOSPlatform("windows6.1")]
        public DXAddNewClient(ClientRepository clientsRepository, TableController EmailController, TableController PhoneNumberController,

            long id, string? firstName, string? lastName, string? address, string? status)
        {
            InitializeComponent();
            this.clientsRepository = clientsRepository;
            this.EmailController = EmailController;
            this.PhoneNumberController = PhoneNumberController;
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Status = status;

            this.FirstNameTextBox.Text = this.FirstName;
            this.LastNameTextBox.Text = this.LastName;
            this.AddressTextBox.Text = this.Address;

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

                if (Id == -1)
                {
                    Id = await clientsRepository.AddClient(this.FirstName, this.LastName,
                         this.Address, this.Status);
                }
                else
                {
                    await clientsRepository.UpdateClient(this.Id, this.FirstName, this.LastName,
                         this.Address, this.Status);

                }
                await EmailController.SendToDataBase(Id);
                await PhoneNumberController.SendToDataBase(Id);

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
            this.EmailController.ReceiveFromDatabase(Id).GetAwaiter().GetResult();
            this.EmailController.SendToGridControl(EmailGridControl);
            this.PhoneNumberController.ReceiveFromDatabase(Id).GetAwaiter().GetResult();
            this.PhoneNumberController.SendToGridControl(PhoneNumberGridControl);
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
            //this.PhoneNumber = PhoneNumberTextBox.Text;
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
                MessageBox.Show("Żadne dane nie zostały zaznaczone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            char Tag = Convert.ToChar(EmailGridView.GetFocusedRowCellValue("Tag"));

            if (Tag == 'D')
            {
                string Name = Convert.ToString(EmailGridView.GetFocusedRowCellValue("Name")) ?? "";
                EmailGridView.PostEditor();               // Commit editor changes
                EmailGridView.UpdateCurrentRow();
                EmailController.ChangeTag(Name, '\0');
                EmailController.SendToGridControl(EmailGridControl);
                return;
            }

            if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Proszę najpierw wpisać adres e-mail.");

            }
            else if (!EmailTextBox.Text.Contains('@'))
            {
                MessageBox.Show("Proszę podać poprawny adres e-mail.");
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
                MessageBox.Show("Żadne dane nie zostały zaznaczone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            char Tag = Convert.ToChar(PhoneNumberGridView.GetFocusedRowCellValue("Tag"));
            
            if (Tag == 'D')
            {
                string Name = Convert.ToString(PhoneNumberGridView.GetFocusedRowCellValue("Name")) ?? "";
                PhoneNumberGridView.PostEditor();               // Commit editor changes
                PhoneNumberGridView.UpdateCurrentRow();
                PhoneNumberController.ChangeTag(Name, '\0');
                return;
            }

            if (PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Proszę najpierw wpisać numer telefonu.");
            }
            else if (PhoneNumberTextBox.Text.Length != 9 || long.TryParse(PhoneNumberTextBox.Text, out _) == false)
            {
                MessageBox.Show("Proszę podać numer telefonu składający się z 9 cyfr.");
            }
            else
            {
                PhoneNumberController.AddElement(PhoneNumberTextBox.Text);
                PhoneNumberTextBox.Text = "";
            }
            PhoneNumberController.SendToGridControl(PhoneNumberGridControl);
        }

        private void DXAddNewClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmailController.ClearControllerList();
            PhoneNumberController.ClearControllerList();
        }

        private void EmailGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string fieldName = ((ColumnView)sender).FocusedColumn.FieldName;

            string oldValue = e.OldValue.ToString()!;
            string newValue = e.Value.ToString()!;
            if (!newValue.Contains('@') && newValue.Length != 0)// beware of ||, causes stack overflow
            {
                ((ColumnView)sender).SetRowCellValue(e.RowHandle, e.Column, oldValue);
                MessageBox.Show("Adres e-mail powinien posiadać znak @.");
                return;
            }
            if (Convert.ToChar(((ColumnView)sender).GetRowCellValue(e.RowHandle, "Tag")) == 'A')
            {
                return;
            }
            else if (newValue.Length == 0)
            {
                EmailController.ChangeTag(newValue, 'D');
                return;
            }
            else 
            { 
                EmailController.ChangeTag(newValue, 'M'); 
            }
            
        }

        private void PhoneNumberGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            string fieldName = ((ColumnView)sender).FocusedColumn.FieldName;

            string oldValue = e.OldValue.ToString()!;
            string newValue = e.Value.ToString()!;
            if (long.TryParse(newValue, out _) == false) 
            {
                ((ColumnView)sender).SetRowCellValue(e.RowHandle, e.Column, oldValue);
                MessageBox.Show("Proszę podać numer telefonu składający się z 9 cyfr.");
                return;
            }
            if ( Convert.ToChar(((ColumnView)sender).GetRowCellValue(e.RowHandle, "Tag")) == 'A')
            {
                return;
            }
            switch (newValue.Length)
            {
                case (9):
                    {
                        PhoneNumberController.ChangeTag(newValue, 'M');
                        break;
                    }
                case (0):
                    {
                        PhoneNumberController.ChangeTag(newValue, 'D');
                        break;
                    }
                default:
                    {
                        ((ColumnView)sender).SetRowCellValue(e.RowHandle, e.Column, oldValue);
                        MessageBox.Show("Proszę podać numer telefonu składający się z 9 cyfr.");
                        return;
                    }
            }
        }
    }
}