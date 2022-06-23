namespace HistoricalDataCleaner
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
            this.btnSrcFolderBrowse = new System.Windows.Forms.Button();
            this.dlgSrcFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.chkListInputFiles = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSrcFolderBrowse
            // 
            this.btnSrcFolderBrowse.Location = new System.Drawing.Point(489, 32);
            this.btnSrcFolderBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrcFolderBrowse.Name = "btnSrcFolderBrowse";
            this.btnSrcFolderBrowse.Size = new System.Drawing.Size(109, 38);
            this.btnSrcFolderBrowse.TabIndex = 0;
            this.btnSrcFolderBrowse.Text = "...";
            this.btnSrcFolderBrowse.UseVisualStyleBackColor = true;
            this.btnSrcFolderBrowse.Click += new System.EventHandler(this.btnSrcFolderBrowse_Click);
            // 
            // dlgSrcFolder
            // 
            this.dlgSrcFolder.RootFolder = System.Environment.SpecialFolder.Recent;
            // 
            // chkListInputFiles
            // 
            this.chkListInputFiles.FormattingEnabled = true;
            this.chkListInputFiles.Location = new System.Drawing.Point(6, 70);
            this.chkListInputFiles.Name = "chkListInputFiles";
            this.chkListInputFiles.Size = new System.Drawing.Size(593, 340);
            this.chkListInputFiles.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFolderPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkListInputFiles);
            this.groupBox1.Controls.Add(this.btnSrcFolderBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(73, 42);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(157, 25);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "No folder selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1657, 714);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSrcFolderBrowse;
        private FolderBrowserDialog dlgSrcFolder;
        private CheckedListBox chkListInputFiles;
        private GroupBox groupBox1;
        private Label lblFolderPath;
        private Label label1;
    }
}