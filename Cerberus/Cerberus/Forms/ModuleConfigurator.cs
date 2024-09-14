using DevExpress.XtraEditors;
using JRPC_Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class ModuleConfigurator : DevExpress.XtraEditors.XtraForm
    {
        private IXboxConsole xboxConsole;
        public ModuleConfigurator(IXboxConsole xboxConsole)
        {
            InitializeComponent();
            this.xboxConsole = xboxConsole;
        }

        private void ModuleConfigurator_Load(object sender, EventArgs e)
        {
            if (!xboxConsole.Connect(out xboxConsole))
            {
                XtraMessageBox.Show("An error occurred while trying to connect to the console. Please try again.",
                                    "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                xboxConsole.DebugTarget.ConnectAsDebugger("jtag", XboxDebugConnectFlags.Force);
            }
        }

        private void ButtonRefreshModules_Click(object sender, EventArgs e)
        {
            RefreshModules();
        }

        public class ModuleInfo
        {
            public string Name { get; set; }
            public string BaseAddress { get; set; }
            public string Size { get; set; }
        }

        private void RefreshModules()
        {
            moduleGridView.Columns.Clear();

            List<ModuleInfo> moduleList = new List<ModuleInfo>();

            // Add the list as the data source of the GridControl
            ModuleGridControl.DataSource = moduleList;

            // Loop through each module in the console's debugger target
            foreach (IXboxModule xboxModule in xboxConsole.DebugTarget.Modules)
            {
                string name = xboxModule.ModuleInfo.Name;
                string baseAddressHex = $"0x{xboxModule.ModuleInfo.BaseAddress:X}";
                string sizeHex = $"0x{xboxModule.ModuleInfo.Size:X}";

                // Create a new ModuleInfo instance
                ModuleInfo newModuleInfo = new ModuleInfo
                {
                    Name = name,
                    BaseAddress = baseAddressHex,
                    Size = sizeHex
                };

                // Add the new item to the list
                moduleList.Add(newModuleInfo);
            }

            // Refresh the GridControl to reflect the new data
            ModuleGridControl.RefreshDataSource();
        }

        private void ButtonClearModules_Click(object sender, EventArgs e)
        {
            moduleGridView.Columns.Clear();
        }

        private void ButtonInjectFromPC_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Title = "Select a File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = Path.GetFileName(openFileDialog.FileName);
                    var filePath = Path.Combine("Hdd:\\", fileName);

                    try
                    {
                        xboxConsole.SendFile(openFileDialog.FileName, filePath);
                        xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[] { filePath, 8, 0, 0 });

                        ButtonRefreshModules_Click(sender, e);
                        XtraMessageBox.Show("Successfully injected module!", "Cerberus AIO");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Failed to inject module: {ex.Message}", "Injection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void ButtonInjectFromConsole_Click(object sender, EventArgs e)
        {
            var modulePath = TextEditPath.Text;
            try
            {
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[] { modulePath, 8, 0, 0 });

                ButtonRefreshModules_Click(sender, null);
                xboxConsole.XNotify("Successfully injected module!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
    }
}