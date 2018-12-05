namespace FileHasher
{
    partial class Main
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
            this.hashAlgorithmSelection = new System.Windows.Forms.ComboBox();
            this.targetFileBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.hashValueBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.generateHashValueButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hash Algorithm:";
            // 
            // hashAlgorithmSelection
            // 
            this.hashAlgorithmSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashAlgorithmSelection.FormattingEnabled = true;
            this.hashAlgorithmSelection.Location = new System.Drawing.Point(166, 6);
            this.hashAlgorithmSelection.Name = "hashAlgorithmSelection";
            this.hashAlgorithmSelection.Size = new System.Drawing.Size(512, 28);
            this.hashAlgorithmSelection.TabIndex = 1;
            // 
            // targetFileBox
            // 
            this.targetFileBox.AllowDrop = true;
            this.targetFileBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetFileBox.Location = new System.Drawing.Point(166, 40);
            this.targetFileBox.Name = "targetFileBox";
            this.targetFileBox.Size = new System.Drawing.Size(389, 26);
            this.targetFileBox.TabIndex = 5;
            this.targetFileBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.TargetFileBox_DragDrop);
            this.targetFileBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.TargetFileBox_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Target File:";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(561, 40);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(117, 26);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // hashValueBox
            // 
            this.hashValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashValueBox.Location = new System.Drawing.Point(166, 104);
            this.hashValueBox.Name = "hashValueBox";
            this.hashValueBox.Size = new System.Drawing.Size(512, 26);
            this.hashValueBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hash Value:";
            // 
            // generateHashValueButton
            // 
            this.generateHashValueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateHashValueButton.Location = new System.Drawing.Point(166, 72);
            this.generateHashValueButton.Name = "generateHashValueButton";
            this.generateHashValueButton.Size = new System.Drawing.Size(512, 26);
            this.generateHashValueButton.TabIndex = 9;
            this.generateHashValueButton.Text = "Generate Hash Value";
            this.generateHashValueButton.UseVisualStyleBackColor = true;
            this.generateHashValueButton.Click += new System.EventHandler(this.GenerateHashValueButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 138);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(662, 23);
            this.progressBar.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 173);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.generateHashValueButton);
            this.Controls.Add(this.hashValueBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.targetFileBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashAlgorithmSelection);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "SimpleFileHasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hashAlgorithmSelection;
        private System.Windows.Forms.TextBox targetFileBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox hashValueBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateHashValueButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

