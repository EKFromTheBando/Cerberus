namespace Cerberus.Cerberus.Forms
{
    partial class ScreenshotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxScreenshot = new DevExpress.XtraEditors.PictureEdit();
            this.ButtonCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonExportScreenshot = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonTakeScreenshot = new DevExpress.XtraEditors.SimpleButton();
            this.ToggleUploadToImgur = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxScreenshot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleUploadToImgur.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxScreenshot
            // 
            this.PictureBoxScreenshot.Location = new System.Drawing.Point(16, 15);
            this.PictureBoxScreenshot.Name = "PictureBoxScreenshot";
            this.PictureBoxScreenshot.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureBoxScreenshot.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureBoxScreenshot.Size = new System.Drawing.Size(640, 360);
            this.PictureBoxScreenshot.TabIndex = 1;
            // 
            // ButtonCopyToClipboard
            // 
            this.ButtonCopyToClipboard.Location = new System.Drawing.Point(169, 381);
            this.ButtonCopyToClipboard.Name = "ButtonCopyToClipboard";
            this.ButtonCopyToClipboard.Size = new System.Drawing.Size(129, 44);
            this.ButtonCopyToClipboard.TabIndex = 4;
            this.ButtonCopyToClipboard.Text = "Copy to Clipboard";
            this.ButtonCopyToClipboard.Click += new System.EventHandler(this.ButtonCopyToClipboard_Click);
            // 
            // ButtonExportScreenshot
            // 
            this.ButtonExportScreenshot.Appearance.Options.UseTextOptions = true;
            this.ButtonExportScreenshot.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ButtonExportScreenshot.Location = new System.Drawing.Point(304, 381);
            this.ButtonExportScreenshot.Name = "ButtonExportScreenshot";
            this.ButtonExportScreenshot.Size = new System.Drawing.Size(129, 44);
            this.ButtonExportScreenshot.TabIndex = 7;
            this.ButtonExportScreenshot.Text = "Export Screenshot";
            this.ButtonExportScreenshot.Click += new System.EventHandler(this.ButtonExportScreenshot_Click);
            // 
            // ButtonTakeScreenshot
            // 
            this.ButtonTakeScreenshot.Location = new System.Drawing.Point(34, 381);
            this.ButtonTakeScreenshot.Name = "ButtonTakeScreenshot";
            this.ButtonTakeScreenshot.Size = new System.Drawing.Size(129, 44);
            this.ButtonTakeScreenshot.TabIndex = 2;
            this.ButtonTakeScreenshot.Text = "Take Screenshot";
            this.ButtonTakeScreenshot.Click += new System.EventHandler(this.ButtonTakeScreenshot_Click);
            // 
            // ToggleUploadToImgur
            // 
            this.ToggleUploadToImgur.Location = new System.Drawing.Point(543, 389);
            this.ToggleUploadToImgur.Name = "ToggleUploadToImgur";
            this.ToggleUploadToImgur.Properties.OffText = "Off";
            this.ToggleUploadToImgur.Properties.OnText = "On";
            this.ToggleUploadToImgur.Size = new System.Drawing.Size(95, 29);
            this.ToggleUploadToImgur.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(439, 395);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Upload to Imgur?";
            // 
            // ScreenshotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 440);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ToggleUploadToImgur);
            this.Controls.Add(this.ButtonTakeScreenshot);
            this.Controls.Add(this.ButtonExportScreenshot);
            this.Controls.Add(this.ButtonCopyToClipboard);
            this.Controls.Add(this.PictureBoxScreenshot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "ScreenshotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerberus AIO - Screenshot Utility";
            this.Load += new System.EventHandler(this.ScreenshotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxScreenshot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleUploadToImgur.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PictureBoxScreenshot;
        private DevExpress.XtraEditors.SimpleButton ButtonCopyToClipboard;
        private DevExpress.XtraEditors.SimpleButton ButtonExportScreenshot;
        private DevExpress.XtraEditors.SimpleButton ButtonTakeScreenshot;
        private DevExpress.XtraEditors.ToggleSwitch ToggleUploadToImgur;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}