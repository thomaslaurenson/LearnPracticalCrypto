namespace StringHasher
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
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.generateHashButton = new System.Windows.Forms.Button();
            this.hashedPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hashAlgorithmSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hash Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "String/Password:";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(145, 46);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(495, 26);
            this.passwordBox.TabIndex = 3;
            // 
            // generateHashButton
            // 
            this.generateHashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateHashButton.Location = new System.Drawing.Point(145, 82);
            this.generateHashButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateHashButton.Name = "generateHashButton";
            this.generateHashButton.Size = new System.Drawing.Size(495, 35);
            this.generateHashButton.TabIndex = 4;
            this.generateHashButton.Text = "Generate Hash Value";
            this.generateHashButton.UseVisualStyleBackColor = true;
            this.generateHashButton.Enter += new System.EventHandler(this.generateHashButton_Click);
            // 
            // hashedPasswordBox
            // 
            this.hashedPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashedPasswordBox.Location = new System.Drawing.Point(145, 127);
            this.hashedPasswordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hashedPasswordBox.Name = "hashedPasswordBox";
            this.hashedPasswordBox.Size = new System.Drawing.Size(495, 26);
            this.hashedPasswordBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash Value:";
            // 
            // hashAlgorithmSelection
            // 
            this.hashAlgorithmSelection.FormattingEnabled = true;
            this.hashAlgorithmSelection.Location = new System.Drawing.Point(145, 10);
            this.hashAlgorithmSelection.Name = "hashAlgorithmSelection";
            this.hashAlgorithmSelection.Size = new System.Drawing.Size(495, 28);
            this.hashAlgorithmSelection.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 166);
            this.Controls.Add(this.hashAlgorithmSelection);
            this.Controls.Add(this.hashedPasswordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generateHashButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "StringHasher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button generateHashButton;
        private System.Windows.Forms.TextBox hashedPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hashAlgorithmSelection;
    }
}

