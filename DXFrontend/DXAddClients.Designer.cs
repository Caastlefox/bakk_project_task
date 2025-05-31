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
            components = new System.ComponentModel.Container();
            AddNewClient = new DevExpress.XtraEditors.SimpleButton();
            FirstNameTextBox = new DevExpress.XtraEditors.TextEdit();
            LastNameTextBox = new DevExpress.XtraEditors.TextEdit();
            AddressTextBox = new DevExpress.XtraEditors.TextEdit();
            PhoneNumberTextBox = new DevExpress.XtraEditors.TextEdit();
            EmailTextBox = new DevExpress.XtraEditors.TextEdit();
            StatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
            SuspendLayout();
            // 
            // AddNewClient
            // 
            AddNewClient.Location = new Point(12, 330);
            AddNewClient.Name = "AddNewClient";
            AddNewClient.Size = new Size(377, 63);
            AddNewClient.TabIndex = 27;
            AddNewClient.Text = "Dodaj Klienta";
            AddNewClient.Click += AddClient_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(12, 12);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Properties.AdvancedModeOptions.Label = "Podaj Imię(obowiązkowe)";
            FirstNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            FirstNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            FirstNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            FirstNameTextBox.Properties.Appearance.Options.UseTextOptions = true;
            FirstNameTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            FirstNameTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            FirstNameTextBox.Size = new Size(377, 34);
            FirstNameTextBox.TabIndex = 28;
            FirstNameTextBox.EditValueChanged += FirstNameTextBox_EditValueChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(12, 61);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Properties.AdvancedModeOptions.Label = "Podaj Nazwisko(obowiązkowe)";
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            LastNameTextBox.Properties.Appearance.Options.UseTextOptions = true;
            LastNameTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            LastNameTextBox.Size = new Size(377, 34);
            LastNameTextBox.TabIndex = 29;
            LastNameTextBox.EditValueChanged += LastNameTextBox_EditValueChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(12, 111);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Properties.AdvancedModeOptions.Label = "Podaj Adres";
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            AddressTextBox.Properties.Appearance.Options.UseTextOptions = true;
            AddressTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            AddressTextBox.Size = new Size(377, 34);
            AddressTextBox.TabIndex = 30;
            AddressTextBox.EditValueChanged += AddressTextBox_EditValueChanged;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(12, 160);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Properties.AdvancedModeOptions.Label = "Podaj Numer Telefonu";
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            PhoneNumberTextBox.Properties.Appearance.Options.UseTextOptions = true;
            PhoneNumberTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            PhoneNumberTextBox.Size = new Size(377, 34);
            PhoneNumberTextBox.TabIndex = 31;
            PhoneNumberTextBox.EditValueChanged += PhoneNumberTextBox_EditValueChanged;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(12, 208);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Properties.AdvancedModeOptions.Label = "Podaj Adres Email";
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            EmailTextBox.Properties.Appearance.Options.UseTextOptions = true;
            EmailTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            EmailTextBox.Size = new Size(377, 34);
            EmailTextBox.TabIndex = 32;
            EmailTextBox.EditValueChanged += EmailTextBox_EditValueChanged;
            // 
            // StatusCheckEdit
            // 
            StatusCheckEdit.EditValue = null;
            StatusCheckEdit.Location = new Point(12, 258);
            StatusCheckEdit.Name = "StatusCheckEdit";
            StatusCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            StatusCheckEdit.Properties.Caption = "Potencjalny";
            StatusCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            StatusCheckEdit.Properties.ValueChecked = false;
            StatusCheckEdit.Properties.ValueUnchecked = true;
            StatusCheckEdit.Size = new Size(200, 20);
            StatusCheckEdit.TabIndex = 33;
            StatusCheckEdit.CheckedChanged += StatusCheckEdit_CheckedChanged;
            // 
            // DXAddNewClient
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 405);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(AddressTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(AddNewClient);
            Controls.Add(StatusCheckEdit);
            Name = "DXAddNewClient";
            Text = "Dane Klienta";
            Load += AddNewClient_Load;
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton AddNewClient;
        private DevExpress.XtraEditors.TextEdit FirstNameTextBox;
        private DevExpress.XtraEditors.TextEdit LastNameTextBox;
        private DevExpress.XtraEditors.TextEdit AddressTextBox;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextBox;
        private DevExpress.XtraEditors.TextEdit EmailTextBox;
        private DevExpress.XtraEditors.CheckEdit StatusCheckEdit;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}