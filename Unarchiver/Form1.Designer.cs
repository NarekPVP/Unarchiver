namespace Unarchiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.MainOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCurrentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LocationToUnarchiveButton = new System.Windows.Forms.Button();
            this.ArchiveFileSelection = new System.Windows.Forms.Button();
            this.chooseFileToUnarchiveBox = new System.Windows.Forms.TextBox();
            this.chooseLocationToUnarchiveBox = new System.Windows.Forms.TextBox();
            this.MainProgressBar = new System.Windows.Forms.ProgressBar();
            this.OpenFolderToUnarchive = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Extract";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.extractToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCurrentFileToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeCurrentFileToolStripMenuItem
            // 
            this.changeCurrentFileToolStripMenuItem.Name = "changeCurrentFileToolStripMenuItem";
            this.changeCurrentFileToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.changeCurrentFileToolStripMenuItem.Text = "Change current file";
            // 
            // LocationToUnarchiveButton
            // 
            this.LocationToUnarchiveButton.Location = new System.Drawing.Point(336, 81);
            this.LocationToUnarchiveButton.Name = "LocationToUnarchiveButton";
            this.LocationToUnarchiveButton.Size = new System.Drawing.Size(148, 23);
            this.LocationToUnarchiveButton.TabIndex = 3;
            this.LocationToUnarchiveButton.Text = "LocationToUnarchive";
            this.LocationToUnarchiveButton.UseVisualStyleBackColor = true;
            this.LocationToUnarchiveButton.Click += new System.EventHandler(this.LocationToUnarchiveButton_Click);
            // 
            // ArchiveFileSelection
            // 
            this.ArchiveFileSelection.Location = new System.Drawing.Point(336, 52);
            this.ArchiveFileSelection.Name = "ArchiveFileSelection";
            this.ArchiveFileSelection.Size = new System.Drawing.Size(148, 23);
            this.ArchiveFileSelection.TabIndex = 4;
            this.ArchiveFileSelection.Text = "Choose file to unarchive";
            this.ArchiveFileSelection.UseVisualStyleBackColor = true;
            this.ArchiveFileSelection.Click += new System.EventHandler(this.ArchiveFileSelection_Click);
            // 
            // chooseFileToUnarchiveBox
            // 
            this.chooseFileToUnarchiveBox.Location = new System.Drawing.Point(12, 53);
            this.chooseFileToUnarchiveBox.Name = "chooseFileToUnarchiveBox";
            this.chooseFileToUnarchiveBox.ReadOnly = true;
            this.chooseFileToUnarchiveBox.Size = new System.Drawing.Size(318, 23);
            this.chooseFileToUnarchiveBox.TabIndex = 5;
            // 
            // chooseLocationToUnarchiveBox
            // 
            this.chooseLocationToUnarchiveBox.Location = new System.Drawing.Point(12, 81);
            this.chooseLocationToUnarchiveBox.Name = "chooseLocationToUnarchiveBox";
            this.chooseLocationToUnarchiveBox.ReadOnly = true;
            this.chooseLocationToUnarchiveBox.Size = new System.Drawing.Size(318, 23);
            this.chooseLocationToUnarchiveBox.TabIndex = 6;
            // 
            // MainProgressBar
            // 
            this.MainProgressBar.Location = new System.Drawing.Point(12, 142);
            this.MainProgressBar.Name = "MainProgressBar";
            this.MainProgressBar.Size = new System.Drawing.Size(391, 23);
            this.MainProgressBar.TabIndex = 7;
            // 
            // OpenFolderToUnarchive
            // 
            this.OpenFolderToUnarchive.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 177);
            this.Controls.Add(this.MainProgressBar);
            this.Controls.Add(this.chooseLocationToUnarchiveBox);
            this.Controls.Add(this.chooseFileToUnarchiveBox);
            this.Controls.Add(this.ArchiveFileSelection);
            this.Controls.Add(this.LocationToUnarchiveButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Unarchiver";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private OpenFileDialog MainOpenFileDialog;
        private SaveFileDialog MainSaveFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem extractToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem changeCurrentFileToolStripMenuItem;
        private Button LocationToUnarchiveButton;
        private Button ArchiveFileSelection;
        private TextBox chooseFileToUnarchiveBox;
        private TextBox chooseLocationToUnarchiveBox;
        private ProgressBar MainProgressBar;
        private OpenFileDialog OpenFolderToUnarchive;
    }
}