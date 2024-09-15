using Cerberus.Cerberus.Helpers;
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus
{
    public partial class FanSpeedForm : XtraForm
    {
        private XboxConsole console;
        private XboxManager manager;
        private readonly Cerberus.Helpers.EndianIO xms;
        private uint connection;

        public FanSpeedForm()
        {
            InitializeComponent();

            try
            {
                manager = new XboxManager();
                try { console = manager.OpenConsole(File.Exists("OverrideConsoleName.txt") ? File.ReadAllText("OverrideConsoleName.txt") : manager.DefaultConsole); }
                catch (Exception) { console = manager.OpenConsole(manager.DefaultConsole); }
                connection = console.OpenConnection(null);
                xms = new Cerberus.Helpers.EndianIO(new XboxMemoryStream(console.DebugTarget), EndianTypes.BigEndian);
                var smcVerRequest = new byte[16];
                var smcVerResponse = new byte[16];
                smcVerRequest[0] = (byte)XboxHelpers.SMCCommands.SMC_QUERY_VERSION;
                XboxHelpers.HalSendSMCMessage(console, smcVerRequest, ref smcVerResponse);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format("Failed to connect to {0}. Make sure {0} is powered on, responsive, and connected to the local network.{1}{2}", manager.DefaultConsole, Environment.NewLine, XboxHelpers.CreateExceptionMessage(ex, manager)), "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        private void FanSpeedForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSetFanSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                var smcFanRequest = new byte[16];
                byte[] smcFanResponse = null;
                smcFanRequest[0] = (byte)XboxHelpers.SMCCommands.SMC_SET_FAN_SPEED_CPU;
                smcFanRequest[1] = (byte)(TrackBarFanSpeed.Value < 45 ? 0x7F : TrackBarFanSpeed.Value | 0x80);
                XboxHelpers.HalSendSMCMessage(console, smcFanRequest, ref smcFanResponse);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Failed to set the fan speed: " + ex, "Cerberus AIO");
            }
        }
    }
}
