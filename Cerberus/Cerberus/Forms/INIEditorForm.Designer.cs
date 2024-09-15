namespace Cerberus.Cerberus.Forms
{
    partial class INIEditorForm
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
            this.MemoEditINI = new DevExpress.XtraEditors.MemoEdit();
            this.ButtonPullLaunch = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonPullOther = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDiscardChanges = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.MemoEditINI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MemoEditINI
            // 
            this.MemoEditINI.Location = new System.Drawing.Point(12, 12);
            this.MemoEditINI.Name = "MemoEditINI";
            this.MemoEditINI.Size = new System.Drawing.Size(486, 462);
            this.MemoEditINI.TabIndex = 0;
            // 
            // ButtonPullLaunch
            // 
            this.ButtonPullLaunch.Location = new System.Drawing.Point(12, 480);
            this.ButtonPullLaunch.Name = "ButtonPullLaunch";
            this.ButtonPullLaunch.Size = new System.Drawing.Size(486, 29);
            this.ButtonPullLaunch.TabIndex = 1;
            this.ButtonPullLaunch.Text = "Pull Launch.INI from Console";
            this.ButtonPullLaunch.Click += new System.EventHandler(this.ButtonPullLaunch_Click);
            // 
            // ButtonPullOther
            // 
            this.ButtonPullOther.Location = new System.Drawing.Point(12, 515);
            this.ButtonPullOther.Name = "ButtonPullOther";
            this.ButtonPullOther.Size = new System.Drawing.Size(486, 29);
            this.ButtonPullOther.TabIndex = 2;
            this.ButtonPullOther.Text = "Pull Other INI from Console";
            this.ButtonPullOther.Click += new System.EventHandler(this.ButtonPullOther_Click);
            // 
            // ButtonDiscardChanges
            // 
            this.ButtonDiscardChanges.Location = new System.Drawing.Point(12, 622);
            this.ButtonDiscardChanges.Name = "ButtonDiscardChanges";
            this.ButtonDiscardChanges.Size = new System.Drawing.Size(486, 29);
            this.ButtonDiscardChanges.TabIndex = 4;
            this.ButtonDiscardChanges.Text = "Discard Changes and Delete";
            this.ButtonDiscardChanges.Click += new System.EventHandler(this.ButtonDiscardChanges_Click);
            // 
            // ButtonSaveChanges
            // 
            this.ButtonSaveChanges.Location = new System.Drawing.Point(12, 587);
            this.ButtonSaveChanges.Name = "ButtonSaveChanges";
            this.ButtonSaveChanges.Size = new System.Drawing.Size(486, 29);
            this.ButtonSaveChanges.TabIndex = 3;
            this.ButtonSaveChanges.Text = "Save Changes";
            this.ButtonSaveChanges.Click += new System.EventHandler(this.ButtonSaveChanges_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 553);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(486, 23);
            this.separatorControl1.TabIndex = 5;
            // 
            // INIEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 663);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.ButtonDiscardChanges);
            this.Controls.Add(this.ButtonSaveChanges);
            this.Controls.Add(this.ButtonPullOther);
            this.Controls.Add(this.ButtonPullLaunch);
            this.Controls.Add(this.MemoEditINI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.Name = "INIEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerberus AIO - INI Editor";
            this.Load += new System.EventHandler(this.INIEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MemoEditINI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit MemoEditINI;
        private DevExpress.XtraEditors.SimpleButton ButtonPullLaunch;
        private DevExpress.XtraEditors.SimpleButton ButtonPullOther;
        private DevExpress.XtraEditors.SimpleButton ButtonDiscardChanges;
        private DevExpress.XtraEditors.SimpleButton ButtonSaveChanges;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}