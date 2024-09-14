using DevExpress.XtraEditors;
using JRPC_Client;
using SixLabors.ImageSharp;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;

namespace Cerberus.Cerberus.Forms
{
    public partial class ScreenshotForm : DevExpress.XtraEditors.XtraForm
    {
        private IXboxConsole xboxConsole;
        private string localFilePath;
        private static readonly string ImgurClientId = "803d02d377bd042";
        private string screenshotPath = "screenshot.bmp";
        private string pngPath = "screenshot.png";
        public ScreenshotForm(IXboxConsole xboxConsole)
        {
            InitializeComponent();

            this.xboxConsole = xboxConsole;
        }

        public static string GetNextFileName(string fileName)
        {
            string extension = Path.GetExtension(fileName);

            int i = 0;
            while (File.Exists(fileName))
            {
                fileName = i == 0 ? fileName.Replace(extension, "-" + ++i + extension) : fileName.Replace("-" + i + extension, "-" + ++i + extension);
            }

            return fileName;
        }

        private void ScreenshotForm_Load(object sender, EventArgs e)
        {
            if (!xboxConsole.Connect(out xboxConsole))
            {
                XtraMessageBox.Show("An error occurred while trying to connect to the console. Please try again.",
                                    "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ButtonTakeScreenshot_Click(object sender, EventArgs e)
        {
            string screenshotPath = "screenshot.bmp";
            string pngPath = "screenshot.png";

            // Delete the existing screenshot files if they exist
            if (File.Exists(screenshotPath))
            {
                File.Delete(screenshotPath);
            }

            if (File.Exists(pngPath))
            {
                File.Delete(pngPath);
            }

            // Capture the screenshot and save it directly
            xboxConsole.ScreenShot(screenshotPath);

            // Check if the file was created and if its size is greater than 0
            if (File.Exists(screenshotPath))
            {
                FileInfo fileInfo = new FileInfo(screenshotPath);
                if (fileInfo.Length == 0)
                {
                    XtraMessageBox.Show("Screenshot capture failed, the file is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Dispose the previous image if it exists
                if (PictureBoxScreenshot.Image != null)
                {
                    PictureBoxScreenshot.Image.Dispose();
                    PictureBoxScreenshot.Image = null;
                }

                try
                {
                    // Load the BMP screenshot into the PictureBox control
                    using (var bmpStream = new FileStream(screenshotPath, FileMode.Open, FileAccess.Read))
                    {
                        PictureBoxScreenshot.Image = System.Drawing.Image.FromStream(bmpStream);
                    }

                    if (ToggleUploadToImgur.IsOn == true)
                    {
                        // Convert BMP to PNG
                        using (var bmpStream = new FileStream(screenshotPath, FileMode.Open, FileAccess.Read))
                        {
                            using (var image = SixLabors.ImageSharp.Image.Load(bmpStream))
                            {
                                using (var pngStream = new FileStream(pngPath, FileMode.Create, FileAccess.Write))
                                {
                                    image.SaveAsPng(pngStream);
                                }
                            }
                        }

                        string imgurUrl = await UploadToImgur(pngPath);
                        if (!string.IsNullOrEmpty(imgurUrl))
                        {
                            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = imgurUrl,
                                UseShellExecute = true
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Failed to load screenshot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Deletes the screenshot files if no longer needed
                    File.Delete(screenshotPath);
                    if (File.Exists(pngPath))
                    {
                        File.Delete(pngPath);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Screenshot capture failed, the file was not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (PictureBoxScreenshot.Image == null)
            {
                XtraMessageBox.Show("No screenshot was found, so there isn't any to copy to clipboard!\nIgnore next messagebox!", "Cerberus AIO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Clipboard.SetImage(PictureBoxScreenshot.Image);
            }
            XtraMessageBox.Show("Copied Screenshot to Clipboard!", "Tom's Awful RGH Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (PictureBoxScreenshot.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Images|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureBoxScreenshot.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                XtraMessageBox.Show("No screenshot was found, so there isn't any to save!", "Tom's Awful RGH Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ButtonUploadToImgur_Click(object sender, EventArgs e)
        {
            using (var bmpStream = new FileStream(screenshotPath, FileMode.Open, FileAccess.Read))
            {
                using (var image = SixLabors.ImageSharp.Image.Load(bmpStream))
                {
                    using (var pngStream = new FileStream(pngPath, FileMode.Create, FileAccess.Write))
                    {
                        image.SaveAsPng(pngStream);
                    }
                }
            }
        }

        private async Task<string> UploadToImgur(string filePath)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Client-ID {ImgurClientId}");

                    using (var content = new MultipartFormDataContent())
                    {
                        using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                        {
                            var fileContent = new StreamContent(fileStream);
                            fileContent.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("image/png");
                            content.Add(fileContent, "image", "screenshot.png");

                            var response = await client.PostAsync("https://api.imgur.com/3/image", content);
                            var responseString = await response.Content.ReadAsStringAsync();

                            if (!response.IsSuccessStatusCode)
                            {
                                // Log the status code and response content for debugging
                                XtraMessageBox.Show($"Imgur API Error: {response.StatusCode} - {responseString}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }

                            Console.WriteLine($"Imgur API Response: {responseString}"); // Log the response for debugging

                            dynamic responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject(responseString);
                            return responseObject?.data?.link;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or show the error
                XtraMessageBox.Show($"Failed to upload screenshot to Imgur: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ButtonExportScreenshot_Click(object sender, EventArgs e)
        {
            if (PictureBoxScreenshot.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "BMP Images|*.bmp";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Save image to memory stream first
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            // Clone the image
                            using (System.Drawing.Image clonedImage = (System.Drawing.Image)PictureBoxScreenshot.Image.Clone())
                            {
                                // Save to memory stream
                                clonedImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);

                                // Write memory stream to file
                                File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Failed to save the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No screenshot was found, so there isn't any to save!", "Tom's Awful RGH Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


    }
}