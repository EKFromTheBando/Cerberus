namespace Cerberus.Cerberus.Forms
{
    partial class ModuleConfigurator
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
            ModuleGridControl = new DevExpress.XtraGrid.GridControl();
            moduleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            ColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            ColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            ButtonInjectFromConsole = new DevExpress.XtraEditors.SimpleButton();
            ButtonRefreshModules = new DevExpress.XtraEditors.SimpleButton();
            ButtonClearModules = new DevExpress.XtraEditors.SimpleButton();
            ButtonInjectFromPC = new DevExpress.XtraEditors.SimpleButton();
            LabelModulePath = new DevExpress.XtraEditors.LabelControl();
            TextEditPath = new DevExpress.XtraEditors.TextEdit();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(ModuleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(moduleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextEditPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(separatorControl1)).BeginInit();
            SuspendLayout();
            // 
            // ModuleGridControl
            // 
            ModuleGridControl.Location = new System.Drawing.Point(12, 12);
            ModuleGridControl.MainView = moduleGridView;
            ModuleGridControl.Name = "ModuleGridControl";
            ModuleGridControl.Size = new System.Drawing.Size(422, 338);
            ModuleGridControl.TabIndex = 0;
            ModuleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            moduleGridView});
            // 
            // moduleGridView
            // 
            moduleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            ColumnName,
            ColumnAddress,
            ColumnSize});
            moduleGridView.GridControl = ModuleGridControl;
            moduleGridView.Name = "moduleGridView";
            moduleGridView.OptionsView.ShowGroupPanel = false;
            moduleGridView.OptionsView.ShowIndicator = false;
            // 
            // ColumnName
            // 
            ColumnName.Caption = "Module Name";
            ColumnName.MinWidth = 25;
            ColumnName.Name = "ColumnName";
            ColumnName.Visible = true;
            ColumnName.VisibleIndex = 0;
            ColumnName.Width = 94;
            // 
            // ColumnAddress
            // 
            ColumnAddress.Caption = "Base Address";
            ColumnAddress.MinWidth = 25;
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.Visible = true;
            ColumnAddress.VisibleIndex = 1;
            ColumnAddress.Width = 94;
            // 
            // ColumnSize
            // 
            ColumnSize.Caption = "Module Size";
            ColumnSize.MinWidth = 25;
            ColumnSize.Name = "ColumnSize";
            ColumnSize.Visible = true;
            ColumnSize.VisibleIndex = 2;
            ColumnSize.Width = 94;
            // 
            // ButtonInjectFromConsole
            // 
            ButtonInjectFromConsole.Location = new System.Drawing.Point(12, 494);
            ButtonInjectFromConsole.Name = "ButtonInjectFromConsole";
            ButtonInjectFromConsole.Size = new System.Drawing.Size(422, 29);
            ButtonInjectFromConsole.TabIndex = 1;
            ButtonInjectFromConsole.Text = "Inject Module From Console";
            ButtonInjectFromConsole.Click += new System.EventHandler(ButtonInjectFromConsole_Click);
            // 
            // ButtonRefreshModules
            // 
            ButtonRefreshModules.Location = new System.Drawing.Point(12, 356);
            ButtonRefreshModules.Name = "ButtonRefreshModules";
            ButtonRefreshModules.Size = new System.Drawing.Size(422, 29);
            ButtonRefreshModules.TabIndex = 2;
            ButtonRefreshModules.Text = "Refresh Modules";
            ButtonRefreshModules.Click += new System.EventHandler(ButtonRefreshModules_Click);
            // 
            // ButtonClearModules
            // 
            ButtonClearModules.Location = new System.Drawing.Point(12, 391);
            ButtonClearModules.Name = "ButtonClearModules";
            ButtonClearModules.Size = new System.Drawing.Size(422, 29);
            ButtonClearModules.TabIndex = 3;
            ButtonClearModules.Text = "Clear Modules";
            ButtonClearModules.Click += new System.EventHandler(ButtonClearModules_Click);
            // 
            // ButtonInjectFromPC
            // 
            ButtonInjectFromPC.Location = new System.Drawing.Point(12, 529);
            ButtonInjectFromPC.Name = "ButtonInjectFromPC";
            ButtonInjectFromPC.Size = new System.Drawing.Size(422, 29);
            ButtonInjectFromPC.TabIndex = 4;
            ButtonInjectFromPC.Text = "Inject Module From PC";
            ButtonInjectFromPC.Click += new System.EventHandler(ButtonInjectFromPC_Click);
            // 
            // LabelModulePath
            // 
            LabelModulePath.Location = new System.Drawing.Point(12, 467);
            LabelModulePath.Name = "LabelModulePath";
            LabelModulePath.Size = new System.Drawing.Size(75, 16);
            LabelModulePath.TabIndex = 5;
            LabelModulePath.Text = "Module Path:";
            // 
            // TextEditPath
            // 
            TextEditPath.EditValue = "Hdd:\\\\";
            TextEditPath.Location = new System.Drawing.Point(93, 462);
            TextEditPath.Name = "TextEditPath";
            TextEditPath.Size = new System.Drawing.Size(341, 26);
            TextEditPath.TabIndex = 6;
            // 
            // separatorControl1
            // 
            separatorControl1.Location = new System.Drawing.Point(12, 426);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new System.Drawing.Size(422, 23);
            separatorControl1.TabIndex = 7;
            // 
            // ModuleConfigurator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(446, 573);
            Controls.Add(separatorControl1);
            Controls.Add(TextEditPath);
            Controls.Add(LabelModulePath);
            Controls.Add(ButtonInjectFromPC);
            Controls.Add(ButtonClearModules);
            Controls.Add(ButtonRefreshModules);
            Controls.Add(ButtonInjectFromConsole);
            Controls.Add(ModuleGridControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            Name = "ModuleConfigurator";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cerberus AIO - Module Configurator";
            Load += new System.EventHandler(ModuleConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(ModuleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(moduleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextEditPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(separatorControl1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ModuleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView moduleGridView;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSize;
        private DevExpress.XtraEditors.SimpleButton ButtonInjectFromConsole;
        private DevExpress.XtraEditors.SimpleButton ButtonRefreshModules;
        private DevExpress.XtraEditors.SimpleButton ButtonClearModules;
        private DevExpress.XtraEditors.SimpleButton ButtonInjectFromPC;
        private DevExpress.XtraEditors.LabelControl LabelModulePath;
        private DevExpress.XtraEditors.TextEdit TextEditPath;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}