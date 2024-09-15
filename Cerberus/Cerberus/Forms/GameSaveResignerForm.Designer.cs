using DevExpress.XtraEditors;
using System.ComponentModel;
using Cerberus.Cerberus.Forms.IO;

namespace Cerberus.Cerberus.Forms
{
    partial class GameSaveResignerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ImageContent = new DevExpress.XtraEditors.PictureEdit();
            LabelHeaderTitleId = new DevExpress.XtraEditors.LabelControl();
            TextBoxTitleId = new DevExpress.XtraEditors.TextEdit();
            TextBoxDeviceId = new DevExpress.XtraEditors.TextEdit();
            TextBoxProfileId = new DevExpress.XtraEditors.TextEdit();
            TextBoxConsoleId = new DevExpress.XtraEditors.TextEdit();
            TextBoxTitleName = new DevExpress.XtraEditors.TextEdit();
            TextBoxDisplayName = new DevExpress.XtraEditors.TextEdit();
            ImagePackage = new DevExpress.XtraEditors.PictureEdit();
            LabelHeaderDeviceId = new DevExpress.XtraEditors.LabelControl();
            LabelHeaderProfileId = new DevExpress.XtraEditors.LabelControl();
            LabelHeaderConsoleId = new DevExpress.XtraEditors.LabelControl();
            LabelHeaderTitleName = new DevExpress.XtraEditors.LabelControl();
            LabelHeaderDisplayName = new DevExpress.XtraEditors.LabelControl();
            ImageBackground = new DevExpress.XtraEditors.PictureEdit();
            BarManager = new DevExpress.XtraBars.BarManager(components);
            MenuMain = new DevExpress.XtraBars.Bar();
            MenuButtonFile = new DevExpress.XtraBars.BarButtonItem();
            PopupMenuFile = new DevExpress.XtraBars.PopupMenu(components);
            MenuItemLoadFile = new DevExpress.XtraBars.BarButtonItem();
            MenuItemSaveFile = new DevExpress.XtraBars.BarButtonItem();
            MenuItemSaveToDevice = new DevExpress.XtraBars.BarSubItem();
            MenuItemNoDeviceFound = new DevExpress.XtraBars.BarButtonItem();
            MenuButtonProfile = new DevExpress.XtraBars.BarButtonItem();
            PopupMenuProfile = new DevExpress.XtraBars.PopupMenu(components);
            MenuItemAddProfileDetails = new DevExpress.XtraBars.BarButtonItem();
            MenuItemAddExistingProfile = new DevExpress.XtraBars.BarButtonItem();
            MenuItemAddProfileFromConsole = new DevExpress.XtraBars.BarButtonItem();
            MenuStatus = new DevExpress.XtraBars.Bar();
            LabelHeaderStatus = new DevExpress.XtraBars.BarStaticItem();
            LabelStatus = new DevExpress.XtraBars.BarStaticItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            MenuItemReplace = new DevExpress.XtraBars.BarButtonItem();
            MenuItemExtract = new DevExpress.XtraBars.BarButtonItem();
            PopupImage = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)(ImageContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxTitleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxDeviceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxProfileId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxConsoleId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxTitleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ImagePackage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ImageBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(PopupMenuFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(PopupMenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(PopupImage)).BeginInit();
            SuspendLayout();
            // 
            // ImageContent
            // 
            ImageContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ImageContent.Location = new System.Drawing.Point(548, 62);
            ImageContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ImageContent.Name = "ImageContent";
            ImageContent.Properties.AllowFocused = false;
            ImageContent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            ImageContent.Properties.NullText = " ";
            ImageContent.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            ImageContent.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            ImageContent.Size = new System.Drawing.Size(85, 85);
            ImageContent.TabIndex = 14;
            // 
            // LabelHeaderTitleId
            // 
            LabelHeaderTitleId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            LabelHeaderTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderTitleId.Appearance.Options.UseFont = true;
            LabelHeaderTitleId.Location = new System.Drawing.Point(439, 170);
            LabelHeaderTitleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderTitleId.Name = "LabelHeaderTitleId";
            LabelHeaderTitleId.Size = new System.Drawing.Size(51, 20);
            LabelHeaderTitleId.TabIndex = 18;
            LabelHeaderTitleId.Text = "Title ID:";
            // 
            // TextBoxTitleId
            // 
            TextBoxTitleId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxTitleId.EditValue = "";
            TextBoxTitleId.Location = new System.Drawing.Point(500, 166);
            TextBoxTitleId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxTitleId.Name = "TextBoxTitleId";
            TextBoxTitleId.Properties.AllowFocused = false;
            TextBoxTitleId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxTitleId.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            TextBoxTitleId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxTitleId.Properties.Appearance.Options.UseBackColor = true;
            TextBoxTitleId.Properties.Appearance.Options.UseFont = true;
            TextBoxTitleId.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            TextBoxTitleId.Properties.AppearanceFocused.Options.UseBackColor = true;
            TextBoxTitleId.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            TextBoxTitleId.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            TextBoxTitleId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            TextBoxTitleId.Properties.MaxLength = 8;
            TextBoxTitleId.Properties.NullValuePrompt = "None";
            TextBoxTitleId.Properties.ReadOnly = true;
            TextBoxTitleId.Size = new System.Drawing.Size(142, 26);
            TextBoxTitleId.TabIndex = 17;
            // 
            // TextBoxDeviceId
            // 
            TextBoxDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxDeviceId.Location = new System.Drawing.Point(135, 166);
            TextBoxDeviceId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxDeviceId.Name = "TextBoxDeviceId";
            TextBoxDeviceId.Properties.AllowFocused = false;
            TextBoxDeviceId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxDeviceId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxDeviceId.Properties.Appearance.Options.UseFont = true;
            TextBoxDeviceId.Properties.MaxLength = 40;
            TextBoxDeviceId.Properties.NullValuePrompt = "None";
            TextBoxDeviceId.Size = new System.Drawing.Size(280, 26);
            TextBoxDeviceId.TabIndex = 7;
            // 
            // TextBoxProfileId
            // 
            TextBoxProfileId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxProfileId.Location = new System.Drawing.Point(135, 129);
            TextBoxProfileId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxProfileId.Name = "TextBoxProfileId";
            TextBoxProfileId.Properties.AllowFocused = false;
            TextBoxProfileId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxProfileId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxProfileId.Properties.Appearance.Options.UseFont = true;
            TextBoxProfileId.Properties.MaxLength = 16;
            TextBoxProfileId.Properties.NullValuePrompt = "None";
            TextBoxProfileId.Size = new System.Drawing.Size(280, 26);
            TextBoxProfileId.TabIndex = 6;
            // 
            // TextBoxConsoleId
            // 
            TextBoxConsoleId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxConsoleId.Location = new System.Drawing.Point(135, 204);
            TextBoxConsoleId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxConsoleId.Name = "TextBoxConsoleId";
            TextBoxConsoleId.Properties.AllowFocused = false;
            TextBoxConsoleId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxConsoleId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxConsoleId.Properties.Appearance.Options.UseFont = true;
            TextBoxConsoleId.Properties.MaxLength = 10;
            TextBoxConsoleId.Properties.NullValuePrompt = "None";
            TextBoxConsoleId.Size = new System.Drawing.Size(280, 26);
            TextBoxConsoleId.TabIndex = 8;
            // 
            // TextBoxTitleName
            // 
            TextBoxTitleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxTitleName.Location = new System.Drawing.Point(135, 91);
            TextBoxTitleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxTitleName.Name = "TextBoxTitleName";
            TextBoxTitleName.Properties.AllowFocused = false;
            TextBoxTitleName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxTitleName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxTitleName.Properties.Appearance.Options.UseFont = true;
            TextBoxTitleName.Properties.NullValuePrompt = "None";
            TextBoxTitleName.Size = new System.Drawing.Size(280, 26);
            TextBoxTitleName.TabIndex = 5;
            // 
            // TextBoxDisplayName
            // 
            TextBoxDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            TextBoxDisplayName.Location = new System.Drawing.Point(135, 54);
            TextBoxDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBoxDisplayName.Name = "TextBoxDisplayName";
            TextBoxDisplayName.Properties.AllowFocused = false;
            TextBoxDisplayName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            TextBoxDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            TextBoxDisplayName.Properties.Appearance.Options.UseFont = true;
            TextBoxDisplayName.Properties.NullValuePrompt = "None";
            TextBoxDisplayName.Size = new System.Drawing.Size(280, 26);
            TextBoxDisplayName.TabIndex = 4;
            // 
            // ImagePackage
            // 
            ImagePackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ImagePackage.Location = new System.Drawing.Point(450, 62);
            ImagePackage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ImagePackage.Name = "ImagePackage";
            ImagePackage.Properties.AllowFocused = false;
            ImagePackage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            ImagePackage.Properties.NullText = " ";
            ImagePackage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            ImagePackage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            ImagePackage.Size = new System.Drawing.Size(85, 85);
            ImagePackage.TabIndex = 15;
            // 
            // LabelHeaderDeviceId
            // 
            LabelHeaderDeviceId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderDeviceId.Appearance.Options.UseFont = true;
            LabelHeaderDeviceId.Location = new System.Drawing.Point(15, 170);
            LabelHeaderDeviceId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderDeviceId.Name = "LabelHeaderDeviceId";
            LabelHeaderDeviceId.Size = new System.Drawing.Size(67, 20);
            LabelHeaderDeviceId.TabIndex = 12;
            LabelHeaderDeviceId.Text = "Device ID:";
            // 
            // LabelHeaderProfileId
            // 
            LabelHeaderProfileId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderProfileId.Appearance.Options.UseFont = true;
            LabelHeaderProfileId.Location = new System.Drawing.Point(15, 132);
            LabelHeaderProfileId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderProfileId.Name = "LabelHeaderProfileId";
            LabelHeaderProfileId.Size = new System.Drawing.Size(65, 20);
            LabelHeaderProfileId.TabIndex = 10;
            LabelHeaderProfileId.Text = "Profile ID:";
            // 
            // LabelHeaderConsoleId
            // 
            LabelHeaderConsoleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderConsoleId.Appearance.Options.UseFont = true;
            LabelHeaderConsoleId.Location = new System.Drawing.Point(15, 208);
            LabelHeaderConsoleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderConsoleId.Name = "LabelHeaderConsoleId";
            LabelHeaderConsoleId.Size = new System.Drawing.Size(75, 20);
            LabelHeaderConsoleId.TabIndex = 8;
            LabelHeaderConsoleId.Text = "Console ID:";
            // 
            // LabelHeaderTitleName
            // 
            LabelHeaderTitleName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderTitleName.Appearance.Options.UseFont = true;
            LabelHeaderTitleName.Location = new System.Drawing.Point(15, 95);
            LabelHeaderTitleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderTitleName.Name = "LabelHeaderTitleName";
            LabelHeaderTitleName.Size = new System.Drawing.Size(76, 20);
            LabelHeaderTitleName.TabIndex = 6;
            LabelHeaderTitleName.Text = "Title Name:";
            // 
            // LabelHeaderDisplayName
            // 
            LabelHeaderDisplayName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            LabelHeaderDisplayName.Appearance.Options.UseFont = true;
            LabelHeaderDisplayName.Location = new System.Drawing.Point(15, 58);
            LabelHeaderDisplayName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            LabelHeaderDisplayName.Name = "LabelHeaderDisplayName";
            LabelHeaderDisplayName.Size = new System.Drawing.Size(96, 20);
            LabelHeaderDisplayName.TabIndex = 4;
            LabelHeaderDisplayName.Text = "Display Name:";
            // 
            // ImageBackground
            // 
            ImageBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            ImageBackground.Location = new System.Drawing.Point(440, 54);
            ImageBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ImageBackground.Name = "ImageBackground";
            ImageBackground.Properties.AllowFocused = false;
            ImageBackground.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            ImageBackground.Properties.NullText = " ";
            ImageBackground.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            ImageBackground.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            ImageBackground.Size = new System.Drawing.Size(202, 102);
            ImageBackground.TabIndex = 19;
            // 
            // BarManager
            // 
            BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            MenuMain,
            MenuStatus});
            BarManager.DockControls.Add(barDockControlTop);
            BarManager.DockControls.Add(barDockControlBottom);
            BarManager.DockControls.Add(barDockControlLeft);
            BarManager.DockControls.Add(barDockControlRight);
            BarManager.Form = this;
            BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            MenuButtonFile,
            MenuItemLoadFile,
            MenuItemSaveFile,
            LabelHeaderStatus,
            LabelStatus,
            MenuItemReplace,
            MenuItemExtract,
            MenuButtonProfile,
            MenuItemAddProfileDetails,
            MenuItemAddProfileFromConsole,
            MenuItemAddExistingProfile,
            MenuItemSaveToDevice,
            MenuItemNoDeviceFound});
            BarManager.MainMenu = MenuMain;
            BarManager.MaxItemId = 20;
            BarManager.StatusBar = MenuStatus;
            // 
            // MenuMain
            // 
            MenuMain.BarItemHorzIndent = 6;
            MenuMain.BarItemVertIndent = 5;
            MenuMain.BarName = "Main menu";
            MenuMain.DockCol = 0;
            MenuMain.DockRow = 0;
            MenuMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            MenuMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(MenuButtonFile),
            new DevExpress.XtraBars.LinkPersistInfo(MenuButtonProfile)});
            MenuMain.OptionsBar.AllowQuickCustomization = false;
            MenuMain.OptionsBar.DrawBorder = false;
            MenuMain.OptionsBar.DrawDragBorder = false;
            MenuMain.OptionsBar.MultiLine = true;
            MenuMain.OptionsBar.RotateWhenVertical = false;
            MenuMain.OptionsBar.UseWholeRow = true;
            MenuMain.Text = "Main menu";
            // 
            // MenuButtonFile
            // 
            MenuButtonFile.ActAsDropDown = true;
            MenuButtonFile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            MenuButtonFile.Caption = "File";
            MenuButtonFile.DropDownControl = PopupMenuFile;
            MenuButtonFile.Id = 2;
            MenuButtonFile.Name = "MenuButtonFile";
            // 
            // PopupMenuFile
            // 
            PopupMenuFile.AutoFillEditorWidth = false;
            PopupMenuFile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            PopupMenuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemLoadFile),
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemSaveFile),
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemSaveToDevice)});
            PopupMenuFile.Manager = BarManager;
            PopupMenuFile.Name = "PopupMenuFile";
            PopupMenuFile.BeforePopup += new System.ComponentModel.CancelEventHandler(PopupMenuFile_BeforePopup);
            // 
            // MenuItemLoadFile
            // 
            MenuItemLoadFile.Caption = "Load File...";
            MenuItemLoadFile.Id = 3;
            MenuItemLoadFile.Name = "MenuItemLoadFile";
            MenuItemLoadFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemLoadFile_ItemClick);
            // 
            // MenuItemSaveFile
            // 
            MenuItemSaveFile.Caption = "Save File...";
            MenuItemSaveFile.Id = 5;
            MenuItemSaveFile.Name = "MenuItemSaveFile";
            MenuItemSaveFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemSaveFile_ItemClick);
            // 
            // MenuItemSaveToDevice
            // 
            MenuItemSaveToDevice.Caption = "Save to Device...";
            MenuItemSaveToDevice.Id = 16;
            MenuItemSaveToDevice.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemNoDeviceFound)});
            MenuItemSaveToDevice.Name = "MenuItemSaveToDevice";
            // 
            // MenuItemNoDeviceFound
            // 
            MenuItemNoDeviceFound.Caption = "No Devices Found";
            MenuItemNoDeviceFound.Enabled = false;
            MenuItemNoDeviceFound.Id = 17;
            MenuItemNoDeviceFound.Name = "MenuItemNoDeviceFound";
            MenuItemNoDeviceFound.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            MenuItemNoDeviceFound.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // MenuButtonProfile
            // 
            MenuButtonProfile.ActAsDropDown = true;
            MenuButtonProfile.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            MenuButtonProfile.Caption = "Profile";
            MenuButtonProfile.DropDownControl = PopupMenuProfile;
            MenuButtonProfile.Id = 10;
            MenuButtonProfile.Name = "MenuButtonProfile";
            // 
            // PopupMenuProfile
            // 
            PopupMenuProfile.AutoFillEditorWidth = false;
            PopupMenuProfile.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            PopupMenuProfile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemAddProfileDetails),
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemAddExistingProfile),
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemAddProfileFromConsole)});
            PopupMenuProfile.Manager = BarManager;
            PopupMenuProfile.Name = "PopupMenuProfile";
            PopupMenuProfile.BeforePopup += new System.ComponentModel.CancelEventHandler(PopupMenuProfile_BeforePopup);
            // 
            // MenuItemAddProfileDetails
            // 
            MenuItemAddProfileDetails.Caption = "Add Profile Details...";
            MenuItemAddProfileDetails.Id = 11;
            MenuItemAddProfileDetails.Name = "MenuItemAddProfileDetails";
            MenuItemAddProfileDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemAddProfileDetails_ItemClick);
            // 
            // MenuItemAddExistingProfile
            // 
            MenuItemAddExistingProfile.Caption = "Add Existing Profile...";
            MenuItemAddExistingProfile.Id = 13;
            MenuItemAddExistingProfile.Name = "MenuItemAddExistingProfile";
            MenuItemAddExistingProfile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemAddExistingProfile_ItemClick);
            // 
            // MenuItemAddProfileFromConsole
            // 
            MenuItemAddProfileFromConsole.Caption = "Add Profile From Console...";
            MenuItemAddProfileFromConsole.Id = 12;
            MenuItemAddProfileFromConsole.Name = "MenuItemAddProfileFromConsole";
            MenuItemAddProfileFromConsole.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemAddProfileFromConsole_ItemClick);
            // 
            // MenuStatus
            // 
            MenuStatus.BarItemVertIndent = 4;
            MenuStatus.BarName = "Status bar";
            MenuStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            MenuStatus.DockCol = 0;
            MenuStatus.DockRow = 0;
            MenuStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            MenuStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(LabelHeaderStatus),
            new DevExpress.XtraBars.LinkPersistInfo(LabelStatus)});
            MenuStatus.OptionsBar.AllowQuickCustomization = false;
            MenuStatus.OptionsBar.DrawDragBorder = false;
            MenuStatus.OptionsBar.UseWholeRow = true;
            MenuStatus.Text = "Status bar";
            // 
            // LabelHeaderStatus
            // 
            LabelHeaderStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            LabelHeaderStatus.Caption = "Status:";
            LabelHeaderStatus.Id = 6;
            LabelHeaderStatus.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            LabelHeaderStatus.ItemAppearance.Normal.Options.UseFont = true;
            LabelHeaderStatus.LeftIndent = 2;
            LabelHeaderStatus.Name = "LabelHeaderStatus";
            // 
            // LabelStatus
            // 
            LabelStatus.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            LabelStatus.Caption = "Idle";
            LabelStatus.Id = 7;
            LabelStatus.Name = "LabelStatus";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = BarManager;
            barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            barDockControlTop.Size = new System.Drawing.Size(658, 29);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 256);
            barDockControlBottom.Manager = BarManager;
            barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            barDockControlBottom.Size = new System.Drawing.Size(658, 32);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            barDockControlLeft.Manager = BarManager;
            barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            barDockControlLeft.Size = new System.Drawing.Size(0, 227);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(658, 29);
            barDockControlRight.Manager = BarManager;
            barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            barDockControlRight.Size = new System.Drawing.Size(0, 227);
            // 
            // MenuItemReplace
            // 
            MenuItemReplace.Caption = "Replace...";
            MenuItemReplace.Id = 8;
            MenuItemReplace.Name = "MenuItemReplace";
            MenuItemReplace.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemReplace_ItemClick);
            // 
            // MenuItemExtract
            // 
            MenuItemExtract.Caption = "Extract...";
            MenuItemExtract.Id = 9;
            MenuItemExtract.Name = "MenuItemExtract";
            MenuItemExtract.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(MenuItemExtract_ItemClick);
            // 
            // PopupImage
            // 
            PopupImage.AutoFillEditorWidth = false;
            PopupImage.DrawMenuSideStrip = DevExpress.Utils.DefaultBoolean.False;
            PopupImage.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemExtract),
            new DevExpress.XtraBars.LinkPersistInfo(MenuItemReplace)});
            PopupImage.Manager = BarManager;
            PopupImage.Name = "PopupImage";
            PopupImage.BeforePopup += new System.ComponentModel.CancelEventHandler(PopupImage_BeforePopup);
            // 
            // GameSaveResignerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(658, 288);
            Controls.Add(ImageContent);
            Controls.Add(LabelHeaderTitleId);
            Controls.Add(LabelHeaderDisplayName);
            Controls.Add(TextBoxTitleId);
            Controls.Add(ImageBackground);
            Controls.Add(TextBoxDeviceId);
            Controls.Add(LabelHeaderTitleName);
            Controls.Add(TextBoxProfileId);
            Controls.Add(LabelHeaderConsoleId);
            Controls.Add(TextBoxConsoleId);
            Controls.Add(LabelHeaderProfileId);
            Controls.Add(TextBoxTitleName);
            Controls.Add(LabelHeaderDeviceId);
            Controls.Add(TextBoxDisplayName);
            Controls.Add(ImagePackage);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            IconOptions.ColorizeInactiveIcon = DevExpress.Utils.DefaultBoolean.True;
            IconOptions.Image = global::Cerberus.Properties.Resources.cerb1;
            IconOptions.ShowIcon = false;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameSaveResignerForm";
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cerberus AIO - Game Save Resiger";
            FormClosing += new System.Windows.Forms.FormClosingEventHandler(GameSaveResigner_FormClosing);
            Load += new System.EventHandler(GameSaveResigner_Load);
            ((System.ComponentModel.ISupportInitialize)(ImageContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxTitleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxDeviceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxProfileId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxConsoleId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxTitleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TextBoxDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ImagePackage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ImageBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(PopupMenuFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(PopupMenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(PopupImage)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private LabelControl LabelHeaderDisplayName;
        private LabelControl LabelHeaderConsoleId;
        private LabelControl LabelHeaderTitleName;
        private LabelControl LabelHeaderDeviceId;
        private LabelControl LabelHeaderProfileId;
        private PictureEdit ImageContent;
        private PictureEdit ImagePackage;
        private TextEdit TextBoxDeviceId;
        private TextEdit TextBoxProfileId;
        private TextEdit TextBoxConsoleId;
        private TextEdit TextBoxTitleName;
        private TextEdit TextBoxDisplayName;
        private LabelControl LabelHeaderTitleId;
        private TextEdit TextBoxTitleId;
        private PictureEdit ImageBackground;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar MenuMain;
        private DevExpress.XtraBars.Bar MenuStatus;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem MenuButtonFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemLoadFile;
        private DevExpress.XtraBars.PopupMenu PopupMenuFile;
        private DevExpress.XtraBars.BarButtonItem MenuItemSaveFile;
        private DevExpress.XtraBars.BarStaticItem LabelHeaderStatus;
        private DevExpress.XtraBars.BarStaticItem LabelStatus;
        private DevExpress.XtraBars.BarButtonItem MenuItemReplace;
        private DevExpress.XtraBars.BarButtonItem MenuItemExtract;
        private DevExpress.XtraBars.PopupMenu PopupImage;
        private DevExpress.XtraBars.BarButtonItem MenuButtonProfile;
        private DevExpress.XtraBars.PopupMenu PopupMenuProfile;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileDetails;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddProfileFromConsole;
        private DevExpress.XtraBars.BarButtonItem MenuItemAddExistingProfile;
        private DevExpress.XtraBars.BarSubItem MenuItemSaveToDevice;
        private DevExpress.XtraBars.BarButtonItem MenuItemNoDeviceFound;
    }
}