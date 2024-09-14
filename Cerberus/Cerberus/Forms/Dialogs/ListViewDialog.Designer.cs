namespace Cerberus.Cerberus.Forms.Dialogs
{
    partial class ListViewDialog
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
            this.GroupListItems = new DevExpress.XtraEditors.GroupControl();
            this.GridControlListItems = new DevExpress.XtraGrid.GridControl();
            this.GridViewListItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).BeginInit();
            this.GroupListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListItems
            // 
            this.GroupListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupListItems.Controls.Add(this.GridControlListItems);
            this.GroupListItems.Location = new System.Drawing.Point(13, 13);
            this.GroupListItems.Margin = new System.Windows.Forms.Padding(4);
            this.GroupListItems.Name = "GroupListItems";
            this.GroupListItems.Size = new System.Drawing.Size(231, 269);
            this.GroupListItems.TabIndex = 4;
            this.GroupListItems.Text = "Choose Item...";
            // 
            // GridControlListItems
            // 
            this.GridControlListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlListItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridControlListItems.Location = new System.Drawing.Point(2, 28);
            this.GridControlListItems.MainView = this.GridViewListItems;
            this.GridControlListItems.Margin = new System.Windows.Forms.Padding(0);
            this.GridControlListItems.Name = "GridControlListItems";
            this.GridControlListItems.Size = new System.Drawing.Size(227, 239);
            this.GridControlListItems.TabIndex = 1;
            this.GridControlListItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewListItems});
            // 
            // GridViewListItems
            // 
            this.GridViewListItems.ActiveFilterEnabled = false;
            this.GridViewListItems.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GridViewListItems.DetailHeight = 437;
            this.GridViewListItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GridViewListItems.GridControl = this.GridControlListItems;
            this.GridViewListItems.Name = "GridViewListItems";
            this.GridViewListItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewListItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewListItems.OptionsBehavior.Editable = false;
            this.GridViewListItems.OptionsBehavior.ReadOnly = true;
            this.GridViewListItems.OptionsCustomization.AllowFilter = false;
            this.GridViewListItems.OptionsEditForm.PopupEditFormWidth = 1000;
            this.GridViewListItems.OptionsFilter.AllowFilterEditor = false;
            this.GridViewListItems.OptionsMenu.ShowAutoFilterRowItem = false;
            this.GridViewListItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GridViewListItems.OptionsView.ShowColumnHeaders = false;
            this.GridViewListItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.GridViewListItems.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.GridViewListItems.OptionsView.ShowGroupPanel = false;
            this.GridViewListItems.OptionsView.ShowIndicator = false;
            this.GridViewListItems.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // ListViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 295);
            this.Controls.Add(this.GroupListItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListViewDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cereberus AIO";
            ((System.ComponentModel.ISupportInitialize)(this.GroupListItems)).EndInit();
            this.GroupListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupListItems;
        private DevExpress.XtraGrid.GridControl GridControlListItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewListItems;
    }
}