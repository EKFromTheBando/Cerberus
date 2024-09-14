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
            this.ModuleGridControl = new DevExpress.XtraGrid.GridControl();
            this.moduleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ButtonInjectFromConsole = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonRefreshModules = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonClearModules = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonInjectFromPC = new DevExpress.XtraEditors.SimpleButton();
            this.LabelModulePath = new DevExpress.XtraEditors.LabelControl();
            this.TextEditPath = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModuleGridControl
            // 
            this.ModuleGridControl.Location = new System.Drawing.Point(12, 12);
            this.ModuleGridControl.MainView = this.moduleGridView;
            this.ModuleGridControl.Name = "ModuleGridControl";
            this.ModuleGridControl.Size = new System.Drawing.Size(422, 338);
            this.ModuleGridControl.TabIndex = 0;
            this.ModuleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.moduleGridView});
            // 
            // moduleGridView
            // 
            this.moduleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnName,
            this.ColumnAddress,
            this.ColumnSize});
            this.moduleGridView.GridControl = this.ModuleGridControl;
            this.moduleGridView.Name = "moduleGridView";
            this.moduleGridView.OptionsView.ShowGroupPanel = false;
            this.moduleGridView.OptionsView.ShowIndicator = false;
            // 
            // ColumnName
            // 
            this.ColumnName.Caption = "Module Name";
            this.ColumnName.MinWidth = 25;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Visible = true;
            this.ColumnName.VisibleIndex = 0;
            this.ColumnName.Width = 94;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.Caption = "Base Address";
            this.ColumnAddress.MinWidth = 25;
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.Visible = true;
            this.ColumnAddress.VisibleIndex = 1;
            this.ColumnAddress.Width = 94;
            // 
            // ColumnSize
            // 
            this.ColumnSize.Caption = "Module Size";
            this.ColumnSize.MinWidth = 25;
            this.ColumnSize.Name = "ColumnSize";
            this.ColumnSize.Visible = true;
            this.ColumnSize.VisibleIndex = 2;
            this.ColumnSize.Width = 94;
            // 
            // ButtonInjectFromConsole
            // 
            this.ButtonInjectFromConsole.Location = new System.Drawing.Point(12, 494);
            this.ButtonInjectFromConsole.Name = "ButtonInjectFromConsole";
            this.ButtonInjectFromConsole.Size = new System.Drawing.Size(422, 29);
            this.ButtonInjectFromConsole.TabIndex = 1;
            this.ButtonInjectFromConsole.Text = "Inject Module From Console";
            this.ButtonInjectFromConsole.Click += new System.EventHandler(this.ButtonInjectFromConsole_Click);
            // 
            // ButtonRefreshModules
            // 
            this.ButtonRefreshModules.Location = new System.Drawing.Point(12, 356);
            this.ButtonRefreshModules.Name = "ButtonRefreshModules";
            this.ButtonRefreshModules.Size = new System.Drawing.Size(422, 29);
            this.ButtonRefreshModules.TabIndex = 2;
            this.ButtonRefreshModules.Text = "Refresh Modules";
            this.ButtonRefreshModules.Click += new System.EventHandler(this.ButtonRefreshModules_Click);
            // 
            // ButtonClearModules
            // 
            this.ButtonClearModules.Location = new System.Drawing.Point(12, 391);
            this.ButtonClearModules.Name = "ButtonClearModules";
            this.ButtonClearModules.Size = new System.Drawing.Size(422, 29);
            this.ButtonClearModules.TabIndex = 3;
            this.ButtonClearModules.Text = "Clear Modules";
            this.ButtonClearModules.Click += new System.EventHandler(this.ButtonClearModules_Click);
            // 
            // ButtonInjectFromPC
            // 
            this.ButtonInjectFromPC.Location = new System.Drawing.Point(12, 529);
            this.ButtonInjectFromPC.Name = "ButtonInjectFromPC";
            this.ButtonInjectFromPC.Size = new System.Drawing.Size(422, 29);
            this.ButtonInjectFromPC.TabIndex = 4;
            this.ButtonInjectFromPC.Text = "Inject Module From PC";
            this.ButtonInjectFromPC.Click += new System.EventHandler(this.ButtonInjectFromPC_Click);
            // 
            // LabelModulePath
            // 
            this.LabelModulePath.Location = new System.Drawing.Point(12, 467);
            this.LabelModulePath.Name = "LabelModulePath";
            this.LabelModulePath.Size = new System.Drawing.Size(75, 16);
            this.LabelModulePath.TabIndex = 5;
            this.LabelModulePath.Text = "Module Path:";
            // 
            // TextEditPath
            // 
            this.TextEditPath.EditValue = "Hdd:\\\\";
            this.TextEditPath.Location = new System.Drawing.Point(93, 462);
            this.TextEditPath.Name = "TextEditPath";
            this.TextEditPath.Size = new System.Drawing.Size(341, 26);
            this.TextEditPath.TabIndex = 6;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 426);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(422, 23);
            this.separatorControl1.TabIndex = 7;
            // 
            // ModuleConfigurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 573);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.TextEditPath);
            this.Controls.Add(this.LabelModulePath);
            this.Controls.Add(this.ButtonInjectFromPC);
            this.Controls.Add(this.ButtonClearModules);
            this.Controls.Add(this.ButtonRefreshModules);
            this.Controls.Add(this.ButtonInjectFromConsole);
            this.Controls.Add(this.ModuleGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "ModuleConfigurator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerberus AIO - Module Configurator";
            this.Load += new System.EventHandler(this.ModuleConfigurator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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