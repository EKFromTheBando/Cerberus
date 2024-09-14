namespace Cerberus.Cerberus
{
    partial class UserRegstrationForm
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
            this.TextEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.LabelMessage = new DevExpress.XtraEditors.LabelControl();
            this.LabelIcon = new DevExpress.XtraEditors.LabelControl();
            this.ButtonRegisterUser = new DevExpress.XtraEditors.SimpleButton();
            this.TextEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.TextEditConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TextEditUsername
            // 
            this.TextEditUsername.Location = new System.Drawing.Point(12, 25);
            this.TextEditUsername.Name = "TextEditUsername";
            this.TextEditUsername.Size = new System.Drawing.Size(239, 22);
            this.TextEditUsername.TabIndex = 0;
            // 
            // LabelMessage
            // 
            this.LabelMessage.Location = new System.Drawing.Point(12, 3);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(63, 16);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Username:";
            // 
            // LabelIcon
            // 
            this.LabelIcon.Location = new System.Drawing.Point(15, 53);
            this.LabelIcon.Name = "LabelIcon";
            this.LabelIcon.Size = new System.Drawing.Size(60, 16);
            this.LabelIcon.TabIndex = 2;
            this.LabelIcon.Text = "Password:";
            // 
            // ButtonRegisterUser
            // 
            this.ButtonRegisterUser.Location = new System.Drawing.Point(12, 153);
            this.ButtonRegisterUser.Name = "ButtonRegisterUser";
            this.ButtonRegisterUser.Size = new System.Drawing.Size(239, 29);
            this.ButtonRegisterUser.TabIndex = 4;
            this.ButtonRegisterUser.Text = "Register User";
            this.ButtonRegisterUser.Click += new System.EventHandler(this.ButtonRegisterUser_Click);
            // 
            // TextEditPassword
            // 
            this.TextEditPassword.Location = new System.Drawing.Point(12, 75);
            this.TextEditPassword.Name = "TextEditPassword";
            this.TextEditPassword.Properties.PasswordChar = '*';
            this.TextEditPassword.Properties.UseSystemPasswordChar = true;
            this.TextEditPassword.Size = new System.Drawing.Size(239, 22);
            this.TextEditPassword.TabIndex = 5;
            // 
            // TextEditConfirmPassword
            // 
            this.TextEditConfirmPassword.Location = new System.Drawing.Point(12, 125);
            this.TextEditConfirmPassword.Name = "TextEditConfirmPassword";
            this.TextEditConfirmPassword.Properties.PasswordChar = '*';
            this.TextEditConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.TextEditConfirmPassword.Size = new System.Drawing.Size(239, 22);
            this.TextEditConfirmPassword.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.Location = new System.Drawing.Point(12, 103);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(109, 16);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Confirm Password:";
            // 
            // UserRegstrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 195);
            this.Controls.Add(this.TextEditConfirmPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextEditPassword);
            this.Controls.Add(this.ButtonRegisterUser);
            this.Controls.Add(this.LabelIcon);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.TextEditUsername);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "UserRegstrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cerberus AIO - XNotification";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserRegstrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TextEditUsername;
        private DevExpress.XtraEditors.LabelControl LabelMessage;
        private DevExpress.XtraEditors.LabelControl LabelIcon;
        private DevExpress.XtraEditors.SimpleButton ButtonRegisterUser;
        private DevExpress.XtraEditors.TextEdit TextEditPassword;
        private DevExpress.XtraEditors.TextEdit TextEditConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}