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
            TextEditMessage = new DevExpress.XtraEditors.TextEdit();
            LabelMessage = new DevExpress.XtraEditors.LabelControl();
            LabelIcon = new DevExpress.XtraEditors.LabelControl();
            ComboBoxIcons = new DevExpress.XtraEditors.ComboBoxEdit();
            ButtonSendNotification = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(TextEditMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(ComboBoxIcons.Properties)).BeginInit();
            SuspendLayout();
            // 
            // TextEditMessage
            // 
            TextEditMessage.Location = new System.Drawing.Point(78, 12);
            TextEditMessage.Name = "TextEditMessage";
            TextEditMessage.Size = new System.Drawing.Size(282, 26);
            TextEditMessage.TabIndex = 0;
            // 
            // LabelMessage
            // 
            LabelMessage.Location = new System.Drawing.Point(17, 17);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Size = new System.Drawing.Size(55, 16);
            LabelMessage.TabIndex = 1;
            LabelMessage.Text = "Message:";
            // 
            // LabelIcon
            // 
            LabelIcon.Location = new System.Drawing.Point(43, 59);
            LabelIcon.Name = "LabelIcon";
            LabelIcon.Size = new System.Drawing.Size(29, 16);
            LabelIcon.TabIndex = 2;
            LabelIcon.Text = "Icon:";
            // 
            // ComboBoxIcons
            // 
            ComboBoxIcons.Location = new System.Drawing.Point(78, 54);
            ComboBoxIcons.Name = "ComboBoxIcons";
            ComboBoxIcons.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            ComboBoxIcons.Properties.Items.AddRange(new object[] {
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
            ComboBoxIcons.Size = new System.Drawing.Size(282, 26);
            ComboBoxIcons.TabIndex = 3;
            // 
            // ButtonSendNotification
            // 
            ButtonSendNotification.Location = new System.Drawing.Point(78, 95);
            ButtonSendNotification.Name = "ButtonSendNotification";
            ButtonSendNotification.Size = new System.Drawing.Size(282, 29);
            ButtonSendNotification.TabIndex = 4;
            ButtonSendNotification.Text = "Send XNotification";
            ButtonSendNotification.Click += new System.EventHandler(ButtonSendNotification_Click);
            // 
            // XNotificationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(372, 136);
            Controls.Add(ButtonSendNotification);
            Controls.Add(ComboBoxIcons);
            Controls.Add(LabelIcon);
            Controls.Add(LabelMessage);
            Controls.Add(TextEditMessage);
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            Name = "XNotificationForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Cerberus AIO - XNotification";
            TopMost = true;
            Load += new System.EventHandler(XNotificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(TextEditMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(ComboBoxIcons.Properties)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TextEditMessage;
        private DevExpress.XtraEditors.LabelControl LabelMessage;
        private DevExpress.XtraEditors.LabelControl LabelIcon;
        private DevExpress.XtraEditors.ComboBoxEdit ComboBoxIcons;
        private DevExpress.XtraEditors.SimpleButton ButtonSendNotification;
    }
}