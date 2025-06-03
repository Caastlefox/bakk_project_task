using DevExpress.XtraBars;
using System.Windows.Controls;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DXAddNewClient));
            AddNewClient = new DevExpress.XtraEditors.SimpleButton();
            FirstNameTextBox = new DevExpress.XtraEditors.TextEdit();
            LastNameTextBox = new DevExpress.XtraEditors.TextEdit();
            AddressTextBox = new DevExpress.XtraEditors.TextEdit();
            StatusCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            EmailPlusButton = new DevExpress.XtraEditors.SimpleButton();
            PhoneNumberPlusButton = new DevExpress.XtraEditors.SimpleButton();
            EmailMinusButton = new DevExpress.XtraEditors.SimpleButton();
            PhoneNumberMinusButton = new DevExpress.XtraEditors.SimpleButton();
            PhoneNumberTextBox = new DevExpress.XtraEditors.PopupContainerEdit();
            popupContainerControl1 = new DevExpress.XtraEditors.PopupContainerControl();
            EmailListBox = new DevExpress.XtraEditors.ListBoxControl();
            popupContainerControl2 = new DevExpress.XtraEditors.PopupContainerControl();
            PhoneNumberListBox = new DevExpress.XtraEditors.ListBoxControl();
            EmailTextBox = new DevExpress.XtraEditors.PopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl1).BeginInit();
            popupContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmailListBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl2).BeginInit();
            popupContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberListBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).BeginInit();
            SuspendLayout();
            // 
            // AddNewClient
            // 
            AddNewClient.Location = new Point(16, 339);
            AddNewClient.Name = "AddNewClient";
            AddNewClient.Size = new Size(463, 63);
            AddNewClient.TabIndex = 27;
            AddNewClient.Text = "Zapisz";
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
            // EmailPlusButton
            // 
            EmailPlusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmailPlusButton.ImageOptions.SvgImage");
            EmailPlusButton.Location = new Point(395, 207);
            EmailPlusButton.Name = "EmailPlusButton";
            EmailPlusButton.Size = new Size(37, 35);
            EmailPlusButton.TabIndex = 36;
            EmailPlusButton.Click += EmailPlusButton_Click;
            // 
            // PhoneNumberPlusButton
            // 
            PhoneNumberPlusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PhoneNumberPlusButton.ImageOptions.SvgImage");
            PhoneNumberPlusButton.Location = new Point(395, 159);
            PhoneNumberPlusButton.Name = "PhoneNumberPlusButton";
            PhoneNumberPlusButton.Size = new Size(37, 35);
            PhoneNumberPlusButton.TabIndex = 37;
            PhoneNumberPlusButton.Click += PhoneNumberplus_Click;
            // 
            // EmailMinusButton
            // 
            EmailMinusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmailMinusButton.ImageOptions.SvgImage");
            EmailMinusButton.Location = new Point(438, 207);
            EmailMinusButton.Name = "EmailMinusButton";
            EmailMinusButton.Size = new Size(37, 35);
            EmailMinusButton.TabIndex = 38;
            EmailMinusButton.Text = "Zapisz";
            EmailMinusButton.Click += EmailMinusButton_Click;
            // 
            // PhoneNumberMinusButton
            // 
            PhoneNumberMinusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PhoneNumberMinusButton.ImageOptions.SvgImage");
            PhoneNumberMinusButton.Location = new Point(438, 159);
            PhoneNumberMinusButton.Name = "PhoneNumberMinusButton";
            PhoneNumberMinusButton.Size = new Size(37, 35);
            PhoneNumberMinusButton.TabIndex = 39;
            PhoneNumberMinusButton.Text = "Zapisz";
            PhoneNumberMinusButton.Click += PhoneNumberMinusButton_Click;
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
            PhoneNumberTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            PhoneNumberTextBox.Properties.PopupControl = popupContainerControl1;
            PhoneNumberTextBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            PhoneNumberTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            PhoneNumberTextBox.Size = new Size(377, 34);
            PhoneNumberTextBox.TabIndex = 31;
            PhoneNumberTextBox.EditValueChanged += PhoneNumberTextBox_EditValueChanged;
            // 
            // popupContainerControl1
            // 
            popupContainerControl1.Controls.Add(PhoneNumberListBox);
            popupContainerControl1.Location = new Point(12, 248);
            popupContainerControl1.Name = "popupContainerControl1";
            popupContainerControl1.Size = new Size(377, 139);
            popupContainerControl1.TabIndex = 43;
            // 
            // EmailListBox
            // 
            EmailListBox.Location = new Point(0, 0);
            EmailListBox.Name = "EmailListBox";
            EmailListBox.Size = new Size(377, 139);
            EmailListBox.TabIndex = 0;
            // 
            // popupContainerControl2
            // 
            popupContainerControl2.Controls.Add(EmailListBox);
            popupContainerControl2.Location = new Point(12, 194);
            popupContainerControl2.Name = "popupContainerControl2";
            popupContainerControl2.Size = new Size(377, 139);
            popupContainerControl2.TabIndex = 41;
            // 
            // PhoneNumberListBox
            // 
            PhoneNumberListBox.Location = new Point(0, 0);
            PhoneNumberListBox.Name = "PhoneNumberListBox";
            PhoneNumberListBox.Size = new Size(377, 193);
            PhoneNumberListBox.TabIndex = 0;
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
            EmailTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            EmailTextBox.Properties.PopupControl = popupContainerControl2;
            EmailTextBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            EmailTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            EmailTextBox.Size = new Size(377, 34);
            EmailTextBox.TabIndex = 42;
            EmailTextBox.EditValueChanged += EmailTextBox_EditValueChanged;
            // 
            // DXAddNewClient
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 414);
            Controls.Add(popupContainerControl1);
            Controls.Add(EmailTextBox);
            Controls.Add(popupContainerControl2);
            Controls.Add(PhoneNumberMinusButton);
            Controls.Add(EmailMinusButton);
            Controls.Add(PhoneNumberPlusButton);
            Controls.Add(EmailPlusButton);
            Controls.Add(AddressTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(AddNewClient);
            Controls.Add(StatusCheckEdit);
            Controls.Add(PhoneNumberTextBox);
            Name = "DXAddNewClient";
            Text = "Dane Klienta";
            Load += AddNewClient_Load;
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl1).EndInit();
            popupContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EmailListBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupContainerControl2).EndInit();
            popupContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PhoneNumberListBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton AddNewClient;
        private DevExpress.XtraEditors.TextEdit FirstNameTextBox;
        private DevExpress.XtraEditors.TextEdit LastNameTextBox;
        private DevExpress.XtraEditors.TextEdit AddressTextBox;
        private DevExpress.XtraEditors.CheckEdit StatusCheckEdit;
        private DevExpress.XtraEditors.SimpleButton EmailPlusButton;
        private DevExpress.XtraEditors.SimpleButton PhoneNumberPlusButton;
        private DevExpress.XtraEditors.SimpleButton EmailMinusButton;
        private DevExpress.XtraEditors.SimpleButton PhoneNumberMinusButton;
        private DevExpress.XtraEditors.PopupContainerEdit PhoneNumberTextBox;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl2;
        private DevExpress.XtraEditors.ListBoxControl PhoneNumberListBox;
        private DevExpress.XtraEditors.PopupContainerEdit EmailTextBox;
        private DevExpress.XtraEditors.PopupContainerControl popupContainerControl1;
        private DevExpress.XtraEditors.ListBoxControl EmailListBox;
    }
}