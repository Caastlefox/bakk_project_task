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
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NewClient
            // 
            NewClient.Location = new Point(439, 485);
            NewClient.Margin = new Padding(4, 3, 4, 3);
            NewClient.Name = "NewClient";
            NewClient.Size = new Size(481, 32);
            NewClient.TabIndex = 3;
            NewClient.Text = "Dodaj nowego klienta";
            NewClient.UseVisualStyleBackColor = true;
            NewClient.Click += Button1_Click;
            // 
            // Search
            // 
            Search.Location = new Point(14, 485);
            Search.Margin = new Padding(4, 3, 4, 3);
            Search.Name = "Search";
            Search.Size = new Size(417, 31);
            Search.TabIndex = 4;
            Search.Text = "Szukaj";
            Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(907, 468);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dataGridView1);
            Controls.Add(Search);
            Controls.Add(NewClient);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenuForm";
            Text = "Menu";
            Load += MainMenuForm_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewClient;
        private System.Windows.Forms.Button Search;
        private DataGridView dataGridView1;
    }
}

