using DevExpress.XtraEditors;
using JRPC_Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus
{
    public partial class XNotificationForm : XtraForm
    {
        private IXboxConsole xboxConsole;

        // Dictionary to map ComboBoxIcons index to notification codes
        private readonly Dictionary<int, uint> notificationIconCodes = new Dictionary<int, uint>
        {
            { 0, 1U }, { 1, 2U }, { 2, 3U }, { 3, 4U }, { 4, 5U },
            { 5, 6U }, { 6, 7U }, { 7, 8U }, { 8, 9U }, { 9, 10U },
            { 10, 11U }, { 11, 12U }, { 12, 13U }, { 13, 14U }, { 14, 15U },
            { 15, 16U }, { 16, 18U }, { 17, 19U }, { 18, 20U }, { 19, 21U },
            { 20, 22U }, { 21, 27U }, { 22, 31U }
        };

        public XNotificationForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();
            xboxConsole = xboxConsole;
        }

        private void XNotificationForm_Load(object sender, EventArgs e)
        {
            if (!xboxConsole.Connect(out xboxConsole))
            {
                XtraMessageBox.Show("An error occurred while trying to connect to the console. Please try again.",
                                    "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSendNotification_Click(object sender, EventArgs e)
        {
            string message = TextEditMessage.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                XtraMessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ComboBoxIcons.SelectedIndex >= 0 && notificationIconCodes.TryGetValue(ComboBoxIcons.SelectedIndex, out uint code))
            {
                xboxConsole.XNotify(message, code);
            }
            else
            {
                xboxConsole.XNotify(message);
            }
        }
    }
}
