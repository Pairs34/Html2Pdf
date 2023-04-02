namespace Html2Pdf
{
    partial class frmMain
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
            btnSelectFolder = new Button();
            txtFolderPath = new TextBox();
            progressConvert = new ProgressBar();
            folderBrowser = new FolderBrowserDialog();
            saveFileDialog = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            stepText = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(713, 12);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(75, 23);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Aç";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(12, 12);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(695, 23);
            txtFolderPath.TabIndex = 1;
            // 
            // progressConvert
            // 
            progressConvert.Location = new Point(12, 41);
            progressConvert.Name = "progressConvert";
            progressConvert.Size = new Size(776, 23);
            progressConvert.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stepText });
            statusStrip1.Location = new Point(0, 73);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // stepText
            // 
            stepText.Name = "stepText";
            stepText.Size = new Size(24, 17);
            stepText.Text = "0/0";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 95);
            Controls.Add(statusStrip1);
            Controls.Add(progressConvert);
            Controls.Add(txtFolderPath);
            Controls.Add(btnSelectFolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Html 2 Pdf";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFolder;
        private TextBox txtFolderPath;
        private ProgressBar progressConvert;
        private FolderBrowserDialog folderBrowser;
        private SaveFileDialog saveFileDialog;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stepText;
    }
}