using DevExpress.XtraEditors;
using JRPC_Client;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class ModuleLibForm : DevExpress.XtraEditors.XtraForm
    {
        private IXboxConsole xboxConsole;
        private string lastInjectedModule;
        public ModuleLibForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();
            xboxConsole = xboxConsole;
        }

        private void ModuleLibForm_Load(object sender, EventArgs e)
        {
            if (!xboxConsole.Connect(out xboxConsole))
            {
                XtraMessageBox.Show("An error occurred while trying to connect to the console. Please try again.",
                                    "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private uint GetModuleAddress(string moduleName)
        {
            // Retrieve the address of the specified module
            object[] parameters = new object[] { moduleName };
            return xboxConsole.Call<uint>("xam.xex", 1102, parameters);
        }

        private void InjectOrUnloadModule(string moduleName, bool inject)
        {
            uint moduleAddress = GetModuleAddress(moduleName);
            if (moduleAddress > 0U)
            {
                if (inject)
                {
                    // Write a value to the module address to inject it
                    xboxConsole.WriteInt16(moduleAddress + 64U, 1);
                }
                object[] parameters = new object[] { moduleAddress };
                xboxConsole.CallVoid("xboxkrnl.exe", 417, parameters);
            }
        }

        private void ButtonMyten_Click(object sender, EventArgs e)
        {
            //awaiting upload
        }

        private void ButtonZhivaBO1_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "BO1.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/BO1.xex", "./BO1.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./BO1.xex", "Hdd:\\BO1.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\BO1.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva BO1");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./BO1.xex");
            xboxConsole.DeleteFile("Hdd:\\BO1.xex");

        }

        private void ButtonZhivaBO1Host_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "BO1Host.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/BO1Host.xex", "./BO1Host.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./BO1Host.xex", "Hdd:\\BO1Host.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\BO1Host.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva BO1 [Host]");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./BO1Host.xex");
            xboxConsole.DeleteFile("Hdd:\\BO1Host.xex");
        }

        private void ButtonZhivaBO2_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "BO2.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/BO2.xex", "./BO2.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./BO2.xex", "Hdd:\\BO2.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\BO2.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva BO2");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./BO2.xex");
            xboxConsole.DeleteFile("Hdd:\\BO2.xex");
        }

        private void ButtonZhivaWAW_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "WAW.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/WAW.xex", "./WAW.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./WAW.xex", "Hdd:\\WAW.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\WAW.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva WAW");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./WAW.xex");
            xboxConsole.DeleteFile("Hdd:\\WAW.xex");
        }

        private void ButtonZhivaCOD4_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "COD4.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/COD4.xex", "./COD4.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./COD4.xex", "Hdd:\\COD4.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\COD4.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva COD4");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./COD4.xex");
            xboxConsole.DeleteFile("Hdd:\\COD4.xex");
        }

        private void ButtonZhivaGhosts_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "Ghosts.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/Ghosts.xex", "./Ghosts.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./Ghosts.xex", "Hdd:\\Ghosts.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
         "Hdd:\\Ghosts.xex",
         8, // Flags
         0, // Unknown
         0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva Ghosts");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./Ghosts.xex");
            xboxConsole.DeleteFile("Hdd:\\Ghosts.xex");
        }

        private void ButtonZhivaMW2_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "MW2.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/MW2.xex", "./MW2.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./MW2.xex", "Hdd:\\MW2.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\MW2.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva MW2");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./MW2.xex");
            xboxConsole.DeleteFile("Hdd:\\MW2.xex");
        }

        private void ButtonZhivaMW3_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "MW3.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/MW3.xex", "./MW3.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./MW3.xex", "Hdd:\\MW3.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\MW3.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva MW3");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./MW3.xex");
            xboxConsole.DeleteFile("Hdd:\\MW3.xex");
        }

        private void ButtonZhivaMW3Host_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "MW3Host.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/MW3Host.xex", "./MW3Host.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./MW3Host.xex", "Hdd:\\MW3Host.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\MW3Host.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva MW3 [Host]");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./MW3Host.xex");
            xboxConsole.DeleteFile("Hdd:\\MW3Host.xex");
        }

        private void ButtonZhivaMW2Host_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "MW2Host.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/zhiva/MW2Host.xex", "./MW2Host.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./MW2Host.xex", "Hdd:\\MW2Host.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\MW2Host.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: Zhiva MW2 [Host]");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./MW2Host.xex");
            xboxConsole.DeleteFile("Hdd:\\MW2Host.xex");
        }

        private void ButtonDestruction_Click(object sender, EventArgs e)
        {
            //awaiting upload
        }

        private void ButtonAntiCrash_Click(object sender, EventArgs e)
        {

        }

        private void ButtonXBPirate_Click(object sender, EventArgs e)
        {
            lastInjectedModule = "xbPirate.xex";
            using (WebClient webClient = new WebClient())
            {
                // Download the module file
                webClient.DownloadFile(" https://aio.thebando.site/modules/xbPirate.xex", "./xbPirate.xex");
            }

            // Send the module file to the Xbox console
            xboxConsole.SendFile("./xbPirate.xex", "Hdd:\\xbPirate.xex");

            try
            {
                // Inject the module into the Xbox console
                xboxConsole.Call<uint>("xboxkrnl.exe", 409, new object[]
                {
                    "Hdd:\\xbPirate.xex",
                    8, // Flags
                    0, // Unknown
                    0  // Unknown
                });
                xboxConsole.XNotify("Module Injected: xbPirate");
            }
            catch
            {
                xboxConsole.XNotify("Failed to inject module.");
            }

            // Clean up local and console files
            File.Delete("./xbPirate.xex");
            xboxConsole.DeleteFile("Hdd:\\xbPirate.xex");
        }

        private void ButtonUnload_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastInjectedModule))
            {
                InjectOrUnloadModule(lastInjectedModule, true);
                xboxConsole.XNotify("Module Unloaded: " + lastInjectedModule);
            }
            else
            {
                XtraMessageBox.Show("No previously injected module found.", "Module Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}