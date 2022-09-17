namespace Week6
{
    partial class FormMain
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
            this.StripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.StripManage = new System.Windows.Forms.ToolStripMenuItem();
            this.FileCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.FileAdministrator = new System.Windows.Forms.ToolStripMenuItem();
            this.FileModel = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMerchandise = new System.Windows.Forms.ToolStripMenuItem();
            this.StripTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripFile,
            this.StripManage,
            this.StripTransaction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // StripFile
            // 
            this.StripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileLogout,
            this.FileExit});
            this.StripFile.Name = "StripFile";
            this.StripFile.Size = new System.Drawing.Size(37, 20);
            this.StripFile.Text = "File";
            // 
            // FileLogout
            // 
            this.FileLogout.Name = "FileLogout";
            this.FileLogout.Size = new System.Drawing.Size(180, 22);
            this.FileLogout.Text = "Logout";
            this.FileLogout.Click += new System.EventHandler(this.FileLogout_Click);
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(180, 22);
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // StripManage
            // 
            this.StripManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileCustomer,
            this.FileAdministrator,
            this.FileModel,
            this.FileMerchandise});
            this.StripManage.Name = "StripManage";
            this.StripManage.Size = new System.Drawing.Size(62, 20);
            this.StripManage.Text = "Manage";
            // 
            // FileCustomer
            // 
            this.FileCustomer.Name = "FileCustomer";
            this.FileCustomer.Size = new System.Drawing.Size(180, 22);
            this.FileCustomer.Text = "Customer";
            this.FileCustomer.Click += new System.EventHandler(this.FileCustomer_Click);
            // 
            // FileAdministrator
            // 
            this.FileAdministrator.Name = "FileAdministrator";
            this.FileAdministrator.Size = new System.Drawing.Size(180, 22);
            this.FileAdministrator.Text = "Administrator";
            this.FileAdministrator.Click += new System.EventHandler(this.FileAdministrator_Click);
            // 
            // FileModel
            // 
            this.FileModel.Name = "FileModel";
            this.FileModel.Size = new System.Drawing.Size(180, 22);
            this.FileModel.Text = "Model";
            this.FileModel.Click += new System.EventHandler(this.FileModel_Click);
            // 
            // FileMerchandise
            // 
            this.FileMerchandise.Name = "FileMerchandise";
            this.FileMerchandise.Size = new System.Drawing.Size(180, 22);
            this.FileMerchandise.Text = "Merchandise";
            this.FileMerchandise.Click += new System.EventHandler(this.FileMerchandise_Click);
            // 
            // StripTransaction
            // 
            this.StripTransaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSales});
            this.StripTransaction.Name = "StripTransaction";
            this.StripTransaction.Size = new System.Drawing.Size(79, 20);
            this.StripTransaction.Text = "Transaction";
            // 
            // FileSales
            // 
            this.FileSales.Name = "FileSales";
            this.FileSales.Size = new System.Drawing.Size(180, 22);
            this.FileSales.Text = "Sales";
            this.FileSales.Click += new System.EventHandler(this.FileSales_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 371);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StripFile;
        private System.Windows.Forms.ToolStripMenuItem FileLogout;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem StripManage;
        private System.Windows.Forms.ToolStripMenuItem FileCustomer;
        private System.Windows.Forms.ToolStripMenuItem FileAdministrator;
        private System.Windows.Forms.ToolStripMenuItem FileModel;
        private System.Windows.Forms.ToolStripMenuItem FileMerchandise;
        private System.Windows.Forms.ToolStripMenuItem StripTransaction;
        private System.Windows.Forms.ToolStripMenuItem FileSales;
    }
}