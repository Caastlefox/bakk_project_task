using System.Windows.Forms;

namespace bakk_project_task
{
    partial class DXAddNewClient
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
            AddNewClient = new DevExpress.XtraEditors.SimpleButton();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            textEdit6 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).BeginInit();
            SuspendLayout();
            // 
            // AddNewClient
            // 
            AddNewClient.Location = new System.Drawing.Point(12, 330);
            AddNewClient.Name = "AddNewClient";
            AddNewClient.Size = new System.Drawing.Size(377, 63);
            AddNewClient.TabIndex = 27;
            AddNewClient.Text = "Dodaj Klienta";
            AddNewClient.Click += AddClient_Click;
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(24, 30);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(200, 20);
            textEdit1.TabIndex = 28;
            // 
            // textEdit2
            // 
            textEdit2.Location = new System.Drawing.Point(24, 65);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new System.Drawing.Size(200, 20);
            textEdit2.TabIndex = 29;
            // 
            // textEdit3
            // 
            textEdit3.Location = new System.Drawing.Point(24, 101);
            textEdit3.Name = "textEdit3";
            textEdit3.Size = new System.Drawing.Size(200, 20);
            textEdit3.TabIndex = 30;
            // 
            // textEdit4
            // 
            textEdit4.Location = new System.Drawing.Point(24, 138);
            textEdit4.Name = "textEdit4";
            textEdit4.Size = new System.Drawing.Size(200, 20);
            textEdit4.TabIndex = 31;
            // 
            // textEdit5
            // 
            textEdit5.Location = new System.Drawing.Point(24, 178);
            textEdit5.Name = "textEdit5";
            textEdit5.Size = new System.Drawing.Size(200, 20);
            textEdit5.TabIndex = 32;
            // 
            // textEdit6
            // 
            textEdit6.Location = new System.Drawing.Point(24, 216);
            textEdit6.Name = "textEdit6";
            textEdit6.Size = new System.Drawing.Size(200, 20);
            textEdit6.TabIndex = 33;
            // 
            // DXAddNewClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(401, 405);
            Controls.Add(textEdit6);
            Controls.Add(textEdit5);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(AddNewClient);
            Name = "DXAddNewClient";
            Text = "Dane Klienta";
            Load += AddNewClient_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit6.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton AddNewClient;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
    }
}