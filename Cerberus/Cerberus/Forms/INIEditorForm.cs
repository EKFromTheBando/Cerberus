using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.RichTextBox;
using JRPC_Client;
using System;
using System.IO;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class INIEditorForm : DevExpress.XtraEditors.XtraForm
    {
        private IXboxConsole xboxConsole;
        private string tempFilePath;
        private string currentFilePath;

        public INIEditorForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();
            this.xboxConsole = xboxConsole;
        }

        private void INIEditorForm_Load(object sender, EventArgs e)
        {
            if (!xboxConsole.Connect(out xboxConsole))
            {
                XtraMessageBox.Show("An error occurred while trying to connect to the console. Please try again.",
                                    "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPullLaunch_Click(object sender, EventArgs e)
        {
            try
            {
                tempFilePath = Path.GetTempFileName(); // Create a temporary file

                // Try to receive file from HDD
                xboxConsole.ReceiveFile(tempFilePath, "Hdd:\\launch.ini");

                // Check if the file is empty or not received properly
                if (new FileInfo(tempFilePath).Length == 0)
                {
                    // If file is empty, try USB
                    xboxConsole.ReceiveFile(tempFilePath, "Usb:\\launch.ini");

                    if (new FileInfo(tempFilePath).Length == 0)
                    {
                        throw new Exception("Failed to receive file from both HDD and USB.");
                    }
                    currentFilePath = "Usb:\\launch.ini";
                }
                else
                {
                    currentFilePath = "Hdd:\\launch.ini";
                }

                MemoEditINI.Text = File.ReadAllText(tempFilePath);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempFilePath == null)
                {
                    XtraMessageBox.Show("No file is loaded to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                File.WriteAllText(tempFilePath, MemoEditINI.Text);

                if (currentFilePath != null)
                {
                    xboxConsole.SendFile(tempFilePath, currentFilePath);
                    XtraMessageBox.Show("Successfully saved changes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("No file path specified to save changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonDiscardChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFilePath == null)
                {
                    XtraMessageBox.Show("No file path specified to discard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                xboxConsole.DeleteFile(currentFilePath);
                XtraMessageBox.Show("File deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonPullOther_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentFilePath == null)
                {
                    XtraMessageBox.Show("No file path specified to pull.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tempFilePath = Path.GetTempFileName(); // Create a temporary file
                xboxConsole.ReceiveFile(tempFilePath, currentFilePath);
                MemoEditINI.Text = File.ReadAllText(tempFilePath);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
