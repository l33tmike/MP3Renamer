namespace MP3_Renamer
{
    partial class frmMain
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
            this.cmdChooseFiles = new System.Windows.Forms.Button();
            this.lstFilesToRename = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdRenameFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdChooseFiles
            // 
            this.cmdChooseFiles.Location = new System.Drawing.Point(12, 152);
            this.cmdChooseFiles.Name = "cmdChooseFiles";
            this.cmdChooseFiles.Size = new System.Drawing.Size(450, 35);
            this.cmdChooseFiles.TabIndex = 0;
            this.cmdChooseFiles.Text = "Choose Files";
            this.cmdChooseFiles.UseVisualStyleBackColor = true;
            this.cmdChooseFiles.Click += new System.EventHandler(this.cmdChooseFiles_Click);
            // 
            // lstFilesToRename
            // 
            this.lstFilesToRename.FormattingEnabled = true;
            this.lstFilesToRename.Location = new System.Drawing.Point(12, 25);
            this.lstFilesToRename.Name = "lstFilesToRename";
            this.lstFilesToRename.Size = new System.Drawing.Size(450, 121);
            this.lstFilesToRename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Files to rename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Renames files to: {Track Number} - {Title} - {Artist}.mp3";
            // 
            // cmdRenameFiles
            // 
            this.cmdRenameFiles.Location = new System.Drawing.Point(12, 222);
            this.cmdRenameFiles.Name = "cmdRenameFiles";
            this.cmdRenameFiles.Size = new System.Drawing.Size(75, 23);
            this.cmdRenameFiles.TabIndex = 4;
            this.cmdRenameFiles.Text = "Rename";
            this.cmdRenameFiles.UseVisualStyleBackColor = true;
            this.cmdRenameFiles.Click += new System.EventHandler(this.cmdRenameFiles_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 364);
            this.Controls.Add(this.cmdRenameFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFilesToRename);
            this.Controls.Add(this.cmdChooseFiles);
            this.Name = "frmMain";
            this.Text = "MP3 Renamer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdChooseFiles;
        private System.Windows.Forms.ListBox lstFilesToRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdRenameFiles;
    }
}

