namespace ExcelToDbApplication
{
    partial class ExcelToDatabase
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
            this.textSource = new System.Windows.Forms.TextBox();
            this.BtnSource = new System.Windows.Forms.Button();
            this.BtnDestination = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnConvert = new System.Windows.Forms.Button();
            this.progressBarConvert = new System.Windows.Forms.ProgressBar();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSource
            // 
            this.textSource.Location = new System.Drawing.Point(197, 76);
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(374, 22);
            this.textSource.TabIndex = 0;
            // 
            // BtnSource
            // 
            this.BtnSource.Location = new System.Drawing.Point(81, 76);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(105, 23);
            this.BtnSource.TabIndex = 1;
            this.BtnSource.Text = "Source";
            this.BtnSource.UseVisualStyleBackColor = true;
            this.BtnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // BtnDestination
            // 
            this.BtnDestination.Location = new System.Drawing.Point(81, 120);
            this.BtnDestination.Name = "BtnDestination";
            this.BtnDestination.Size = new System.Drawing.Size(105, 23);
            this.BtnDestination.TabIndex = 3;
            this.BtnDestination.Text = "Destination";
            this.BtnDestination.UseVisualStyleBackColor = true;
            this.BtnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(197, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 22);
            this.textBox2.TabIndex = 2;
            // 
            // BtnConvert
            // 
            this.BtnConvert.Location = new System.Drawing.Point(81, 197);
            this.BtnConvert.Name = "BtnConvert";
            this.BtnConvert.Size = new System.Drawing.Size(88, 23);
            this.BtnConvert.TabIndex = 4;
            this.BtnConvert.Text = "Convert";
            this.BtnConvert.UseVisualStyleBackColor = true;
            this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // progressBarConvert
            // 
            this.progressBarConvert.Location = new System.Drawing.Point(81, 250);
            this.progressBarConvert.Name = "progressBarConvert";
            this.progressBarConvert.Size = new System.Drawing.Size(490, 23);
            this.progressBarConvert.TabIndex = 5;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(468, 344);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(98, 30);
            this.BtnLogOut.TabIndex = 6;
            this.BtnLogOut.Text = "Log Out";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuaToolStripMenuItem
            // 
            this.menuaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatabaseToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuaToolStripMenuItem.Name = "menuaToolStripMenuItem";
            this.menuaToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuaToolStripMenuItem.Text = "Menu";
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // ExcelToDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 403);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.progressBarConvert);
            this.Controls.Add(this.BtnConvert);
            this.Controls.Add(this.BtnDestination);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnSource);
            this.Controls.Add(this.textSource);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcelToDatabase";
            this.Text = "Excel to Sql Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSource;
        private System.Windows.Forms.Button BtnSource;
        private System.Windows.Forms.Button BtnDestination;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnConvert;
        private System.Windows.Forms.ProgressBar progressBarConvert;
        private System.Windows.Forms.Button BtnLogOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}