namespace winforms_mvp_tutorial.Modules.UsersModule
{
    partial class FormUserProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPwd = new MetroFramework.Controls.MetroTextBox();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbxProfileName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxCreatedAt = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCreatedAt);
            this.groupBox1.Controls.Add(this.tbxPwd);
            this.groupBox1.Controls.Add(this.tbxUsername);
            this.groupBox1.Controls.Add(this.tbxProfileName);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 257);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // tbxPwd
            // 
            // 
            // 
            // 
            this.tbxPwd.CustomButton.Image = null;
            this.tbxPwd.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxPwd.CustomButton.Name = "";
            this.tbxPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPwd.CustomButton.TabIndex = 1;
            this.tbxPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPwd.CustomButton.UseSelectable = true;
            this.tbxPwd.CustomButton.Visible = false;
            this.tbxPwd.Lines = new string[0];
            this.tbxPwd.Location = new System.Drawing.Point(148, 135);
            this.tbxPwd.MaxLength = 32767;
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '\0';
            this.tbxPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPwd.SelectedText = "";
            this.tbxPwd.SelectionLength = 0;
            this.tbxPwd.SelectionStart = 0;
            this.tbxPwd.ShortcutsEnabled = true;
            this.tbxPwd.Size = new System.Drawing.Size(75, 23);
            this.tbxPwd.TabIndex = 1;
            this.tbxPwd.UseSelectable = true;
            this.tbxPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.CustomButton.Image = null;
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxUsername.CustomButton.Name = "";
            this.tbxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUsername.CustomButton.TabIndex = 1;
            this.tbxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUsername.CustomButton.UseSelectable = true;
            this.tbxUsername.CustomButton.Visible = false;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(148, 95);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(75, 23);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.UseSelectable = true;
            this.tbxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxProfileName
            // 
            // 
            // 
            // 
            this.tbxProfileName.CustomButton.Image = null;
            this.tbxProfileName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxProfileName.CustomButton.Name = "";
            this.tbxProfileName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxProfileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxProfileName.CustomButton.TabIndex = 1;
            this.tbxProfileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxProfileName.CustomButton.UseSelectable = true;
            this.tbxProfileName.CustomButton.Visible = false;
            this.tbxProfileName.Lines = new string[0];
            this.tbxProfileName.Location = new System.Drawing.Point(148, 45);
            this.tbxProfileName.MaxLength = 32767;
            this.tbxProfileName.Name = "tbxProfileName";
            this.tbxProfileName.PasswordChar = '\0';
            this.tbxProfileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxProfileName.SelectedText = "";
            this.tbxProfileName.SelectionLength = 0;
            this.tbxProfileName.SelectionStart = 0;
            this.tbxProfileName.ShortcutsEnabled = true;
            this.tbxProfileName.Size = new System.Drawing.Size(75, 23);
            this.tbxProfileName.TabIndex = 1;
            this.tbxProfileName.UseSelectable = true;
            this.tbxProfileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxProfileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Password :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Username :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Profile :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(242, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 188);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Created at :";
            // 
            // tbxCreatedAt
            // 
            // 
            // 
            // 
            this.tbxCreatedAt.CustomButton.Image = null;
            this.tbxCreatedAt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxCreatedAt.CustomButton.Name = "";
            this.tbxCreatedAt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCreatedAt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCreatedAt.CustomButton.TabIndex = 1;
            this.tbxCreatedAt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCreatedAt.CustomButton.UseSelectable = true;
            this.tbxCreatedAt.CustomButton.Visible = false;
            this.tbxCreatedAt.Lines = new string[0];
            this.tbxCreatedAt.Location = new System.Drawing.Point(148, 188);
            this.tbxCreatedAt.MaxLength = 32767;
            this.tbxCreatedAt.Name = "tbxCreatedAt";
            this.tbxCreatedAt.PasswordChar = '\0';
            this.tbxCreatedAt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCreatedAt.SelectedText = "";
            this.tbxCreatedAt.SelectionLength = 0;
            this.tbxCreatedAt.SelectionStart = 0;
            this.tbxCreatedAt.ShortcutsEnabled = true;
            this.tbxCreatedAt.Size = new System.Drawing.Size(75, 23);
            this.tbxCreatedAt.TabIndex = 1;
            this.tbxCreatedAt.UseSelectable = true;
            this.tbxCreatedAt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCreatedAt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "FormUserProfile";
            this.Text = "FormUserProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxCreatedAt;
        private MetroFramework.Controls.MetroTextBox tbxPwd;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroTextBox tbxProfileName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}