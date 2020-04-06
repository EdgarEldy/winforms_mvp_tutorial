namespace winforms_mvp_tutorial.Modules.UsersModule
{
    partial class FormLogin
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbxUsername = new MetroFramework.Controls.MetroTextBox();
            this.btnEnter = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbxPwd = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username :";
            // 
            // tbxUsername
            // 
            // 
            // 
            // 
            this.tbxUsername.CustomButton.Image = null;
            this.tbxUsername.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.tbxUsername.CustomButton.Name = "";
            this.tbxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxUsername.CustomButton.TabIndex = 1;
            this.tbxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxUsername.CustomButton.UseSelectable = true;
            this.tbxUsername.CustomButton.Visible = false;
            this.tbxUsername.Lines = new string[0];
            this.tbxUsername.Location = new System.Drawing.Point(131, 93);
            this.tbxUsername.MaxLength = 32767;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.PasswordChar = '\0';
            this.tbxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxUsername.SelectedText = "";
            this.tbxUsername.SelectionLength = 0;
            this.tbxUsername.SelectionStart = 0;
            this.tbxUsername.ShortcutsEnabled = true;
            this.tbxUsername.Size = new System.Drawing.Size(158, 23);
            this.tbxUsername.TabIndex = 1;
            this.tbxUsername.UseSelectable = true;
            this.tbxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(50, 191);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseSelectable = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(143, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Password :";
            // 
            // tbxPwd
            // 
            // 
            // 
            // 
            this.tbxPwd.CustomButton.Image = null;
            this.tbxPwd.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.tbxPwd.CustomButton.Name = "";
            this.tbxPwd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPwd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPwd.CustomButton.TabIndex = 1;
            this.tbxPwd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPwd.CustomButton.UseSelectable = true;
            this.tbxPwd.CustomButton.Visible = false;
            this.tbxPwd.Lines = new string[0];
            this.tbxPwd.Location = new System.Drawing.Point(131, 137);
            this.tbxPwd.MaxLength = 32767;
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '\0';
            this.tbxPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPwd.SelectedText = "";
            this.tbxPwd.SelectionLength = 0;
            this.tbxPwd.SelectionStart = 0;
            this.tbxPwd.ShortcutsEnabled = true;
            this.tbxPwd.Size = new System.Drawing.Size(158, 23);
            this.tbxPwd.TabIndex = 2;
            this.tbxPwd.UseSelectable = true;
            this.tbxPwd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPwd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 261);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbxUsername;
        private MetroFramework.Controls.MetroButton btnEnter;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxPwd;
    }
}