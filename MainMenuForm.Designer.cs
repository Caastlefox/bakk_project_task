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
            this.EditClient = new System.Windows.Forms.Button();
            this.NewClient = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EditClient
            // 
            this.EditClient.Location = new System.Drawing.Point(299, 420);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(202, 28);
            this.EditClient.TabIndex = 2;
            this.EditClient.Text = "Edytuj klienta";
            this.EditClient.UseVisualStyleBackColor = true;
            // 
            // NewClient
            // 
            this.NewClient.Location = new System.Drawing.Point(586, 420);
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(202, 28);
            this.NewClient.TabIndex = 3;
            this.NewClient.Text = "Dodaj nowego klienta";
            this.NewClient.UseVisualStyleBackColor = true;
            this.NewClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 420);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(202, 27);
            this.Search.TabIndex = 4;
            this.Search.Text = "Szukaj";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(775, 376);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.NewClient);
            this.Controls.Add(this.EditClient);
            this.Name = "MainMenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.Button NewClient;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView listView1;
    }
}

