namespace AnkiToSuperMemoConverter {
    partial class AnkiToSuperMemo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.getFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fileNameText = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderNameDialog = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.destinationFolderButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getFileDialog
            // 
            this.getFileDialog.FileName = "openFileDialog1";
            // 
            // fileNameText
            // 
            this.fileNameText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fileNameText.Location = new System.Drawing.Point(108, 41);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.ReadOnly = true;
            this.fileNameText.Size = new System.Drawing.Size(305, 20);
            this.fileNameText.TabIndex = 0;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileNameLabel.Location = new System.Drawing.Point(18, 42);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(84, 19);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.Text = "File name:";
            // 
            // folderNameDialog
            // 
            this.folderNameDialog.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.folderNameDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.folderNameDialog.Location = new System.Drawing.Point(18, 70);
            this.folderNameDialog.Name = "folderNameDialog";
            this.folderNameDialog.Size = new System.Drawing.Size(84, 19);
            this.folderNameDialog.TabIndex = 3;
            this.folderNameDialog.Text = "Destination folder:";
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pathBox.Location = new System.Drawing.Point(108, 69);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(305, 20);
            this.pathBox.TabIndex = 2;
            // 
            // pickFileButton
            // 
            this.pickFileButton.Location = new System.Drawing.Point(419, 39);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(75, 23);
            this.pickFileButton.TabIndex = 4;
            this.pickFileButton.Text = "Load!";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.pickFileButton_Click);
            // 
            // destinationFolderButton
            // 
            this.destinationFolderButton.Location = new System.Drawing.Point(419, 66);
            this.destinationFolderButton.Name = "destinationFolderButton";
            this.destinationFolderButton.Size = new System.Drawing.Size(75, 23);
            this.destinationFolderButton.TabIndex = 5;
            this.destinationFolderButton.Text = "Choose!";
            this.destinationFolderButton.UseVisualStyleBackColor = true;
            this.destinationFolderButton.Click += new System.EventHandler(this.destinationFolderButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(215, 110);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // AnkiToSuperMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(518, 145);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.destinationFolderButton);
            this.Controls.Add(this.pickFileButton);
            this.Controls.Add(this.folderNameDialog);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileNameText);
            this.Name = "AnkiToSuperMemo";
            this.Text = "Anki to SuperMemo converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog getFileDialog;
        private System.Windows.Forms.TextBox fileNameText;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label folderNameDialog;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.Button destinationFolderButton;
        private System.Windows.Forms.Button generateButton;
    }
}

