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
            PictureBoxScreenshot = new DevExpress.XtraEditors.PictureEdit();
            ButtonCopyToClipboard = new DevExpress.XtraEditors.SimpleButton();
            ButtonExportScreenshot = new DevExpress.XtraEditors.SimpleButton();
            ButtonTakeScreenshot = new DevExpress.XtraEditors.SimpleButton();
            ToggleUploadToImgur = new DevExpress.XtraEditors.ToggleSwitch();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(PictureBoxScreenshot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ToggleUploadToImgur.Properties)).BeginInit();
            SuspendLayout();
            // 
            // PictureBoxScreenshot
            // 
            PictureBoxScreenshot.Location = new System.Drawing.Point(16, 15);
            PictureBoxScreenshot.Name = "PictureBoxScreenshot";
            PictureBoxScreenshot.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            PictureBoxScreenshot.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            PictureBoxScreenshot.Size = new System.Drawing.Size(640, 360);
            PictureBoxScreenshot.TabIndex = 1;
            // 
            // ButtonCopyToClipboard
            // 
            ButtonCopyToClipboard.Location = new System.Drawing.Point(169, 381);
            ButtonCopyToClipboard.Name = "ButtonCopyToClipboard";
            ButtonCopyToClipboard.Size = new System.Drawing.Size(129, 44);
            ButtonCopyToClipboard.TabIndex = 4;
            ButtonCopyToClipboard.Text = "Copy to Clipboard";
            ButtonCopyToClipboard.Click += new System.EventHandler(ButtonCopyToClipboard_Click);
            // 
            // ButtonExportScreenshot
            // 
            ButtonExportScreenshot.Appearance.Options.UseTextOptions = true;
            ButtonExportScreenshot.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            ButtonExportScreenshot.Location = new System.Drawing.Point(304, 381);
            ButtonExportScreenshot.Name = "ButtonExportScreenshot";
            ButtonExportScreenshot.Size = new System.Drawing.Size(129, 44);
            ButtonExportScreenshot.TabIndex = 7;
            ButtonExportScreenshot.Text = "Export Screenshot";
            ButtonExportScreenshot.Click += new System.EventHandler(ButtonExportScreenshot_Click);
            // 
            // ButtonTakeScreenshot
            // 
            ButtonTakeScreenshot.Location = new System.Drawing.Point(34, 381);
            ButtonTakeScreenshot.Name = "ButtonTakeScreenshot";
            ButtonTakeScreenshot.Size = new System.Drawing.Size(129, 44);
            ButtonTakeScreenshot.TabIndex = 2;
            ButtonTakeScreenshot.Text = "Take Screenshot";
            ButtonTakeScreenshot.Click += new System.EventHandler(ButtonTakeScreenshot_Click);
            // 
            // ToggleUploadToImgur
            // 
            ToggleUploadToImgur.Location = new System.Drawing.Point(543, 389);
            ToggleUploadToImgur.Name = "ToggleUploadToImgur";
            ToggleUploadToImgur.Properties.OffText = "Off";
            ToggleUploadToImgur.Properties.OnText = "On";
            ToggleUploadToImgur.Size = new System.Drawing.Size(95, 29);
            ToggleUploadToImgur.TabIndex = 8;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(439, 395);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(98, 16);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Upload to Imgur?";
            // 
            // ScreenshotForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(672, 440);
            Controls.Add(labelControl1);
            Controls.Add(ToggleUploadToImgur);
            Controls.Add(ButtonTakeScreenshot);
            Controls.Add(ButtonExportScreenshot);
            Controls.Add(ButtonCopyToClipboard);
            Controls.Add(PictureBoxScreenshot);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            Name = "ScreenshotForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cerberus AIO - Screenshot Utility";
            Load += new System.EventHandler(ScreenshotForm_Load);
            ((System.ComponentModel.ISupportInitialize)(PictureBoxScreenshot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ToggleUploadToImgur.Properties)).EndInit();
            ResumeLayout(false);
            PerformLayout();

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