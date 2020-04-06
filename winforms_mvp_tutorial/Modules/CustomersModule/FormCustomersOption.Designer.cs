namespace winforms_mvp_tutorial.Modules.CustomersModule
{
    partial class FormCustomersOption
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
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxAddress = new MetroFramework.Controls.MetroTextBox();
            this.tbxTel = new MetroFramework.Controls.MetroTextBox();
            this.tbxName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(23, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 66);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxAddress);
            this.groupBox1.Controls.Add(this.tbxTel);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // tbxAddress
            // 
            // 
            // 
            // 
            this.tbxAddress.CustomButton.Image = null;
            this.tbxAddress.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxAddress.CustomButton.Name = "";
            this.tbxAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxAddress.CustomButton.TabIndex = 1;
            this.tbxAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxAddress.CustomButton.UseSelectable = true;
            this.tbxAddress.CustomButton.Visible = false;
            this.tbxAddress.Lines = new string[0];
            this.tbxAddress.Location = new System.Drawing.Point(148, 135);
            this.tbxAddress.MaxLength = 32767;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.PasswordChar = '\0';
            this.tbxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxAddress.SelectedText = "";
            this.tbxAddress.SelectionLength = 0;
            this.tbxAddress.SelectionStart = 0;
            this.tbxAddress.ShortcutsEnabled = true;
            this.tbxAddress.Size = new System.Drawing.Size(75, 23);
            this.tbxAddress.TabIndex = 1;
            this.tbxAddress.UseSelectable = true;
            this.tbxAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxTel
            // 
            // 
            // 
            // 
            this.tbxTel.CustomButton.Image = null;
            this.tbxTel.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxTel.CustomButton.Name = "";
            this.tbxTel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxTel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxTel.CustomButton.TabIndex = 1;
            this.tbxTel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxTel.CustomButton.UseSelectable = true;
            this.tbxTel.CustomButton.Visible = false;
            this.tbxTel.Lines = new string[0];
            this.tbxTel.Location = new System.Drawing.Point(148, 95);
            this.tbxTel.MaxLength = 32767;
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.PasswordChar = '\0';
            this.tbxTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxTel.SelectedText = "";
            this.tbxTel.SelectionLength = 0;
            this.tbxTel.SelectionStart = 0;
            this.tbxTel.ShortcutsEnabled = true;
            this.tbxTel.Size = new System.Drawing.Size(75, 23);
            this.tbxTel.TabIndex = 1;
            this.tbxTel.UseSelectable = true;
            this.tbxTel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxTel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxName
            // 
            // 
            // 
            // 
            this.tbxName.CustomButton.Image = null;
            this.tbxName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxName.CustomButton.Name = "";
            this.tbxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxName.CustomButton.TabIndex = 1;
            this.tbxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxName.CustomButton.UseSelectable = true;
            this.tbxName.CustomButton.Visible = false;
            this.tbxName.Lines = new string[0];
            this.tbxName.Location = new System.Drawing.Point(148, 45);
            this.tbxName.MaxLength = 32767;
            this.tbxName.Name = "tbxName";
            this.tbxName.PasswordChar = '\0';
            this.tbxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxName.SelectedText = "";
            this.tbxName.SelectionLength = 0;
            this.tbxName.SelectionStart = 0;
            this.tbxName.ShortcutsEnabled = true;
            this.tbxName.Size = new System.Drawing.Size(75, 23);
            this.tbxName.TabIndex = 1;
            this.tbxName.UseSelectable = true;
            this.tbxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Address :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Tel :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(254, 405);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // FormCustomersOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "FormCustomersOption";
            this.Text = "FormCustomersOption";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox tbxTel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbxAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}