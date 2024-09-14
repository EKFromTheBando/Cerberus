using Cerberus.Cerberus.Forms.IO;
using Cerberus.Cerberus.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Isolib.STFSPackage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class GameSaveResignerForm : XtraForm
    {
        private IXboxConsole xboxConsole;
        public GameSaveResignerForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();

            this.xboxConsole = xboxConsole;
        }

        public Stfs PackageGameSave { get; set; }

        public string PackageGameSavePath { get; set; }

        public Stfs PackageProfle { get; set; }


        private void GameSaveResigner_Load(object sender, EventArgs e)
        {
            MenuItemAddProfileFromConsole.Enabled = MainForm.IsConsoleConnected;
        }

        private void GameSaveResigner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PackageGameSave != null)
            {
                PackageGameSave.Close();
            }

            if (PackageProfle != null)
            {
                PackageProfle.Close();
            }
        }

        private void PopupMenuFile_BeforePopup(object sender, CancelEventArgs e)
        {
            MenuItemSaveFile.Enabled = PackageGameSave != null;
            MenuItemSaveToDevice.Enabled = PackageGameSave != null;

            if (PackageGameSave != null)
            {
                if (GetLocalUsbDevices().Count <= 0)
                {
                    MenuItemNoDeviceFound.Enabled = true;
                }
                else
                {
                    foreach (ListItem usbDevice in GetLocalUsbDevices())
                    {
                        BarButtonItem menuItem = new BarButtonItem() { Caption = usbDevice.Name, Name = usbDevice.Name };
                        menuItem.ItemClick += MenuItemDevice_ItemClick;
                        MenuItemSaveToDevice.Links.Add(menuItem);
                    }

                    MenuItemNoDeviceFound.Enabled = false;
                }
            }
        }

        public static List<ListItem> GetLocalUsbDevices()
        {
            List<ListItem> usbDevices = new List<ListItem>();

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    usbDevices.Add(new ListItem
                    {
                        Name = drive.VolumeLabel,
                        Value = drive.Name
                    });
                }
            }

            return usbDevices;
        }

        public class ListItem
        {
            public string Value { get; set; }
            public string Name { get; set; }
        }

        private void MenuItemDevice_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (ListItem usbDevice in GetLocalUsbDevices())
            {
                if (usbDevice.Name == e.Item.Name)
                {
                    PackageGameSave.Finish();
                    PackageGameSave.Close();
                    string installPath = $@"{usbDevice.Value}Game Saves\{TextBoxTitleId.Text}\";
                    File.Copy(PackageGameSavePath, installPath + Path.GetFileName(PackageGameSavePath), true);
                    PackageGameSave = new Stfs(PackageGameSavePath);
                    LoadFile();
                }
            }
        }

        private void MenuItemLoadFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (XtraOpenFileDialog openFileDialog = new XtraOpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PackageGameSave = new Stfs(openFileDialog.FileName);
                    PackageGameSavePath = openFileDialog.FileName;
                    LoadFile();

                    UpdateStatus("Successfully loaded game save.");
                    XtraMessageBox.Show(this, "Successfully loaded game save!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void MenuItemSaveFile_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFile();
        }

        private void PopupImage_BeforePopup(object sender, CancelEventArgs e)
        {
            if (ImageContent.Image == null)
            {
                e.Cancel = true;
            }
        }

        private void MenuItemExtract_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fileName = DialogExtensions.ShowSaveFileDialog(this, "Extract Image", "*.png|PNG Image");

            if (!string.IsNullOrEmpty(fileName))
            {
                ImagePackage.Image.Save(fileName, ImageFormat.Png);
            }
        }

        private void MenuItemReplace_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fileName = DialogExtensions.ShowOpenFileDialog(this, "Replace Image", "PNG Image|*.png");

            if (!string.IsNullOrEmpty(fileName))
            {
                FileInfo fileInfo = new FileInfo(fileName);

                if (fileInfo.Length <= 12000)
                {
                    ImagePackage.LoadAsync(fileName);
                }
                else
                {
                    XtraMessageBox.Show(this, "Image size is too large.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopupMenuProfile_BeforePopup(object sender, CancelEventArgs e)
        {
            MenuItemAddProfileDetails.Enabled = PackageGameSave != null;
            MenuItemAddExistingProfile.Enabled = PackageGameSave != null && Directory.Exists(UserFolders.XboxProfiles);
            MenuItemAddProfileFromConsole.Enabled = PackageGameSave != null && MainForm.IsConsoleConnected;
        }

        private void MenuItemAddProfileDetails_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string fileName = DialogExtensions.ShowOpenFileDialog(this, "Open File", string.Empty);

                if (!string.IsNullOrEmpty(fileName))
                {
                    if (XtraMessageBox.Show(this, "Do you want to save this profile data?", "Save Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string localProfilePath = Path.Combine(UserFolders.XboxProfiles, Path.GetFileName(fileName) + @"\");
                        string localProfileFilePath = Path.Combine(UserFolders.XboxProfiles, Path.GetFileName(fileName) + @"\" + Path.GetFileName(fileName));

                        Directory.CreateDirectory(localProfilePath);
                        File.Copy(fileName, localProfileFilePath + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak");
                    }

                    LoadProfile(fileName);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("Unable to load profile details.", ex);
                XtraMessageBox.Show(this, $"Unable to load profile details. Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ListItem GetXboxProfileFile(IXboxConsole xboxConsole, Form owner)
        {
            List<ListItem> consoleProfiles = new List<ListItem>();
            List<string> consoleProfilesPaths = new List<string>();

            IXboxFiles xboxFiles = xboxConsole.DirectoryFiles(@"Hdd:\Content\");

            foreach (IXboxFile file in xboxFiles)
            {
                if (file.IsDirectory)
                {
                    MessageBox.Show(file.Name);

                    if (!file.Name.Contains("0000000000000000"))
                    {
                        consoleProfilesPaths.Add(file.Name);
                    }
                }
            }

            foreach (string profile in consoleProfilesPaths)
            {
                string profilePath = @"Hdd:\Content\" + profile.Replace(@"Hdd:\Content\", string.Empty) + @"\FFFE07D1\00010000\";

                try
                {
                    foreach (IXboxFile file in xboxConsole.DirectoryFiles(profilePath))
                    {
                        if (!file.IsDirectory)
                        {
                            string profileName = profile.Replace(@"Hdd:\Content\", string.Empty).Replace(@"\FFFE07D1\00010000\", string.Empty);

                            consoleProfiles.Add(new ListItem
                            {
                                Name = profileName,
                                Value = file.Name
                            });
                        }
                    }
                }
                catch
                {
                    // Profile file doesn't exist, so skip to the next one
                    continue;
                }
            }

            if (consoleProfiles.Count > 0)
            {
                return DialogExtensions.ShowListViewDialog(owner, "Choose Profile", consoleProfiles);
            }
            else
            {
                return null;
            }
        }

        private void MenuItemAddExistingProfile_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Directory.Exists(UserFolders.XboxProfiles))
            {
                List<ListItem> profiles = new List<ListItem>();

                foreach (string profile in Directory.GetFiles(UserFolders.XboxProfiles, "*.*", SearchOption.AllDirectories))
                {
                    profiles.Add(new ListItem
                    {
                        Name = Path.GetFileName(profile),
                        Value = profile
                    });
                }

                if (profiles.Count > 0)
                {
                    ListItem profile = DialogExtensions.ShowListViewDialog(this, "Open File", profiles);

                    if (profile == null)
                    {
                        XtraMessageBox.Show(this, "You don't have any profiles saved or none was selected.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LoadProfile(profile.Value);
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "You haven't saved any profiles.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemAddProfileFromConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ListItem selectedProfile = GetXboxProfileFile(xboxConsole, this);

                if (selectedProfile != null)
                {
                    string localProfilePath = Path.Combine(UserFolders.XboxProfiles, selectedProfile.Name + @"\");
                    string localProfileFilePath = Path.Combine(UserFolders.XboxProfiles, selectedProfile.Name + @"\" + selectedProfile.Name);

                    Directory.CreateDirectory(localProfilePath);
                    MainForm.XboxConsole.ReceiveFile(localProfileFilePath, selectedProfile.Value);

                    LoadProfile(localProfileFilePath);
                }
                else
                {
                    UpdateStatus("No profiles were found or you didn't select one.");
                    XtraMessageBox.Show(this, "No profiles were found or you didn't select one.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("Unable to find profile files on console.", ex);
                XtraMessageBox.Show(this, $"Unable to find profile files on console. Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFile()
        {
            try
            {
                TextBoxDisplayName.Text = PackageGameSave.HeaderData.DisplayName;
                TextBoxTitleName.Text = PackageGameSave.HeaderData.TitleName;
                TextBoxProfileId.Text = PackageGameSave.HeaderData.ProfileID;
                TextBoxDeviceId.Text = PackageGameSave.HeaderData.DeviceID;
                TextBoxConsoleId.Text = PackageGameSave.HeaderData.ConsoleID;
                ImagePackage.Image = PackageGameSave.HeaderData.PackageImage;
                ImageContent.Image = PackageGameSave.HeaderData.ContentImage;
                TextBoxTitleId.Text = PackageGameSave.HeaderData.TitleID.TrimStart("0".ToCharArray());
            }
            catch (Exception ex)
            {
                UpdateStatus("Failed to load file.", ex);
                XtraMessageBox.Show(this, $"Failed to load file. Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfile(string fileName)
        {
            PackageProfle = new Stfs(fileName);
            TextBoxProfileId.Text = PackageProfle.HeaderData.ProfileID;
            UpdateStatus("Profile successfully loaded.");
            XtraMessageBox.Show(this, "Profile successfully loaded.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveFile()
        {
            try
            {
                PackageGameSave.Finish();
                XtraMessageBox.Show(this, "Game save successfully resigned and saved!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                UpdateStatus("Unable to save game save.", ex);
                XtraMessageBox.Show(this, $"Unable to save game save. Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatus(string message, Exception ex = null)
        {
            // Implementation of logging or status update
        }
    }
}
