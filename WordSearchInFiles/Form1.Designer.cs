namespace WordSearchInFiles
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstFilesFound = new System.Windows.Forms.ListBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lstFilesNotFound = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search For";
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(105, 29);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(494, 20);
            this.txtSearchWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search In";
            // 
            // txtSearchFolder
            // 
            this.txtSearchFolder.Location = new System.Drawing.Point(105, 76);
            this.txtSearchFolder.Name = "txtSearchFolder";
            this.txtSearchFolder.Size = new System.Drawing.Size(494, 20);
            this.txtSearchFolder.TabIndex = 3;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(610, 75);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(85, 20);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "Browse...";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(106, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 26);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstFilesFound
            // 
            this.lstFilesFound.FormattingEnabled = true;
            this.lstFilesFound.HorizontalScrollbar = true;
            this.lstFilesFound.Location = new System.Drawing.Point(41, 166);
            this.lstFilesFound.Name = "lstFilesFound";
            this.lstFilesFound.Size = new System.Drawing.Size(558, 537);
            this.lstFilesFound.TabIndex = 6;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(233, 126);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 7;
            // 
            // lstFilesNotFound
            // 
            this.lstFilesNotFound.FormattingEnabled = true;
            this.lstFilesNotFound.HorizontalScrollbar = true;
            this.lstFilesNotFound.Location = new System.Drawing.Point(626, 166);
            this.lstFilesNotFound.Name = "lstFilesNotFound";
            this.lstFilesNotFound.Size = new System.Drawing.Size(279, 537);
            this.lstFilesNotFound.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(492, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save Search";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 729);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstFilesNotFound);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lstFilesFound);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtSearchFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchWord);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Word Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstFilesFound;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.ListBox lstFilesNotFound;
        private System.Windows.Forms.Button btnSave;
    }
}

