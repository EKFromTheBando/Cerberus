namespace Cerberus.Cerberus
{
    partial class FanSpeedForm
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
            ButtonSetFanSpeed = new DevExpress.XtraEditors.SimpleButton();
            TrackBarFanSpeed = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(TrackBarFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(TrackBarFanSpeed.Properties)).BeginInit();
            SuspendLayout();
            // 
            // ButtonSetFanSpeed
            // 
            ButtonSetFanSpeed.Location = new System.Drawing.Point(12, 74);
            ButtonSetFanSpeed.Name = "ButtonSetFanSpeed";
            ButtonSetFanSpeed.Size = new System.Drawing.Size(348, 29);
            ButtonSetFanSpeed.TabIndex = 4;
            ButtonSetFanSpeed.Text = "Set Fan Speed";
            ButtonSetFanSpeed.Click += new System.EventHandler(ButtonSetFanSpeed_Click);
            // 
            // TrackBarFanSpeed
            // 
            TrackBarFanSpeed.EditValue = null;
            TrackBarFanSpeed.Location = new System.Drawing.Point(12, 12);
            TrackBarFanSpeed.Name = "TrackBarFanSpeed";
            TrackBarFanSpeed.Properties.LabelAppearance.Options.UseTextOptions = true;
            TrackBarFanSpeed.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            TrackBarFanSpeed.Properties.Maximum = 100;
            TrackBarFanSpeed.Size = new System.Drawing.Size(348, 56);
            TrackBarFanSpeed.TabIndex = 5;
            // 
            // FanSpeedForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(372, 119);
            Controls.Add(TrackBarFanSpeed);
            Controls.Add(ButtonSetFanSpeed);
            FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            Name = "FanSpeedForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cerberus AIO - Fan Speed Utlity";
            TopMost = true;
            Load += new System.EventHandler(FanSpeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(TrackBarFanSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(TrackBarFanSpeed)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ButtonSetFanSpeed;
        private DevExpress.XtraEditors.TrackBarControl TrackBarFanSpeed;
    }
}