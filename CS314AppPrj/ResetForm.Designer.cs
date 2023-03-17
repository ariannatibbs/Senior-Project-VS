namespace CS314AppPrj
{
    partial class ResetForm
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.resetQuestionLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // resetQuestionLabel
            // 
            this.resetQuestionLabel.AutoSize = true;
            this.resetQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resetQuestionLabel.Location = new System.Drawing.Point(100, 29);
            this.resetQuestionLabel.Name = "resetQuestionLabel";
            this.resetQuestionLabel.Size = new System.Drawing.Size(330, 29);
            this.resetQuestionLabel.TabIndex = 0;
            this.resetQuestionLabel.Text = "Are you sure you want to quit?";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(105, 115);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(90, 45);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            ResetForm resetForm = this;
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(340, 115);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(90, 45);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click_1);
            // 
            // ResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 253);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.resetQuestionLabel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label resetQuestionLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}