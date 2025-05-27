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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            NewClient.Click += Button1_Click;
            // 
            // Search
            // 
            Search.Location = new Point(727, 23);
            Search.Margin = new Padding(4, 3, 4, 3);
            Search.Name = "Search";
            Search.Size = new Size(187, 33);
            Search.TabIndex = 4;
            Search.Text = "Szukaj";
            Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(889, 468);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
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
            CleanFilters.Location = new Point(727, 82);
            CleanFilters.Name = "CleanFilters";
            CleanFilters.Size = new Size(187, 32);
            CleanFilters.TabIndex = 8;
            CleanFilters.Text = "Wyczyść Filtry";
            CleanFilters.UseVisualStyleBackColor = true;
            CleanFilters.Click += CleanFilters_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 32);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(494, 24);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 32);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 82);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(212, 32);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(257, 82);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(215, 32);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(257, 24);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(215, 32);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(494, 82);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(212, 32);
            textBox6.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 15;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 16;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 6);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 17;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 64);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 18;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 6);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 19;
            label5.Text = "Mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(494, 64);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 20;
            label6.Text = "Status";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 643);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}

