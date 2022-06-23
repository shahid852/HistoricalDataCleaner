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
            this.lblInputFolderPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOutputFolderPath = new System.Windows.Forms.Label();
            this.chkListOutputFiles = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btcStartCleaning = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSrcFolderBrowse
            // 
            this.btnSrcFolderBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSrcFolderBrowse.Location = new System.Drawing.Point(539, 32);
            this.btnSrcFolderBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSrcFolderBrowse.Name = "btnSrcFolderBrowse";
            this.btnSrcFolderBrowse.Size = new System.Drawing.Size(59, 38);
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
            this.groupBox1.Controls.Add(this.lblInputFolderPath);
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
            // lblInputFolderPath
            // 
            this.lblInputFolderPath.AutoSize = true;
            this.lblInputFolderPath.Location = new System.Drawing.Point(73, 42);
            this.lblInputFolderPath.Name = "lblInputFolderPath";
            this.lblInputFolderPath.Size = new System.Drawing.Size(157, 25);
            this.lblInputFolderPath.TabIndex = 2;
            this.lblInputFolderPath.Text = "No folder selected";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutputFolderPath);
            this.groupBox2.Controls.Add(this.chkListOutputFiles);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btcStartCleaning);
            this.groupBox2.Location = new System.Drawing.Point(623, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 434);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cleaning";
            // 
            // lblOutputFolderPath
            // 
            this.lblOutputFolderPath.AutoSize = true;
            this.lblOutputFolderPath.Location = new System.Drawing.Point(74, 43);
            this.lblOutputFolderPath.Name = "lblOutputFolderPath";
            this.lblOutputFolderPath.Size = new System.Drawing.Size(157, 25);
            this.lblOutputFolderPath.TabIndex = 2;
            this.lblOutputFolderPath.Text = "No folder selected";
            // 
            // chkListOutputFiles
            // 
            this.chkListOutputFiles.FormattingEnabled = true;
            this.chkListOutputFiles.Location = new System.Drawing.Point(6, 70);
            this.chkListOutputFiles.Name = "chkListOutputFiles";
            this.chkListOutputFiles.Size = new System.Drawing.Size(799, 340);
            this.chkListOutputFiles.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder:";
            // 
            // btcStartCleaning
            // 
            this.btcStartCleaning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcStartCleaning.Location = new System.Drawing.Point(655, 32);
            this.btcStartCleaning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btcStartCleaning.Name = "btcStartCleaning";
            this.btcStartCleaning.Size = new System.Drawing.Size(149, 38);
            this.btcStartCleaning.TabIndex = 0;
            this.btcStartCleaning.Text = "Start";
            this.btcStartCleaning.UseVisualStyleBackColor = true;
            this.btcStartCleaning.Click += new System.EventHandler(this.btcStartCleaning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSrcFolderBrowse;
        private FolderBrowserDialog dlgSrcFolder;
        private CheckedListBox chkListInputFiles;
        private GroupBox groupBox1;
        private Label lblInputFolderPath;
        private Label label1;
        private GroupBox groupBox2;
        private CheckedListBox chkListOutputFiles;
        private Button btcStartCleaning;
        private Label lblOutputFolderPath;
        private Label label2;
    }
}