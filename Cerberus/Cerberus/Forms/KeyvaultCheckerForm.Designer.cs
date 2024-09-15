namespace Cerberus.Cerberus.Forms
{
    partial class KeyvaultCheckerForm
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
            this.ButtonCheckAll = new DevExpress.XtraEditors.SimpleButton();
            this.ProgressBarKeyvaultChecker = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.ButtonImportKVs = new DevExpress.XtraEditors.SimpleButton();
            this.GridControlKVList = new DevExpress.XtraGrid.GridControl();
            this.GridViewKVList = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarKeyvaultChecker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlKVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKVList)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCheckAll
            // 
            this.ButtonCheckAll.Location = new System.Drawing.Point(12, 433);
            this.ButtonCheckAll.Name = "ButtonCheckAll";
            this.ButtonCheckAll.Size = new System.Drawing.Size(413, 29);
            this.ButtonCheckAll.TabIndex = 1;
            this.ButtonCheckAll.Text = "Check all Keyvaults";
            this.ButtonCheckAll.Click += new System.EventHandler(this.ButtonCheckAll_Click);
            // 
            // ProgressBarKeyvaultChecker
            // 
            this.ProgressBarKeyvaultChecker.EditValue = 0;
            this.ProgressBarKeyvaultChecker.Location = new System.Drawing.Point(12, 405);
            this.ProgressBarKeyvaultChecker.Name = "ProgressBarKeyvaultChecker";
            this.ProgressBarKeyvaultChecker.Size = new System.Drawing.Size(413, 22);
            this.ProgressBarKeyvaultChecker.TabIndex = 2;
            // 
            // ButtonImportKVs
            // 
            this.ButtonImportKVs.Location = new System.Drawing.Point(12, 468);
            this.ButtonImportKVs.Name = "ButtonImportKVs";
            this.ButtonImportKVs.Size = new System.Drawing.Size(413, 29);
            this.ButtonImportKVs.TabIndex = 3;
            this.ButtonImportKVs.Text = "Import Keyvault(s) from PC";
            this.ButtonImportKVs.Click += new System.EventHandler(this.ButtonImportKVs_Click);
            // 
            // GridControlKVList
            // 
            this.GridControlKVList.Location = new System.Drawing.Point(12, 12);
            this.GridControlKVList.MainView = this.GridViewKVList;
            this.GridControlKVList.Name = "GridControlKVList";
            this.GridControlKVList.Size = new System.Drawing.Size(413, 387);
            this.GridControlKVList.TabIndex = 4;
            this.GridControlKVList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewKVList});
            // 
            // GridViewKVList
            // 
            this.GridViewKVList.GridControl = this.GridControlKVList;
            this.GridViewKVList.Name = "GridViewKVList";
            // 
            // KeyvaultCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 507);
            this.Controls.Add(this.GridControlKVList);
            this.Controls.Add(this.ButtonImportKVs);
            this.Controls.Add(this.ProgressBarKeyvaultChecker);
            this.Controls.Add(this.ButtonCheckAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "KeyvaultCheckerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerberus AIO - Keyvault Checker";
            this.Load += new System.EventHandler(this.KeyvaultCheckerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBarKeyvaultChecker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlKVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKVList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ButtonCheckAll;
        private DevExpress.XtraEditors.MarqueeProgressBarControl ProgressBarKeyvaultChecker;
        private DevExpress.XtraEditors.SimpleButton ButtonImportKVs;
        private DevExpress.XtraGrid.GridControl GridControlKVList;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewKVList;
    }
}