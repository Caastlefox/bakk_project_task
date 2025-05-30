using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private ClientsRepository clientsRepository;
        public DXMainMenuForm(ClientsRepository clientsRepository)
        {
            InitializeComponent();
            //dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            this.clientsRepository = clientsRepository;
        }

        private async void DXMainMenuForm_Load(object sender, EventArgs e)
        {
            await clientsRepository.LoadClient(gridcontrol1);

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            var form = new DXAddNewClient(clientsRepository);
            form.Show();
        }

        private void EditClientButton_Click(object sender, EventArgs e)
        {
            ////DataGridViewRow? row = dataGridView1.CurrentRow;
            //if (row == null || row.Cells["Id"].Value == null)
            //{
            //    MessageBox.Show("No client selected or invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //int id = Convert.ToInt32(row.Cells["Id"].Value);
            //string? FirstName = row.Cells["FirstName"].Value?.ToString();
            //string? LastName = row.Cells["LastName"].Value?.ToString();
            //string? Email = row.Cells["Email"].Value?.ToString();
            //string? Address = row.Cells["Address"].Value?.ToString();
            //string? PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString();
            //string? Status = row.Cells["Status"].Value?.ToString();

            //if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            //{
            //    MessageBox.Show("First Name or Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //var editForm = new AddNewClient(clientsRepository, id, FirstName, LastName, Email, Address, PhoneNumber, Status);
            //editForm.FormClosed += AddNewClientFormClosed;
            //editForm.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
        private void AddNewClientFormClosed(object sender, FormClosedEventArgs e)
        {
            // this.clientsRepository.LoadClient(dataGridView1); ;
        }

        private void gridcontrol1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SearchFirstName_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchFirstName = FirstNameTextEdit.Text;
        }


        private void gridcontrol1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            clientsRepository.SearchClients(gridcontrol1, this.SearchFirstName, SearchLastName, SearchAddress, SearchPhoneNumber, SearchEmail, SearchStatus);
        }

        private void LastNameTextBox_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchLastName = LastNameTextEdit.Text;
        }

        private void AdressTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchAddress = AddressTextEdit.Text;
        }

        private void PhoneNumberTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchPhoneNumber = PhoneNumberTextEdit.Text;
        }

        private void EmailTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.SearchEmail = EmailTextEdit.Text;
        }

        private void StatusCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
