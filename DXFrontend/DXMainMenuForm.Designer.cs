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
            myTextEdit = new TextEdit();
            winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridcontrol1 = new GridControl();
            textEdit1 = new TextEdit();
            textEdit2 = new TextEdit();
            textEdit3 = new TextEdit();
            textEdit4 = new TextEdit();
            textEdit5 = new TextEdit();
            ((System.ComponentModel.ISupportInitialize)myTextEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)winExplorerView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
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
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(648, 23);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(195, 34);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Szukaj";
            // 
            // myTextEdit
            // 
            myTextEdit.Location = new Point(30, 24);
            myTextEdit.Name = "myTextEdit";
            myTextEdit.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            myTextEdit.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            myTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            myTextEdit.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            myTextEdit.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            myTextEdit.Size = new Size(200, 34);
            myTextEdit.TabIndex = 0;
            myTextEdit.EditValueChanged += myTextEdit_EditValueChanged;
            // 
            // winExplorerView1
            // 
            winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            winExplorerView1.GridControl = gridcontrol1;
            winExplorerView1.Name = "winExplorerView1";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "gridColumn1";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridcontrol1
            // 
            gridcontrol1.BackgroundImageLayout = ImageLayout.None;
            gridcontrol1.ImeMode = ImeMode.NoControl;
            gridcontrol1.Location = new Point(30, 112);
            gridcontrol1.MainView = winExplorerView1;
            gridcontrol1.Name = "gridcontrol1";
            gridcontrol1.Size = new Size(813, 400);
            gridcontrol1.TabIndex = 0;
            gridcontrol1.UseDisabledStatePainter = false;
            gridcontrol1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { winExplorerView1 });
            gridcontrol1.DoubleClick += gridcontrol1_DoubleClick;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(30, 69);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            textEdit1.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            textEdit1.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit1.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            textEdit1.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEdit1.Size = new Size(200, 34);
            textEdit1.TabIndex = 6;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(236, 69);
            textEdit2.Name = "textEdit2";
            textEdit2.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            textEdit2.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            textEdit2.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit2.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            textEdit2.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEdit2.Size = new Size(200, 34);
            textEdit2.TabIndex = 7;
            // 
            // textEdit3
            // 
            textEdit3.Location = new Point(236, 24);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            textEdit3.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            textEdit3.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit3.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            textEdit3.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEdit3.Size = new Size(200, 34);
            textEdit3.TabIndex = 8;
            // 
            // textEdit4
            // 
            textEdit4.Location = new Point(442, 23);
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            textEdit4.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            textEdit4.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit4.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            textEdit4.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEdit4.Size = new Size(200, 34);
            textEdit4.TabIndex = 9;
            // 
            // textEdit5
            // 
            textEdit5.Location = new Point(442, 72);
            textEdit5.Name = "textEdit5";
            textEdit5.Properties.AdvancedModeOptions.Label = "Wpisz Imię";
            textEdit5.Properties.AdvancedModeOptions.LabelAppearance.Options.UseTextOptions = true;
            textEdit5.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            textEdit5.Properties.AdvancedModeOptions.LabelAppearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            textEdit5.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            textEdit5.Size = new Size(200, 34);
            textEdit5.TabIndex = 10;
            // 
            // DXMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 573);
            Controls.Add(textEdit5);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            Controls.Add(SearchButton);
            Controls.Add(gridcontrol1);
            Controls.Add(ClearFiltersButton);
            Controls.Add(Exit);
            Controls.Add(AddClientButton);
            Controls.Add(EditClientButton);
            Controls.Add(DeleteButton);
            Controls.Add(myTextEdit);
            Name = "DXMainMenuForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)myTextEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)winExplorerView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridcontrol1).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private SimpleButton DeleteButton;
        private SimpleButton EditClientButton;
        private SimpleButton AddClientButton;
        private SimpleButton Exit;
        private SimpleButton ClearFiltersButton;
        private SimpleButton SearchButton;
        private TextEdit myTextEdit;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private GridControl gridcontrol1;
        private TextEdit textEdit1;
        private TextEdit textEdit2;
        private TextEdit textEdit3;
        private TextEdit textEdit4;
        private TextEdit textEdit5;
    }
}

