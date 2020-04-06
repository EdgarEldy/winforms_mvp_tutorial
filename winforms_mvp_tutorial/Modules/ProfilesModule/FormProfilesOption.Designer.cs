namespace winforms_mvp_tutorial.Modules.ProfilesModule
{
    partial class FormProfilesOption
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxProfileName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroButton3);
            this.groupBox2.Controls.Add(this.metroButton2);
            this.groupBox2.Location = new System.Drawing.Point(23, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(127, 20);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 0;
            this.metroButton3.Text = "Reset";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(19, 20);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "Save";
            this.metroButton2.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxProfileName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Profile name :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // FormProfilesOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "FormProfilesOption";
            this.Text = "FormProfilesOption";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxProfileName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}