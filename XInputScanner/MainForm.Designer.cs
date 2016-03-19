namespace XInputScanner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonSelectDirectory = new System.Windows.Forms.Button();
            this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectDirectory
            // 
            this.buttonSelectDirectory.Location = new System.Drawing.Point(12, 55);
            this.buttonSelectDirectory.Name = "buttonSelectDirectory";
            this.buttonSelectDirectory.Size = new System.Drawing.Size(162, 23);
            this.buttonSelectDirectory.TabIndex = 0;
            this.buttonSelectDirectory.Text = "Select &Directory";
            this.buttonSelectDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDirectory.Click += new System.EventHandler(this.buttonSelectDirectory_Click);
            // 
            // checkBoxRecursive
            // 
            this.checkBoxRecursive.AutoSize = true;
            this.checkBoxRecursive.Checked = true;
            this.checkBoxRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRecursive.Location = new System.Drawing.Point(180, 59);
            this.checkBoxRecursive.Name = "checkBoxRecursive";
            this.checkBoxRecursive.Size = new System.Drawing.Size(93, 17);
            this.checkBoxRecursive.TabIndex = 1;
            this.checkBoxRecursive.Text = "&Subdirectories";
            this.checkBoxRecursive.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(12, 84);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(261, 165);
            this.textBoxLog.TabIndex = 2;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 27);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(261, 23);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "Select &File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(285, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.sourceCodeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "&License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // sourceCodeToolStripMenuItem
            // 
            this.sourceCodeToolStripMenuItem.Name = "sourceCodeToolStripMenuItem";
            this.sourceCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sourceCodeToolStripMenuItem.Text = "Source &Code";
            this.sourceCodeToolStripMenuItem.Click += new System.EventHandler(this.sourceCodeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 262);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.checkBoxRecursive);
            this.Controls.Add(this.buttonSelectDirectory);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "XInputScanner";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectDirectory;
        private System.Windows.Forms.CheckBox checkBoxRecursive;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

