using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraLayout.Customization.Templates;
using DevExpress.XtraVerticalGrid;
using System.Drawing;
using System.Windows.Forms;
namespace bakk_project_task
{

    partial class DXMainMenuForm
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
            DeleteButton = new SimpleButton();
            EditClientButton = new SimpleButton();
            AddClientButton = new SimpleButton();
            Exit = new SimpleButton();
            ClearFiltersButton = new SimpleButton();
            SearchButton = new SimpleButton();
            FirstNameTextEdit = new TextEdit();
            gridcontrol1 = new GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            LastNameTextEdit = new TextEdit();
            AddressTextEdit = new TextEdit();
            EmailTextEdit = new TextEdit();
            StatusCheckEdit = new CheckEdit();
            blankEmail = new CheckEdit();
            BlankPhoneCheckEdit = new CheckEdit();
            PhoneNumberTextEdit = new TextEdit();
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blankEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BlankPhoneCheckEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextEdit.Properties).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(442, 518);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(200, 43);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Usuń Klienta";
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditClientButton
            // 
            EditClientButton.Location = new Point(236, 518);
            EditClientButton.Name = "EditClientButton";
            EditClientButton.Size = new Size(200, 43);
            EditClientButton.TabIndex = 1;
            EditClientButton.Text = "Edytuj Klienta";
            EditClientButton.Click += EditClientButton_Click;
            // 
            // AddClientButton
            // 
            AddClientButton.Location = new Point(30, 518);
            AddClientButton.Name = "AddClientButton";
            AddClientButton.Size = new Size(200, 43);
            AddClientButton.TabIndex = 2;
            AddClientButton.Text = "Dodaj Klienta";
            AddClientButton.Click += AddClientButton_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(648, 517);
            Exit.Name = "Exit";
            Exit.Size = new Size(195, 44);
            Exit.TabIndex = 3;
            Exit.Text = "Wyjdź";
            Exit.Click += Exit_Click;
            // 
            // ClearFiltersButton
            // 
            ClearFiltersButton.Location = new Point(648, 69);
            ClearFiltersButton.Name = "ClearFiltersButton";
            ClearFiltersButton.Size = new Size(195, 34);
            ClearFiltersButton.TabIndex = 4;
            ClearFiltersButton.Text = "Wyczyść Filtry";
            ClearFiltersButton.Click += ClearFiltersButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(648, 23);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(195, 34);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Szukaj";
            SearchButton.Click += SearchButton_Click;
            // 
            // FirstNameTextEdit
            // 
            FirstNameTextEdit.Location = new Point(30, 24);
            FirstNameTextEdit.Name = "FirstNameTextEdit";
            FirstNameTextEdit.Properties.AdvancedModeOptions.Label = "Imię";
            FirstNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            FirstNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            FirstNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            FirstNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            FirstNameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            FirstNameTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            FirstNameTextEdit.Size = new Size(200, 34);
            FirstNameTextEdit.TabIndex = 0;
            FirstNameTextEdit.EditValueChanged += SearchFirstName_EditValueChanged;
            // 
            // gridcontrol1
            // 
            gridcontrol1.BackgroundImageLayout = ImageLayout.None;
            gridcontrol1.DataMember = "Client";
            gridcontrol1.ImeMode = ImeMode.NoControl;
            gridcontrol1.Location = new Point(30, 112);
            gridcontrol1.MainView = gridView1;
            gridcontrol1.Name = "gridcontrol1";
            gridcontrol1.Size = new Size(813, 400);
            gridcontrol1.TabIndex = 0;
            gridcontrol1.UseDisabledStatePainter = false;
            gridcontrol1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridcontrol1.Click += Gridcontrol1_Click;
            gridcontrol1.DoubleClick += Gridcontrol1_DoubleClick;
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn1 });
            gridView1.GridControl = gridcontrol1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "gridColumn2";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "gridColumn3";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "gridColumn4";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "gridColumn5";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "gridColumn6";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "gridColumn7";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 6;
            // 
            // LastNameTextEdit
            // 
            LastNameTextEdit.Location = new Point(30, 69);
            LastNameTextEdit.Name = "LastNameTextEdit";
            LastNameTextEdit.Properties.AdvancedModeOptions.Label = "Nazwisko";
            LastNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            LastNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            LastNameTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            LastNameTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            LastNameTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            LastNameTextEdit.Size = new Size(200, 34);
            LastNameTextEdit.TabIndex = 6;
            LastNameTextEdit.EditValueChanged += LastNameTextBox_EditValueChanged;
            // 
            // AddressTextEdit
            // 
            AddressTextEdit.Location = new Point(236, 69);
            AddressTextEdit.Name = "AddressTextEdit";
            AddressTextEdit.Properties.AdvancedModeOptions.Label = "Adres";
            AddressTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            AddressTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            AddressTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            AddressTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AddressTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            AddressTextEdit.Size = new Size(200, 34);
            AddressTextEdit.TabIndex = 8;
            AddressTextEdit.EditValueChanged += AdressTextEdit_EditValueChanged;
            // 
            // EmailTextEdit
            // 
            EmailTextEdit.Location = new Point(442, 24);
            EmailTextEdit.Name = "EmailTextEdit";
            EmailTextEdit.Properties.AdvancedModeOptions.Label = "Email";
            EmailTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            EmailTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            EmailTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            EmailTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            EmailTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            EmailTextEdit.Size = new Size(200, 34);
            EmailTextEdit.TabIndex = 9;
            EmailTextEdit.EditValueChanged += EmailTextEdit_EditValueChanged;
            // 
            // StatusCheckEdit
            // 
            StatusCheckEdit.EditValue = null;
            StatusCheckEdit.Location = new Point(442, 76);
            StatusCheckEdit.Name = "StatusCheckEdit";
            StatusCheckEdit.Properties.AppearanceDisabled.BackColor = Color.LightGray;
            StatusCheckEdit.Properties.AppearanceDisabled.ForeColor = Color.DarkGray;
            StatusCheckEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            StatusCheckEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            StatusCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            StatusCheckEdit.Properties.Caption = "Potencjalny";
            StatusCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            StatusCheckEdit.Properties.ValueChecked = false;
            StatusCheckEdit.Properties.ValueUnchecked = true;
            StatusCheckEdit.Size = new Size(200, 20);
            StatusCheckEdit.TabIndex = 34;
            StatusCheckEdit.CheckedChanged += StatusCheckEdit_CheckedChanged;
            // 
            // blankEmail
            // 
            blankEmail.EditValue = null;
            blankEmail.Location = new Point(442, -2);
            blankEmail.Name = "blankEmail";
            blankEmail.Properties.AppearanceDisabled.BackColor = Color.LightGray;
            blankEmail.Properties.AppearanceDisabled.ForeColor = Color.DarkGray;
            blankEmail.Properties.AppearanceDisabled.Options.UseBackColor = true;
            blankEmail.Properties.AppearanceDisabled.Options.UseForeColor = true;
            blankEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            blankEmail.Properties.Caption = "Pusty Email";
            blankEmail.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            blankEmail.Properties.ValueChecked = false;
            blankEmail.Properties.ValueUnchecked = true;
            blankEmail.Size = new Size(200, 20);
            blankEmail.TabIndex = 35;
            blankEmail.CheckedChanged += BlankEmail_CheckedChanged;
            // 
            // BlankPhoneCheckEdit
            // 
            BlankPhoneCheckEdit.EditValue = null;
            BlankPhoneCheckEdit.Location = new Point(236, -2);
            BlankPhoneCheckEdit.Name = "BlankPhoneCheckEdit";
            BlankPhoneCheckEdit.Properties.AppearanceDisabled.BackColor = Color.LightGray;
            BlankPhoneCheckEdit.Properties.AppearanceDisabled.ForeColor = Color.DarkGray;
            BlankPhoneCheckEdit.Properties.AppearanceDisabled.Options.UseBackColor = true;
            BlankPhoneCheckEdit.Properties.AppearanceDisabled.Options.UseForeColor = true;
            BlankPhoneCheckEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            BlankPhoneCheckEdit.Properties.Caption = "Pusty Telefon";
            BlankPhoneCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            BlankPhoneCheckEdit.Properties.ValueChecked = false;
            BlankPhoneCheckEdit.Properties.ValueUnchecked = true;
            BlankPhoneCheckEdit.Size = new Size(200, 20);
            BlankPhoneCheckEdit.TabIndex = 36;
            BlankPhoneCheckEdit.CheckedChanged += BlankPhoneCheckEdit_CheckedChanged;
            // 
            // PhoneNumberTextEdit
            // 
            PhoneNumberTextEdit.Location = new Point(236, 24);
            PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            PhoneNumberTextEdit.Properties.AdvancedModeOptions.Label = "Numer Telefonu";
            PhoneNumberTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            PhoneNumberTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            PhoneNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            PhoneNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            PhoneNumberTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            PhoneNumberTextEdit.Size = new Size(200, 34);
            PhoneNumberTextEdit.TabIndex = 7;
            PhoneNumberTextEdit.EditValueChanged += PhoneNumberTextEdit_EditValueChanged;
            // 
            // DXMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 573);
            Controls.Add(BlankPhoneCheckEdit);
            Controls.Add(blankEmail);
            Controls.Add(StatusCheckEdit);
            Controls.Add(EmailTextEdit);
            Controls.Add(AddressTextEdit);
            Controls.Add(PhoneNumberTextEdit);
            Controls.Add(LastNameTextEdit);
            Controls.Add(SearchButton);
            Controls.Add(gridcontrol1);
            Controls.Add(ClearFiltersButton);
            Controls.Add(Exit);
            Controls.Add(AddClientButton);
            Controls.Add(EditClientButton);
            Controls.Add(DeleteButton);
            Controls.Add(FirstNameTextEdit);
            Name = "DXMainMenuForm";
            Text = "Baza Klientów";
            Load += DXMainMenuForm_Load;
            ((System.ComponentModel.ISupportInitialize)FirstNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LastNameTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddressTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmailTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)StatusCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)blankEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)BlankPhoneCheckEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhoneNumberTextEdit.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private SimpleButton DeleteButton;
        private SimpleButton EditClientButton;
        private SimpleButton AddClientButton;
        private SimpleButton Exit;
        private SimpleButton ClearFiltersButton;
        private SimpleButton SearchButton;
        private GridControl gridcontrol1;
        private TextEdit LastNameTextEdit;
        private TextEdit AddressTextEdit;
        private TextEdit EmailTextEdit;
        private TextEdit FirstNameTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private CheckEdit StatusCheckEdit;
        private CheckEdit blankEmail;
        private CheckEdit BlankPhoneCheckEdit;
        private TextEdit PhoneNumberTextEdit;
    }
}

