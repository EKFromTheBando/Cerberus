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
            GroupListItems = new DevExpress.XtraEditors.GroupControl();
            GridControlListItems = new DevExpress.XtraGrid.GridControl();
            GridViewListItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(GroupListItems)).BeginInit();
            GroupListItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(GridControlListItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(GridViewListItems)).BeginInit();
            SuspendLayout();
            // 
            // GroupListItems
            // 
            GroupListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            GroupListItems.Controls.Add(GridControlListItems);
            GroupListItems.Location = new System.Drawing.Point(13, 13);
            GroupListItems.Margin = new System.Windows.Forms.Padding(4);
            GroupListItems.Name = "GroupListItems";
            GroupListItems.Size = new System.Drawing.Size(231, 269);
            GroupListItems.TabIndex = 4;
            GroupListItems.Text = "Choose Item...";
            // 
            // GridControlListItems
            // 
            GridControlListItems.Dock = System.Windows.Forms.DockStyle.Fill;
            GridControlListItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            GridControlListItems.Location = new System.Drawing.Point(2, 28);
            GridControlListItems.MainView = GridViewListItems;
            GridControlListItems.Margin = new System.Windows.Forms.Padding(0);
            GridControlListItems.Name = "GridControlListItems";
            GridControlListItems.Size = new System.Drawing.Size(227, 239);
            GridControlListItems.TabIndex = 1;
            GridControlListItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            GridViewListItems});
            // 
            // GridViewListItems
            // 
            GridViewListItems.ActiveFilterEnabled = false;
            GridViewListItems.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            GridViewListItems.DetailHeight = 437;
            GridViewListItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            GridViewListItems.GridControl = GridControlListItems;
            GridViewListItems.Name = "GridViewListItems";
            GridViewListItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            GridViewListItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            GridViewListItems.OptionsBehavior.Editable = false;
            GridViewListItems.OptionsBehavior.ReadOnly = true;
            GridViewListItems.OptionsCustomization.AllowFilter = false;
            GridViewListItems.OptionsEditForm.PopupEditFormWidth = 1000;
            GridViewListItems.OptionsFilter.AllowFilterEditor = false;
            GridViewListItems.OptionsMenu.ShowAutoFilterRowItem = false;
            GridViewListItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            GridViewListItems.OptionsView.ShowColumnHeaders = false;
            GridViewListItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            GridViewListItems.OptionsView.ShowGroupExpandCollapseButtons = false;
            GridViewListItems.OptionsView.ShowGroupPanel = false;
            GridViewListItems.OptionsView.ShowIndicator = false;
            GridViewListItems.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            // 
            // ListViewDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(257, 295);
            Controls.Add(GroupListItems);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListViewDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cereberus AIO";
            ((System.ComponentModel.ISupportInitialize)(GroupListItems)).EndInit();
            GroupListItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(GridControlListItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(GridViewListItems)).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupListItems;
        private DevExpress.XtraGrid.GridControl GridControlListItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewListItems;
    }
}