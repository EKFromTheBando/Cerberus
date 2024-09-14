using Cerberus.Cerberus.Forms;
using DevExpress.LookAndFeel;
using System;
using System.Windows.Forms;

namespace Cerberus
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Set the style to use skin technology
            UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin;

            // Here we specify the skin to use by its name
            UserLookAndFeel.Default.SetSkinStyle("WXI Compact", "Darkness");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
