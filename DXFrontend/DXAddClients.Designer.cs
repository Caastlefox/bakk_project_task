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
            EmailGridControl = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            Email = new DevExpress.XtraGrid.Columns.GridColumn();
            PhoneNumberGridControl = new DevExpress.XtraGrid.GridControl();
            gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            EmailTextBox = new DevExpress.XtraEditors.TextEdit();
            PhoneNumberTextBox = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).BeginInit();
            SuspendLayout();
            // 
            // AddNewClient
            // 
            AddNewClient.Location = new Point(218, 417);
            AddNewClient.Name = "AddNewClient";
            AddNewClient.Size = new Size(286, 67);
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
            FirstNameTextBox.Size = new Size(200, 34);
            FirstNameTextBox.TabIndex = 28;
            FirstNameTextBox.EditValueChanged += FirstNameTextBox_EditValueChanged;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(12, 92);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Properties.AdvancedModeOptions.Label = "Podaj Nazwisko(obowiązkowe)";
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            LastNameTextBox.Properties.Appearance.Options.UseTextOptions = true;
            LastNameTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            LastNameTextBox.Size = new Size(200, 34);
            LastNameTextBox.TabIndex = 29;
            LastNameTextBox.EditValueChanged += LastNameTextBox_EditValueChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(12, 175);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Properties.AdvancedModeOptions.Label = "Podaj Adres";
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            AddressTextBox.Properties.Appearance.Options.UseTextOptions = true;
            AddressTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            AddressTextBox.Size = new Size(200, 34);
            AddressTextBox.TabIndex = 30;
            AddressTextBox.EditValueChanged += AddressTextBox_EditValueChanged;
            // 
            // StatusCheckEdit
            // 
            StatusCheckEdit.EditValue = null;
            StatusCheckEdit.Location = new Point(12, 255);
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
            EmailPlusButton.Location = new Point(424, 215);
            EmailPlusButton.Name = "EmailPlusButton";
            EmailPlusButton.Size = new Size(37, 34);
            EmailPlusButton.TabIndex = 36;
            EmailPlusButton.Click += EmailPlusButton_Click;
            // 
            // PhoneNumberPlusButton
            // 
            PhoneNumberPlusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PhoneNumberPlusButton.ImageOptions.SvgImage");
            PhoneNumberPlusButton.Location = new Point(424, 12);
            PhoneNumberPlusButton.Name = "PhoneNumberPlusButton";
            PhoneNumberPlusButton.Size = new Size(37, 34);
            PhoneNumberPlusButton.TabIndex = 37;
            PhoneNumberPlusButton.Click += PhoneNumberPlusButton_Click;
            // 
            // EmailMinusButton
            // 
            EmailMinusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("EmailMinusButton.ImageOptions.SvgImage");
            EmailMinusButton.Location = new Point(467, 215);
            EmailMinusButton.Name = "EmailMinusButton";
            EmailMinusButton.Size = new Size(37, 34);
            EmailMinusButton.TabIndex = 38;
            EmailMinusButton.Text = "Zapisz";
            EmailMinusButton.Click += EmailMinusButton_Click;
            // 
            // PhoneNumberMinusButton
            // 
            PhoneNumberMinusButton.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("PhoneNumberMinusButton.ImageOptions.SvgImage");
            PhoneNumberMinusButton.Location = new Point(467, 12);
            PhoneNumberMinusButton.Name = "PhoneNumberMinusButton";
            PhoneNumberMinusButton.Size = new Size(37, 34);
            PhoneNumberMinusButton.TabIndex = 39;
            PhoneNumberMinusButton.Text = "Zapisz";
            PhoneNumberMinusButton.Click += PhoneNumberMinusButton_Click;
            // 
            // EmailGridControl
            // 
            EmailGridControl.BackgroundImageLayout = ImageLayout.None;
            EmailGridControl.DataMember = "Client";
            EmailGridControl.ImeMode = ImeMode.NoControl;
            EmailGridControl.Location = new Point(218, 255);
            EmailGridControl.MainView = gridView1;
            EmailGridControl.Name = "EmailGridControl";
            EmailGridControl.Size = new Size(286, 156);
            EmailGridControl.TabIndex = 45;
            EmailGridControl.UseDisabledStatePainter = false;
            EmailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            EmailGridControl.Click += EmailGridControl_Click;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { Email });
            gridView1.GridControl = EmailGridControl;
            gridView1.Name = "gridView1";
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ShowColumnHeaders = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Email
            // 
            Email.Caption = "Email";
            Email.Name = "Email";
            Email.Visible = true;
            Email.VisibleIndex = 0;
            // 
            // PhoneNumberGridControl
            // 
            PhoneNumberGridControl.BackgroundImageLayout = ImageLayout.None;
            PhoneNumberGridControl.DataMember = "Client";
            PhoneNumberGridControl.ImeMode = ImeMode.NoControl;
            PhoneNumberGridControl.Location = new Point(218, 52);
            PhoneNumberGridControl.MainView = gridView2;
            PhoneNumberGridControl.Name = "PhoneNumberGridControl";
            PhoneNumberGridControl.Size = new Size(286, 157);
            PhoneNumberGridControl.TabIndex = 46;
            PhoneNumberGridControl.UseDisabledStatePainter = false;
            PhoneNumberGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView2 });
            // 
            // gridView2
            // 
            gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn2 });
            gridView2.GridControl = PhoneNumberGridControl;
            gridView2.Name = "gridView2";
            gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView2.OptionsView.ShowColumnHeaders = false;
            gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "gridColumn2";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(218, 215);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Properties.AdvancedModeOptions.Label = "Podaj Email";
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            EmailTextBox.Properties.Appearance.Options.UseTextOptions = true;
            EmailTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            EmailTextBox.Size = new Size(200, 34);
            EmailTextBox.TabIndex = 47;
            EmailTextBox.EditValueChanged += EmailTextBox_EditValueChanged;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(218, 12);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Properties.AdvancedModeOptions.Label = "Podaj Numer Telefonu";
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextBox.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            PhoneNumberTextBox.Properties.Appearance.Options.UseTextOptions = true;
            PhoneNumberTextBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextBox.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            PhoneNumberTextBox.Size = new Size(200, 34);
            PhoneNumberTextBox.TabIndex = 48;
            PhoneNumberTextBox.EditValueChanged += PhoneNumberTextBox_EditValueChanged;
            // 
            // DXAddNewClient
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 491);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(PhoneNumberGridControl);
            Controls.Add(EmailGridControl);
            Controls.Add(PhoneNumberMinusButton);
            Controls.Add(EmailMinusButton);
            Controls.Add(PhoneNumberPlusButton);
            Controls.Add(EmailPlusButton);
            Controls.Add(AddressTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(AddNewClient);
            Controls.Add(StatusCheckEdit);
            Name = "DXAddNewClient";
            Text = "Dane Klienta";
            FormClosed += DXAddNewClient_FormClosed;
            Load += AddNewClient_Load;
            ((System.ComponentModel.ISupportInitialize)FirstNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextBox.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextBox.Properties).EndInit();
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
        private DevExpress.XtraGrid.GridControl EmailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl PhoneNumberGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.TextEdit EmailTextBox;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
    }
}