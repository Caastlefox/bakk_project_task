using System; // Ensure this is included
using System.Windows.Forms; // Ensure this is included
using System.ComponentModel; // Add this to ensure System.ComponentModel.IContainer is recognized
using System.Drawing; // Add this to ensure System.Drawing.SizeF is recognized

namespace bakk_project_task
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NewClient = new Button();
            Search = new Button();
            dataGridView1 = new DataGridView();
            EditClient = new Button();
            ExitButton = new Button();
            CleanFilters = new Button();
            SearchFirstNameTextBox = new TextBox();
            SearchMailTextBox = new TextBox();
            SearchLastNameTextBox = new TextBox();
            SearchPhoneNumberTextBox = new TextBox();
            SearchAddressTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NewClient
            // 
            NewClient.Location = new Point(25, 599);
            NewClient.Margin = new Padding(4, 3, 4, 3);
            NewClient.Name = "NewClient";
            NewClient.Size = new Size(292, 32);
            NewClient.TabIndex = 3;
            NewClient.Text = "Dodaj nowego klienta";
            NewClient.UseVisualStyleBackColor = true;
            NewClient.Click += AddNewClientButton_Click;
            // 
            // Search
            // 
            Search.Location = new Point(727, 15);
            Search.Margin = new Padding(4, 3, 4, 3);
            Search.Name = "Search";
            Search.Size = new Size(187, 41);
            Search.TabIndex = 4;
            Search.Text = "Szukaj";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(889, 468);
            dataGridView1.TabIndex = 5;
            // 
            // EditClient
            // 
            EditClient.Location = new Point(324, 599);
            EditClient.Name = "EditClient";
            EditClient.Size = new Size(292, 32);
            EditClient.TabIndex = 6;
            EditClient.Text = "Edytuj Klienta";
            EditClient.UseVisualStyleBackColor = true;
            EditClient.Click += EditClient_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(622, 599);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(292, 32);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Wyjdź";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CleanFilters
            // 
            CleanFilters.Location = new Point(727, 73);
            CleanFilters.Name = "CleanFilters";
            CleanFilters.Size = new Size(187, 41);
            CleanFilters.TabIndex = 8;
            CleanFilters.Text = "Wyczyść Filtry";
            CleanFilters.UseVisualStyleBackColor = true;
            CleanFilters.Click += CleanFilters_Click;
            // 
            // SearchFirstNameTextBox
            // 
            SearchFirstNameTextBox.Location = new Point(25, 33);
            SearchFirstNameTextBox.Multiline = true;
            SearchFirstNameTextBox.Name = "SearchFirstNameTextBox";
            SearchFirstNameTextBox.Size = new Size(212, 23);
            SearchFirstNameTextBox.TabIndex = 9;
            SearchFirstNameTextBox.TextChanged += SearchFirstNameTextBox_TextChanged;
            // 
            // SearchMailTextBox
            // 
            SearchMailTextBox.Location = new Point(494, 33);
            SearchMailTextBox.Name = "SearchMailTextBox";
            SearchMailTextBox.Size = new Size(212, 23);
            SearchMailTextBox.TabIndex = 10;
            SearchMailTextBox.TextChanged += SearchMailTextBox_TextChanged;
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Location = new Point(25, 91);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.Size = new Size(212, 23);
            SearchLastNameTextBox.TabIndex = 11;
            SearchLastNameTextBox.TextChanged += SearchLastNameTextBox_TextChanged;
            // 
            // SearchPhoneNumberTextBox
            // 
            SearchPhoneNumberTextBox.Location = new Point(257, 91);
            SearchPhoneNumberTextBox.Name = "SearchPhoneNumberTextBox";
            SearchPhoneNumberTextBox.Size = new Size(215, 23);
            SearchPhoneNumberTextBox.TabIndex = 12;
            SearchPhoneNumberTextBox.TextChanged += SearchPhoneNumberTextBox_TextChanged;
            // 
            // SearchAddressTextBox
            // 
            SearchAddressTextBox.Location = new Point(257, 33);
            SearchAddressTextBox.Name = "SearchAddressTextBox";
            SearchAddressTextBox.Size = new Size(215, 23);
            SearchAddressTextBox.TabIndex = 13;
            SearchAddressTextBox.TextChanged += SearchAddressTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 15;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 16;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 15);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 17;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 73);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 18;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 15);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 19;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 73);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aktualny", "Potencjalny" });
            comboBox1.Location = new Point(494, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 21;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 643);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchAddressTextBox);
            Controls.Add(SearchPhoneNumberTextBox);
            Controls.Add(SearchLastNameTextBox);
            Controls.Add(SearchMailTextBox);
            Controls.Add(SearchFirstNameTextBox);
            Controls.Add(CleanFilters);
            Controls.Add(ExitButton);
            Controls.Add(EditClient);
            Controls.Add(dataGridView1);
            Controls.Add(Search);
            Controls.Add(NewClient);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenuForm";
            Text = "Menu";
            Load += MainMenuForm_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewClient;
        private System.Windows.Forms.Button Search;
        private DataGridView dataGridView1;
        private Button EditClient;
        private Button ExitButton;
        private Button CleanFilters;
        private TextBox SearchFirstNameTextBox;
        private TextBox SearchMailTextBox;
        private TextBox SearchLastNameTextBox;
        private TextBox SearchPhoneNumberTextBox;
        private TextBox SearchAddressTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
    }
}

