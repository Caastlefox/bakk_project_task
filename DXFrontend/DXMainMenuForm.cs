using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace bakk_project_task
{
    public partial class DXMainMenuForm : DevExpress.XtraEditors.XtraForm
    {
        private string SearchFirstName = "";
        private string SearchLastName = "";
        private string SearchAddress = "";
        private string SearchPhoneNumber = "";
        private string SearchEmail = "";
        private string SearchStatus = "";
        private bool BlankPhoneNumberFlag;
        private bool BlankEmailFlag;
        private readonly ClientRepository clientsRepository;
        private readonly TableController EmailController;
        private readonly TableController PhoneNumberController;
        public DXMainMenuForm(ClientRepository clientsRepository)
        {
            InitializeComponent();
            EmailController = new TableController("Client", "Email");
            PhoneNumberController = new TableController("Client", "PhoneNumber");
            this.clientsRepository = clientsRepository;
        }

        [SupportedOSPlatform("windows6.1")]
        private async void DXMainMenuForm_Load(object sender, EventArgs e)
        {
            await clientsRepository.LoadClient(gridcontrol1);
            StatusCheckEdit.Checked = false;
            gridcontrol1.Refresh();


            if (gridView1.RowCount > 0)
            {
                gridView1.FocusedRowHandle = 0; // Focus first row
                gridView1.SelectRow(0);         // Select first row
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [SupportedOSPlatform("windows6.1")]
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            using var form = new DXAddNewClient(clientsRepository,EmailController,PhoneNumberController);
            form.FormClosed += AddNewClientFormClosed;
            form.ShowDialog(this);
        }

        [SupportedOSPlatform("windows6.1")]
        private void EditClientButton_Click(object sender, EventArgs e)
        {
            var gridView = gridcontrol1.MainView as GridView;
            if (gridView is null || gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("No client selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long id = Convert.ToInt64(gridView.GetFocusedRowCellValue("Id"));

            string? FirstName = gridView.GetFocusedRowCellValue("Imię") as string;
            string? LastName = gridView.GetFocusedRowCellValue("Nazwisko") as string;
            string? Address = gridView.GetFocusedRowCellValue("Adres") as string;
            string? Status = gridView.GetFocusedRowCellValue("Status") as string;


            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("First Name or Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using var editForm = new DXAddNewClient(clientsRepository, EmailController, PhoneNumberController, id, FirstName, LastName, Address, Status);
            editForm.FormClosed += AddNewClientFormClosed;
            editForm.ShowDialog();
        }

        [SupportedOSPlatform("windows6.1")]
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show
            (
                "Are you sure you want to delete this client?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                var gridView = gridcontrol1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (gridView == null || gridView.FocusedRowHandle < 0)
                {
                    MessageBox.Show("No client selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long id = Convert.ToInt64(gridView.GetFocusedRowCellValue("Id"));
                await clientsRepository.DeleteClient(id);
                await this.clientsRepository.LoadClient(gridcontrol1);
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private async void AddNewClientFormClosed(object? sender, FormClosedEventArgs e)
        {
            await this.clientsRepository.LoadClient(gridcontrol1);
        }

        [SupportedOSPlatform("windows6.1")]
        private void Gridcontrol1_DoubleClick(object sender, EventArgs e)
        {
            var gridView = gridcontrol1.MainView as GridView;
            if (gridView == null || gridView.FocusedRowHandle < 0)
            {
                MessageBox.Show("No client selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long id = Convert.ToInt64(gridView.GetFocusedRowCellValue("Id"));

            string? FirstName = gridView.GetFocusedRowCellValue("Imię")?.ToString();
            string? LastName = gridView.GetFocusedRowCellValue("Nazwisko")?.ToString();
            string? Address = gridView.GetFocusedRowCellValue("Adres")?.ToString();
            string? Status = gridView.GetFocusedRowCellValue("Status")?.ToString();

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("First Name or Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using var editForm = new DXAddNewClient(clientsRepository, EmailController, PhoneNumberController, id, FirstName, LastName, Address, Status);
            editForm.FormClosed += AddNewClientFormClosed;
            editForm.ShowDialog();
        }

        [SupportedOSPlatform("windows6.1")]
        private void SearchFirstName_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchFirstName = FirstNameTextEdit.Text;

        }

        private void Gridcontrol1_Click(object sender, EventArgs e)
        {

        }

        [SupportedOSPlatform("windows6.1")]
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            var data = await clientsRepository.SearchClients(this.SearchFirstName, this.SearchLastName, this.SearchAddress, 
                        this.SearchPhoneNumber, this.SearchEmail, this.SearchStatus,this.BlankEmailFlag,this.BlankPhoneNumberFlag);
            this.gridcontrol1.DataSource = data;
            this.gridcontrol1.MainView.PopulateColumns();
            this.gridcontrol1.Refresh();
        }

        [SupportedOSPlatform("windows6.1")]
        private void LastNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchLastName = LastNameTextEdit.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void AdressTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchAddress = AddressTextEdit.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void PhoneNumberTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchPhoneNumber = PhoneNumberTextEdit.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void EmailTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchEmail = EmailTextEdit.Text;
        }

        [SupportedOSPlatform("windows6.1")]
        private void StatusCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (StatusCheckEdit.Checked)
            {
                this.SearchStatus = "Potencjalny";
            }
            else
            {
                this.SearchStatus = "Aktualny";
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private async void ClearFiltersButton_Click(object sender, EventArgs e)
        {

            FirstNameTextEdit.Text = "";
            LastNameTextEdit.Text = "";
            AddressTextEdit.Text = "";
            PhoneNumberTextEdit.Text = "";
            EmailTextEdit.Text = "";
            StatusCheckEdit.Checked = false;
            SearchStatus = "";
            BlankPhoneCheckEdit.Checked = false;
            blankEmail.Checked = false;
            await clientsRepository.LoadClient(gridcontrol1);
        }

        [SupportedOSPlatform("windows6.1")]
        private void BlankPhoneCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (BlankPhoneCheckEdit.Checked)
            {
                this.PhoneNumberTextEdit.Text = "";
                this.SearchPhoneNumber = "";
                PhoneNumberTextEdit.Enabled = false;
                this.BlankPhoneNumberFlag = true;
            }
            else
            {
                PhoneNumberTextEdit.Enabled = true;
                this.BlankPhoneNumberFlag = false;
            }
        }

        [SupportedOSPlatform("windows6.1")]
        private void BlankEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (blankEmail.Checked)
            {
                this.EmailTextEdit.Text = "";
                this.SearchEmail = "";
                EmailTextEdit.Enabled = false;
                this.BlankEmailFlag = true;
            }
            else
            {
                EmailTextEdit.Enabled = true;
                this.BlankEmailFlag = false;
            }
        }
    }
}
