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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace bakk_project_task
{
    public partial class MainMenuForm : Form
    {
        private string? SearchFirstName = null;
        private string? SearchLastName = null;
        private string? SearchAddress = null;
        private string? SearchPhoneNumber = null;
        private string? SearchEmail = null;
        private string? SearchStatus = null;
        private bool BlankPhoneNumberFlag;
        private bool BlankEmailFlag;
        private readonly ClientRepository clientsRepository;

        public MainMenuForm(ClientRepository clientsRepository)
        {
            InitializeComponent();
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            this.clientsRepository = clientsRepository;
        }
        private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure it's not header
            {
                // Get data from the clicked row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                long id = Convert.ToInt64(row.Cells["Id"].Value);
                string? FirstName = row.Cells["FirstName"].Value?.ToString();
                string? LastName = row.Cells["LastName"].Value?.ToString();
                string? Email = row.Cells["Email"].Value?.ToString();
                string? Address = row.Cells["Address"].Value?.ToString();
                string? PhoneNumber = row.Cells["PhoneNumber"].Value?.ToString();
                string? Status = row.Cells["Status"].Value?.ToString();
                if (FirstName == "" || LastName == "")
                {
                    return;
                }
                // Open edit dialog
                var editForm = new AddNewClient(clientsRepository, id, FirstName, LastName, Email, Address, PhoneNumber, Status);
                editForm.FormClosed += AddNewClientFormClosed;
                editForm.ShowDialog();
            }
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            var form = new AddNewClient(clientsRepository);
            form.FormClosed += AddNewClientFormClosed;
            form.Show();

        }

        private async void AddNewClientFormClosed(object? sender, FormClosedEventArgs e)
        {
            await this.clientsRepository.LoadClient(dataGridView1);
        }


        private async void MainMenuForm_Load(object sender, EventArgs e)
        {
            await clientsRepository.LoadClient(dataGridView1);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            DataGridViewRow? row = dataGridView1.CurrentRow;
            if (row == null || row.Cells["Id"].Value == null)
            {
                MessageBox.Show("No client selected or invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long id = Convert.ToInt64(row.Cells["Id"].Value);

            string? FirstName = row.Cells["Imię"].Value?.ToString();
            string? LastName = row.Cells["Nazwisko"].Value?.ToString();
            string? Email = row.Cells["Mail"].Value?.ToString();
            string? Address = row.Cells["Adres"].Value?.ToString();
            string? PhoneNumber = row.Cells["Numer Telefonu"].Value?.ToString();
            string? Status = row.Cells["Status"].Value?.ToString();

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
            {
                MessageBox.Show("First Name or Last Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editForm = new AddNewClient(clientsRepository, id, FirstName, LastName, Email, Address, PhoneNumber, Status);
            editForm.FormClosed += AddNewClientFormClosed;
            editForm.Show();
        }

        private void SearchMailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchEmail = SearchMailTextBox.Text;
        }

        private void SearchAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchAddress = SearchAddressTextBox.Text;
        }

        private void SearchFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchFirstName = SearchFirstNameTextBox.Text;
        }

        private async void CleanFilters_Click(object sender, EventArgs e)
        {
            SearchFirstNameTextBox.Text = string.Empty;
            SearchLastNameTextBox.Text = string.Empty;
            SearchAddressTextBox.Text = string.Empty;
            SearchPhoneNumberTextBox.Text = string.Empty;
            SearchMailTextBox.Text = string.Empty;
            BlankPhoneNumberCheckBox.Checked = false;
            BlankMailcheckBox.Checked = false;
            comboBox1.SelectedIndex = -1; // Clear the selected item in the combo box
            await clientsRepository.LoadClient(dataGridView1);
        }

        private void SearchLastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchLastName = SearchLastNameTextBox.Text;
        }

        private void SearchPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SearchPhoneNumber = SearchPhoneNumberTextBox.Text;
        }


        private void Search_Click(object sender, EventArgs e)
        {
            clientsRepository.SearchClients(this.dataGridView1, SearchFirstNameTextBox.Text, SearchLastNameTextBox.Text, SearchAddressTextBox.Text, SearchPhoneNumberTextBox.Text, SearchMailTextBox.Text, SearchStatus,BlankEmailFlag,BlankPhoneNumberFlag);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SearchStatus = comboBox1.SelectedItem?.ToString();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void DeleteClientButton_Click(object sender, EventArgs e)
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
                DataGridViewRow? row = dataGridView1.CurrentRow;
                if (row == null || row.Cells["Id"].Value == null)
                {
                    MessageBox.Show("No client selected or invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long id = Convert.ToInt64(row.Cells["Id"].Value);
                await clientsRepository.DeleteClient(id);
                await this.clientsRepository.LoadClient(dataGridView1);
            }
        }

        private void BlankPhoneNumbercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlankPhoneNumberCheckBox.Checked)
            {
                SearchPhoneNumberTextBox.Text = "";
                SearchPhoneNumber = "";
                SearchPhoneNumberTextBox.Enabled = false;
                BlankEmailFlag = true;
            }
            else
            {
                SearchPhoneNumberTextBox.Enabled = true;
                BlankEmailFlag = false;
            }
        }

        private void BlankMailcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BlankMailcheckBox.Checked)
            {
                SearchMailTextBox.Text = "";
                SearchEmail = "";
                SearchMailTextBox.Enabled = false;
                BlankPhoneNumberFlag = true;
            }
            else
            {
                SearchMailTextBox.Enabled = true;
                BlankPhoneNumberFlag = false;
            }
        }
    }
}
