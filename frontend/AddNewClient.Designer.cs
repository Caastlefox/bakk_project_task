using System;
using System.Windows.Forms;
namespace bakk_project_task
{
    partial class AddNewClient
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
            AddClient = new Button();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            EmailtextBox = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // AddClient
            // 
            AddClient.Location = new Point(14, 324);
            AddClient.Margin = new Padding(4, 3, 4, 3);
            AddClient.Name = "AddClient";
            AddClient.Size = new Size(362, 63);
            AddClient.TabIndex = 0;
            AddClient.Text = "Zapisz";
            AddClient.UseVisualStyleBackColor = true;
            AddClient.Click += AddClient_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(48, 46);
            FirstNameTextBox.Margin = new Padding(4, 3, 4, 3);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(298, 23);
            FirstNameTextBox.TabIndex = 1;
            FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(48, 91);
            LastNameTextBox.Margin = new Padding(4, 3, 4, 3);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(298, 23);
            LastNameTextBox.TabIndex = 2;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(48, 136);
            AddressTextBox.Margin = new Padding(4, 3, 4, 3);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(298, 23);
            AddressTextBox.TabIndex = 3;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(48, 181);
            PhoneNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(298, 23);
            PhoneNumberTextBox.TabIndex = 4;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 163);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefon";
            // 
            // EmailtextBox
            // 
            EmailtextBox.Location = new Point(48, 226);
            EmailtextBox.Margin = new Padding(4, 3, 4, 3);
            EmailtextBox.Name = "EmailtextBox";
            EmailtextBox.Size = new Size(298, 23);
            EmailtextBox.TabIndex = 10;
            EmailtextBox.TextChanged += EmailtextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 253);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 12;
            label6.Text = "Status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 271);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Potencjalny";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // AddNewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 396);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(EmailtextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(AddClient);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddNewClient";
            Text = "Dodaj klienta";
            Load += AddNewClient_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}