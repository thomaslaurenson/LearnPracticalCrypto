namespace RandomSaltGenerator
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
            this.generateSaltButton = new System.Windows.Forms.Button();
            this.saltTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saltLengthComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // generateSaltButton
            // 
            this.generateSaltButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSaltButton.Location = new System.Drawing.Point(12, 46);
            this.generateSaltButton.Name = "generateSaltButton";
            this.generateSaltButton.Size = new System.Drawing.Size(445, 45);
            this.generateSaltButton.TabIndex = 0;
            this.generateSaltButton.Text = "Generate Random Salt";
            this.generateSaltButton.UseVisualStyleBackColor = true;
            this.generateSaltButton.Click += new System.EventHandler(this.generateSaltButton_Click);
            // 
            // saltTextBox
            // 
            this.saltTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saltTextBox.Location = new System.Drawing.Point(12, 97);
            this.saltTextBox.Name = "saltTextBox";
            this.saltTextBox.Size = new System.Drawing.Size(445, 26);
            this.saltTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salt Length:";
            // 
            // saltLengthComboBox
            // 
            this.saltLengthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saltLengthComboBox.FormattingEnabled = true;
            this.saltLengthComboBox.Location = new System.Drawing.Point(113, 12);
            this.saltLengthComboBox.Name = "saltLengthComboBox";
            this.saltLengthComboBox.Size = new System.Drawing.Size(344, 28);
            this.saltLengthComboBox.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 132);
            this.Controls.Add(this.saltLengthComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saltTextBox);
            this.Controls.Add(this.generateSaltButton);
            this.Name = "Main";
            this.Text = "RandomSaltGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateSaltButton;
        private System.Windows.Forms.TextBox saltTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox saltLengthComboBox;
    }
}

