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
            this.ButtonSetFanSpeed = new DevExpress.XtraEditors.SimpleButton();
            this.TrackBarFanSpeed = new DevExpress.XtraEditors.TrackBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSetFanSpeed
            // 
            this.ButtonSetFanSpeed.Location = new System.Drawing.Point(12, 74);
            this.ButtonSetFanSpeed.Name = "ButtonSetFanSpeed";
            this.ButtonSetFanSpeed.Size = new System.Drawing.Size(348, 29);
            this.ButtonSetFanSpeed.TabIndex = 4;
            this.ButtonSetFanSpeed.Text = "Set Fan Speed";
            this.ButtonSetFanSpeed.Click += new System.EventHandler(this.ButtonSetFanSpeed_Click);
            // 
            // TrackBarFanSpeed
            // 
            this.TrackBarFanSpeed.EditValue = null;
            this.TrackBarFanSpeed.Location = new System.Drawing.Point(12, 12);
            this.TrackBarFanSpeed.Name = "TrackBarFanSpeed";
            this.TrackBarFanSpeed.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.TrackBarFanSpeed.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrackBarFanSpeed.Properties.Maximum = 100;
            this.TrackBarFanSpeed.Size = new System.Drawing.Size(348, 56);
            this.TrackBarFanSpeed.TabIndex = 5;
            // 
            // FanSpeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 119);
            this.Controls.Add(this.TrackBarFanSpeed);
            this.Controls.Add(this.ButtonSetFanSpeed);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "FanSpeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerberus AIO - Fan Speed Utlity";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FanSpeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarFanSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton ButtonSetFanSpeed;
        private DevExpress.XtraEditors.TrackBarControl TrackBarFanSpeed;
    }
}