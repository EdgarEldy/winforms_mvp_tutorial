namespace winforms_mvp_tutorial
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.userAccessToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "Menu";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.productToolStripMenuItem,
            this.productToolStripMenuItem1});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productToolStripMenuItem.Text = "Order";
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.productToolStripMenuItem1.Text = "Product";
            // 
            // userAccessToolStripMenuItem
            // 
            this.userAccessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfUsersToolStripMenuItem,
            this.userProfilesToolStripMenuItem});
            this.userAccessToolStripMenuItem.Name = "userAccessToolStripMenuItem";
            this.userAccessToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userAccessToolStripMenuItem.Text = "User access";
            // 
            // listOfUsersToolStripMenuItem
            // 
            this.listOfUsersToolStripMenuItem.Name = "listOfUsersToolStripMenuItem";
            this.listOfUsersToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.listOfUsersToolStripMenuItem.Text = "List of users";
            // 
            // userProfilesToolStripMenuItem
            // 
            this.userProfilesToolStripMenuItem.Name = "userProfilesToolStripMenuItem";
            this.userProfilesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.userProfilesToolStripMenuItem.Text = "User Profiles";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCustomersToolStripMenuItem,
            this.listOfProductsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // listOfCustomersToolStripMenuItem
            // 
            this.listOfCustomersToolStripMenuItem.Name = "listOfCustomersToolStripMenuItem";
            this.listOfCustomersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfCustomersToolStripMenuItem.Text = "List of customers";
            this.listOfCustomersToolStripMenuItem.Click += new System.EventHandler(this.listOfCustomersToolStripMenuItem_Click);
            // 
            // listOfProductsToolStripMenuItem
            // 
            this.listOfProductsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfCategoriesToolStripMenuItem});
            this.listOfProductsToolStripMenuItem.Name = "listOfProductsToolStripMenuItem";
            this.listOfProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfProductsToolStripMenuItem.Text = "List of products";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // listOfCategoriesToolStripMenuItem
            // 
            this.listOfCategoriesToolStripMenuItem.Name = "listOfCategoriesToolStripMenuItem";
            this.listOfCategoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfCategoriesToolStripMenuItem.Text = "List of categories";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 550);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfCategoriesToolStripMenuItem;
    }
}