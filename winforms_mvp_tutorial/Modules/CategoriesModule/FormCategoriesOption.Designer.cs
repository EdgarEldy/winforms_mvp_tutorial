namespace winforms_mvp_tutorial.Modules.CategoriesModule
{
    partial class FormCategoriesOption
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
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxCatName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 307);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxCatName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // tbxCatName
            // 
            // 
            // 
            // 
            this.tbxCatName.CustomButton.Image = null;
            this.tbxCatName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxCatName.CustomButton.Name = "";
            this.tbxCatName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxCatName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxCatName.CustomButton.TabIndex = 1;
            this.tbxCatName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxCatName.CustomButton.UseSelectable = true;
            this.tbxCatName.CustomButton.Visible = false;
            this.tbxCatName.Lines = new string[0];
            this.tbxCatName.Location = new System.Drawing.Point(148, 45);
            this.tbxCatName.MaxLength = 32767;
            this.tbxCatName.Name = "tbxCatName";
            this.tbxCatName.PasswordChar = '\0';
            this.tbxCatName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxCatName.SelectedText = "";
            this.tbxCatName.SelectionLength = 0;
            this.tbxCatName.SelectionStart = 0;
            this.tbxCatName.ShortcutsEnabled = true;
            this.tbxCatName.Size = new System.Drawing.Size(75, 23);
            this.tbxCatName.TabIndex = 1;
            this.tbxCatName.UseSelectable = true;
            this.tbxCatName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxCatName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Category name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(23, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 66);
            this.groupBox2.TabIndex = 2;
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
            // FormCategoriesOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "FormCategoriesOption";
            this.Text = "FormCategoriesOption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox tbxCatName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnReset;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}