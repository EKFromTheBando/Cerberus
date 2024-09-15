using Cerberus.Cerberus.Security;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DiscordRPC;
using JRPC_Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class MainForm : RibbonForm
    {
        public static IXboxConsole XboxConsole;
        private bool IsAuthenticated = false;
        private readonly string _connectionString;
        private string _xblStatus;
        private DiscordRpcClient _client;
        private System.Timers.Timer _processTimer;


        public static bool IsConsoleConnected { get; private set; } = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeProcessTimer();

            // Set up password text box
            var passwordTextEdit = new RepositoryItemTextEdit
            {
                PasswordChar = '*'
            };
            TextEditPassword.Edit = passwordTextEdit;

            var connectionStringSettings = ConfigurationManager.ConnectionStrings["UserInfoDb"];
            if (connectionStringSettings == null)
            {
                Console.WriteLine("Connection string 'UserInfoDb' not found.");
                // Handle the error or exit
                return;
            }

            _connectionString = connectionStringSettings.ConnectionString;
        }

        private void InitializeDiscordRPC()
        {
            if (_client != null)
                return; // Already initialized

            _client = new DiscordRpcClient("1284223639675211867");
            _client.Initialize();
            UpdatePresence("Playing Cerberus AIO", "In Dashboard"); // Initial status
        }

        private void UpdatePresence(string state, string details)
        {
            if (_client != null)
            {
                _client.SetPresence(new DiscordRPC.RichPresence
                {
                    Details = details,
                    State = state,
                    Timestamps = Timestamps.Now,
                    Buttons = new[]
                    {
                        new DiscordRPC.Button { Label = "Visit the Cerberus AIO Discord!", Url = "https://discord.gg/cerberusaio" },
                    }
                });
            }
        }

        // Event Handlers
        private void ButtonConnectConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            ConnectToConsole();
        }

        private void ButtonDisconnectConsole_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole?.CloseConnection(3);
            ButtonDisconnectConsole.Enabled = false;
        }

        private void ButtonShutdown_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole?.ShutDownConsole();
        }

        private void ButtonRebootWarm_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole?.Reboot(null, null, null, XboxRebootFlags.Warm);
        }

        private void ButtonRebootCold_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole?.Reboot(null, null, null, XboxRebootFlags.Cold);
        }

        private void ButtonDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            XboxConsole?.Reboot(null, null, null, XboxRebootFlags.Title);
        }

        private void ButtonFreeze_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                bool isFrozen;
                XboxConsole.DebugTarget.Stop(out isFrozen);

                if (isFrozen)
                {
                    XtraMessageBox.Show(XboxConsole.Name + " is already frozen.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void InitializeProcessTimer()
        {
            _processTimer = new System.Timers.Timer(15000); // 15 seconds interval
            _processTimer.Elapsed += OnProcessTimerElapsed;
            _processTimer.Start();
        }

        private void OnProcessTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Processes.Pulse();
        }

        private void ButtonDiscordPresence_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (ButtonDiscordPresence.Checked)
            {
                InitializeDiscordRPC();
            }
            else
            {
                DisposeDiscordRPC();
            }
        }

        private void DisposeDiscordRPC()
        {
            _client?.Dispose();
            _client = null;
        }

        private void ButtonToolSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Implement tool settings logic here
        }

        private void ButtonUnfreeze_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (XboxConsole != null)
                {
                    bool isFrozen;
                    XboxConsole.DebugTarget.Go(out isFrozen);
                }
            }
            catch
            {
                XtraMessageBox.Show("Failed to unfreeze " + XboxConsole?.Name, "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonXNotify_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                new XNotificationForm(XboxConsole).Show();
            }
        }

        private void ButtonScreenshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                new ScreenshotForm(XboxConsole).Show();
            }
        }

        private void ButtonModuleConfigurator_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                new ModuleConfigurator(XboxConsole).Show();
            }
        }

        private void ButtonModuleLibrary_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                new ModuleLibForm(XboxConsole).Show();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshConsoleInfo();
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            ExportConsoleInfo();
        }

        private void PictureBoxAutolobbies_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/GYXCWtsQYM");
        }

        private void PictureBoxXBLGhost_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/zanDRNEsgf");
        }

        // Console Connection
        private void ConnectToConsole()
        {
            if (XboxConsole.Connect(out XboxConsole))
            {
                RefreshConsoleInfo();
                ButtonDisconnectConsole.Enabled = true;
                IsConsoleConnected = true;
            }
            else
            {
                XtraMessageBox.Show("Failed to connect to the console.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Console Info Methods
        private void RefreshConsoleInfo()
        {
            string consoleType = XboxConsole.ConsoleType();
            txtKernal.Text = "Kernal: " + XboxConsole.GetKernalVersion();
            textEdit2.Text = "Connected To Xbox Live: " + XblCheck();
            txtGamertag.Text = "Gamertag: " + Encoding.BigEndianUnicode.GetString(XboxConsole.GetMemory(2175412476U, 30U)).Trim();
            txtConsoleIP.Text = "Console IP: " + XboxConsole.XboxIP();
            txtCPUKey.Text = "CPU Key: " + XboxConsole.GetCPUKey();
            txtMoboType.Text = "Motherboard Type: " + consoleType;
            txtMoboTemp.Text = "Motherboard Temperature: " + XboxConsole.GetTemperature(JRPC.TemperatureType.MotherBoard).ToString() + "°C";
            txtCpuTemp.Text = "CPU Temperature: " + XboxConsole.GetTemperature(JRPC.TemperatureType.CPU).ToString() + "°C";
            txtGpuTemp.Text = "GPU Temperature: " + XboxConsole.GetTemperature(JRPC.TemperatureType.GPU).ToString() + "°C";
            txtTitleID.Text = "Title ID: " + XboxConsole.XamGetCurrentTitleId().ToString("X");
            txtCurrentPath.Text = "Path: " + XboxConsole.DebugTarget.RunningProcessInfo.ProgramName.Replace("\\Device\\Harddisk0\\Partition1", "Hdd:");

            // Update console image
            UpdateConsoleImage(consoleType);
        }

        private string XblCheck()
        {
            if (XboxConsole != null)
            {
                uint num = XboxConsole.Call<uint>(2171219848U, new object[] { 252, 360451U, 0, 0 });
                _xblStatus = (num == 1380593U) ? "False" : "True";
                return _xblStatus;
            }
            return "Unknown";
        }

        private void UpdateConsoleImage(string consoleType)
        {
            if (consoleType == "Falcon" || consoleType == "Jasper")
            {
                pictureBoxConsole.Image = Properties.Resources.XboxFat;
            }
            else if (consoleType == "Trinity" || consoleType == "Corona")
            {
                pictureBoxConsole.Image = Properties.Resources.XboxSlim;
            }
            else
            {
                pictureBoxConsole.Image = Properties.Resources.XboxSlim;
            }
        }

        // Export Console Info
        private void ExportConsoleInfo()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save Console Information";
                saveFileDialog.FileName = "ConsoleInformation.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, string.Concat(
                        "Console Information - Generated by Cerberus AIO", Environment.NewLine,
                        txtKernal.Text, Environment.NewLine,
                        txtConsoleIP.Text, Environment.NewLine,
                        txtMoboType.Text, Environment.NewLine,
                        txtTitleID.Text, Environment.NewLine,
                        txtMoboTemp.Text, Environment.NewLine,
                        txtCpuTemp.Text, Environment.NewLine,
                        txtGpuTemp.Text, Environment.NewLine,
                        txtCPUKey.Text
                    ));

                    XtraMessageBox.Show($"Saved Console Information.txt to {filePath}", base.Name, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void ButtonRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            new UserRegstrationForm().Show();
        }

        public static string HashPassword(string password, out byte[] salt)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                salt = new byte[16];
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                byte[] hashBytes = new byte[36];
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                return Convert.ToBase64String(hashBytes);
            }
        }

        private bool VerifyPassword(string storedHash, string enteredPassword)
        {
            var hashBytes = Convert.FromBase64String(storedHash);

            // Log the stored hash bytes
            Console.WriteLine("Stored Hash Bytes: " + BitConverter.ToString(hashBytes));

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Log the extracted salt
            Console.WriteLine("Extracted Salt: " + BitConverter.ToString(salt));

            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000))
            {
                byte[] hash = pbkdf2.GetBytes(20);

                // Log the derived hash
                Console.WriteLine("Derived Hash: " + BitConverter.ToString(hash));

                for (int i = 0; i < 20; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        // Log the mismatching byte
                        Console.WriteLine($"Mismatch at byte {i}: {hashBytes[i + 16]} != {hash[i]}");
                        return false;
                    }
                }
            }
            return true;
        }


        private void ButtonLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            string username = TextEditUsername.EditValue?.ToString();
            string password = TextEditPassword.EditValue?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                XtraMessageBox.Show("Please enter both username and password.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT PasswordHash, IsUserBanned FROM UserInfo WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 256).Value = username;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPasswordHash = reader["PasswordHash"].ToString();
                            bool isUserBanned = Convert.ToBoolean(reader["IsUserBanned"]);

                            if (isUserBanned)
                            {
                                XtraMessageBox.Show("Your account has been banned. Please contact support.", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Application.Exit(); // Close the application
                                return;
                                //Add haxxor code to blow up their pc i reckon
                            }

                            if (VerifyPassword(storedPasswordHash, password))
                            {
                                XtraMessageBox.Show("Login successful.", "Cerberus AIO");
                                IsAuthenticated = true;
                                
                                if (CheckEditRememberLogin.Checked == true) { SaveUserCredentials(username); }

                                ConnectToConsole();
                                UpdateCpuKeyIfNeeded(username);


                                EnableControls();
                                RibbonControlMain.ApplicationButtonText = username;
                            }
                            else
                            {
                                XtraMessageBox.Show("Invalid password.", "Cerberus AIO");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Username not found.", "Cerberus AIO");
                        }
                    }
                }
            }
        }


        private void SaveUserCredentials(string username)
        {
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Password = TextEditPassword.EditValue?.ToString();
            Properties.Settings.Default.Save();
        }

        private void UpdateCpuKeyIfNeeded(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Retrieve the existing CPU Key (if any)
                string query = "SELECT CPUKey FROM UserInfo WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 256).Value = username;
                    var result = cmd.ExecuteScalar();

                    if (result == null || string.IsNullOrEmpty(result.ToString()))
                    {
                        // If CPU Key is not present, generate and insert it
                        string cpuKey = XboxConsole.GetCPUKey();
                        if (cpuKey != null)
                        {
                            string updateQuery = "UPDATE UserInfo SET CPUKey = @CPUKey WHERE Username = @Username";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.Add("@CPUKey", SqlDbType.NVarChar, 256).Value = cpuKey;
                                updateCmd.Parameters.Add("@Username", SqlDbType.NVarChar, 256).Value = username;
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }


        private void ButtonGameSaveResigner_ItemClick(object sender, ItemClickEventArgs e)
        {
            new GameSaveResignerForm(XboxConsole).Show();
        }

        private void ButtonFanSpeed_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                new FanSpeedForm().Show();
            }
        }

        private void ButtonLEDSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            new LEDControlsForm(XboxConsole).Show();
        }

        private void xtraTabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            string tabName = xtraTabControl1.SelectedTabPage.Text; // Get the current tab name
            UpdatePresence("Playing Cerberus AIO", $"In {tabName}");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeDiscordRPC();
            base.OnFormClosing(e);
            _processTimer?.Stop();
            _processTimer?.Dispose();
        }

        private void ButtonClearCache_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XboxConsole != null)
            {
                List<IXboxFile> filesToDelete = new List<IXboxFile>(); // List to store files
                int successfulDeletions = 0; // Number of successfully deleted files

                try
                {
                    IXboxFiles xboxFiles = XboxConsole.DirectoryFiles(@"Hdd:\Cache\");

                    // Collect files into the list
                    foreach (IXboxFile xboxFile in xboxFiles)
                    {
                        filesToDelete.Add(xboxFile);
                    }

                    // Total number of files to process
                    int totalFiles = filesToDelete.Count;

                    // Process each file
                    foreach (IXboxFile xboxFile in filesToDelete)
                    {
                        if (xboxFile.Name == "PS_0000106.0000000000000")
                        {
                            // Skip this file because it's problematic
                            continue;
                        }

                        try
                        {
                            XboxConsole.DeleteFile(xboxFile.Name);
                            successfulDeletions++; // Increment count for successful deletions
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error deleting file {xboxFile.Name}: {ex.Message}", "Error");
                            // Continue to the next file
                        }
                    }

                    // Calculate success percentage
                    double successPercentage = (totalFiles > 0) ? successfulDeletions / (double)totalFiles * 100 : 0;

                    // Determine if a high percentage of files were successfully deleted
                    if (successPercentage >= 80) // For example, 80% success rate
                    {
                        XtraMessageBox.Show("Console cache has been reset successfully!", "Cerberus AIO");
                    }
                    else
                    {
                        XtraMessageBox.Show("Some files could not be deleted. Please check the error messages.", "Cerberus AIO");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Error retrieving files: {ex.Message}", "Error");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplySavedTheme();
            DisableControls();
            Processes.Pulse();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                TextEditUsername.EditValue = Properties.Settings.Default.Username;
                TextEditPassword.EditValue = Properties.Settings.Default.Password;
            }
        }

        // Call this method when a user selects a theme from the DevExpress skin options
        private void SaveSelectedTheme(string themeName)
        {
            Properties.Settings.Default.SelectedTheme = themeName;
            Properties.Settings.Default.Save(); // Save the theme setting
        }
        private void ApplySavedTheme()
        {
            // Check if there is a saved theme, then apply it
            string savedTheme = Properties.Settings.Default.SelectedTheme;
            if (!string.IsNullOrEmpty(savedTheme))
            {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(savedTheme);
            }
            else
            {
                // Set a default theme if no theme is saved
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("WXICompact");
            }
        }


        private void DisableControls()
        {
            ButtonConnectConsole.Enabled = false;
            // Loop through controls on the form (Controls)
            foreach (Control control in Controls)
            {
                // Exclude the login controls and the RibbonControl from being disabled
                if (control.Name != "ButtonRegister" &&
                    control.Name != "ButtonLogin" &&
                    control.Name != "ButtonConnect" &&
                    control.Name != "TextEditUsername" &&
                    control.Name != "TextEditPassword" &&
                    !(control is DevExpress.XtraBars.Ribbon.RibbonControl))  // Exclude the RibbonControl
                {
                    control.Enabled = false;
                }
            }

            // Loop through controls on each tab page in the XtraTabControl
            foreach (DevExpress.XtraTab.XtraTabPage tabPage in xtraTabControl1.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    control.Enabled = false;
                }
            }
        }

        private void EnableControls()
        {
            // Enable ButtonConnectConsole
            ButtonConnectConsole.Enabled = true;

            // Loop through controls on the form (Controls)
            foreach (Control control in Controls)
            {
                // Exclude the login controls and the RibbonControl from being enabled
                if (control.Name != "ButtonRegister" &&
                    control.Name != "ButtonLogin" &&
                    control.Name != "ButtonConnect" &&
                    control.Name != "TextEditUsername" &&
                    control.Name != "TextEditPassword" &&
                    !(control is RibbonControl))  // Exclude the RibbonControl
                {
                    control.Enabled = true;
                }
            }

            // Loop through controls on each tab page in the XtraTabControl
            foreach (DevExpress.XtraTab.XtraTabPage tabPage in xtraTabControl1.TabPages)
            {
                foreach (Control control in tabPage.Controls)
                {
                    control.Enabled = true;
                }
            }
        }

        private void ButtonKeyvaultChecker_ItemClick(object sender, ItemClickEventArgs e)
        {
            new KeyvaultCheckerForm().Show();
        }

        private void RibbonControlMain_Click(object sender, EventArgs e)
        {

        }

        private void ButtonINIEditor_ItemClick(object sender, ItemClickEventArgs e)
        {
            new INIEditorForm(XboxConsole).Show();
        }
    }
    
}
