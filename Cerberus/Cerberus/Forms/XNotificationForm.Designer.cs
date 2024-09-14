namespace Cerberus.Cerberus
{
    partial class XNotificationForm
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
            this.TextEditMessage = new DevExpress.XtraEditors.TextEdit();
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.LabelIcon = new DevExpress.XtraEditors.LabelControl();
            this.ComboBoxIcons = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ButtonSendNotification = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxIcons.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextEditMessage
            // 
            this.TextEditMessage.Location = new System.Drawing.Point(78, 12);
            this.TextEditMessage.Name = "TextEditMessage";
            this.TextEditMessage.Size = new System.Drawing.Size(282, 26);
            this.TextEditMessage.TabIndex = 0;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Location = new System.Drawing.Point(17, 17);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(55, 16);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Message:";
            // 
            // LabelIcon
            // 
            this.LabelIcon.Location = new System.Drawing.Point(43, 59);
            this.LabelIcon.Name = "LabelIcon";
            this.LabelIcon.Size = new System.Drawing.Size(29, 16);
            this.LabelIcon.TabIndex = 2;
            this.LabelIcon.Text = "Icon:";
            // 
            // ComboBoxIcons
            // 
            this.ComboBoxIcons.Location = new System.Drawing.Point(78, 54);
            this.ComboBoxIcons.Name = "ComboBoxIcons";
            this.ComboBoxIcons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxIcons.Properties.Items.AddRange(new object[] {
            "Wants You To Play",
            "Wants To Be Your Friend",
            "Envelope Icon",
            "Empty Icon",
            "Sent You A Message",
            "Signed Out",
            "Signed In",
            "Signed In To Xbox Live",
            "Signed In Offline",
            "Wants To Chat",
            "Disconnect From Xbox Live (No Text)",
            "Downloaded",
            "Music Icon",
            "Smiley Icon",
            "Sad Icon",
            "Ban Hammer Icon",
            "Please Reinsert Memory Unit (No Text)",
            "Please Reconnect Controller (No Text)",
            "Has Joined Chat",
            "Has Left Chat",
            "Game Invite Sent (No Text)",
            "Achievement Unlocked",
            "Ready To Play"});
            this.ComboBoxIcons.Size = new System.Drawing.Size(282, 26);
            this.ComboBoxIcons.TabIndex = 3;
            // 
            // ButtonSendNotification
            // 
            this.ButtonSendNotification.Location = new System.Drawing.Point(78, 95);
            this.ButtonSendNotification.Name = "ButtonSendNotification";
            this.ButtonSendNotification.Size = new System.Drawing.Size(282, 29);
            this.ButtonSendNotification.TabIndex = 4;
            this.ButtonSendNotification.Text = "Send XNotification";
            this.ButtonSendNotification.Click += new System.EventHandler(this.ButtonSendNotification_Click);
            // 
            // XNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 136);
            this.Controls.Add(this.ButtonSendNotification);
            this.Controls.Add(this.ComboBoxIcons);
            this.Controls.Add(this.LabelIcon);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TextEditMessage);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "XNotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerberus AIO - XNotification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.XNotificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxIcons.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TextEditMessage;
        private DevExpress.XtraEditors.LabelControl LabelMessage;
        private DevExpress.XtraEditors.LabelControl LabelIcon;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxIcons;
        private DevExpress.XtraEditors.SimpleButton ButtonSendNotification;
    }
}