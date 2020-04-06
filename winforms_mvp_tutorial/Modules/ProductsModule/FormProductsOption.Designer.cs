namespace winforms_mvp_tutorial.Modules.ProductsModule
{
    partial class FormProductsOption
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
            this.cbxCategories = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tbxPrice = new MetroFramework.Controls.MetroTextBox();
            this.tbxProductName = new MetroFramework.Controls.MetroTextBox();
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
            this.groupBox2.Location = new System.Drawing.Point(32, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 66);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(141, 20);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategories);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.tbxProductName);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 196);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // cbxCategories
            // 
            this.cbxCategories.FormattingEnabled = true;
            this.cbxCategories.ItemHeight = 23;
            this.cbxCategories.Location = new System.Drawing.Point(146, 42);
            this.cbxCategories.Name = "cbxCategories";
            this.cbxCategories.Size = new System.Drawing.Size(121, 29);
            this.cbxCategories.TabIndex = 3;
            this.cbxCategories.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 45);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Category :";
            // 
            // tbxPrice
            // 
            // 
            // 
            // 
            this.tbxPrice.CustomButton.Image = null;
            this.tbxPrice.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxPrice.CustomButton.Name = "";
            this.tbxPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxPrice.CustomButton.TabIndex = 1;
            this.tbxPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxPrice.CustomButton.UseSelectable = true;
            this.tbxPrice.CustomButton.Visible = false;
            this.tbxPrice.Lines = new string[0];
            this.tbxPrice.Location = new System.Drawing.Point(148, 140);
            this.tbxPrice.MaxLength = 32767;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.PasswordChar = '\0';
            this.tbxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxPrice.SelectedText = "";
            this.tbxPrice.SelectionLength = 0;
            this.tbxPrice.SelectionStart = 0;
            this.tbxPrice.ShortcutsEnabled = true;
            this.tbxPrice.Size = new System.Drawing.Size(75, 23);
            this.tbxPrice.TabIndex = 1;
            this.tbxPrice.UseSelectable = true;
            this.tbxPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbxProductName
            // 
            // 
            // 
            // 
            this.tbxProductName.CustomButton.Image = null;
            this.tbxProductName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tbxProductName.CustomButton.Name = "";
            this.tbxProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbxProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbxProductName.CustomButton.TabIndex = 1;
            this.tbxProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbxProductName.CustomButton.UseSelectable = true;
            this.tbxProductName.CustomButton.Visible = false;
            this.tbxProductName.Lines = new string[0];
            this.tbxProductName.Location = new System.Drawing.Point(148, 90);
            this.tbxProductName.MaxLength = 32767;
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.PasswordChar = '\0';
            this.tbxProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxProductName.SelectedText = "";
            this.tbxProductName.SelectionLength = 0;
            this.tbxProductName.SelectionStart = 0;
            this.tbxProductName.ShortcutsEnabled = true;
            this.tbxProductName.Size = new System.Drawing.Size(75, 23);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.UseSelectable = true;
            this.tbxProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbxProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 140);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Price :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 90);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product name :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(266, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            // 
            // FormProductsOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Name = "FormProductsOption";
            this.Text = "FormProductsOption";
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
        private MetroFramework.Controls.MetroComboBox cbxCategories;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tbxPrice;
        private MetroFramework.Controls.MetroTextBox tbxProductName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}