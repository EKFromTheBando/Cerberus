using DevExpress.XtraEditors;
using JRPC_Client;
using System;
using XDevkit;

namespace Cerberus.Cerberus
{
    public partial class LEDControlsForm : XtraForm
    {
        private IXboxConsole xboxConsole;

        public LEDControlsForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();
            xboxConsole = xboxConsole;
        }

        private void FanSpeedForm_Load(object sender, EventArgs e)
        {
            // Initialization or setup code can be placed here
        }

        private void ButtonSetFanSpeed_Click(object sender, EventArgs e)
        {
            // Add functionality for setting fan speed here
        }

        private void ButtonSetLEDs_Click(object sender, EventArgs e)
        {
            JRPC.LEDState ledTopLeft = GetLEDState(RadioGroupLEDsTopLeft.SelectedIndex);
            JRPC.LEDState ledTopRight = GetLEDState(RadioGroupLEDsTopRight.SelectedIndex);
            JRPC.LEDState ledBottomLeft = GetLEDState(RadioGroupLEDsBottomLeft.SelectedIndex);
            JRPC.LEDState ledBottomRight = GetLEDState(RadioGroupLEDsBottomRight.SelectedIndex);

            xboxConsole.SetLeds(ledTopLeft, ledTopRight, ledBottomLeft, ledBottomRight);
        }

        private JRPC.LEDState GetLEDState(int index)
        {
            switch (index)
            {
                case 0:
                    return JRPC.LEDState.GREEN;
                case 1:
                    return JRPC.LEDState.ORANGE;
                case 2:
                    return JRPC.LEDState.RED;
                case 3:
                    return JRPC.LEDState.OFF;
                default:
                    return JRPC.LEDState.GREEN;
            }
        }
    }
}
