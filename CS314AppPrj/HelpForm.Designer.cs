namespace CS314AppPrj
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.helpLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.instructionsTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.helpLabel.ForeColor = System.Drawing.Color.Black;
            this.helpLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.helpLabel.Location = new System.Drawing.Point(306, 9);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(276, 52);
            this.helpLabel.TabIndex = 1;
            this.helpLabel.Text = "How-To-Play";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // instructionsTextbox
            // 
            this.instructionsTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.instructionsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTextbox.Location = new System.Drawing.Point(12, 112);
            this.instructionsTextbox.Multiline = true;
            this.instructionsTextbox.Name = "instructionsTextbox";
            this.instructionsTextbox.Size = new System.Drawing.Size(854, 379);
            this.instructionsTextbox.TabIndex = 2;
            this.instructionsTextbox.Text = resources.GetString("instructionsTextbox.Text");
            this.instructionsTextbox.TextChanged += new System.EventHandler(this.instructionsTextbox_TextChanged);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 494);
            this.Controls.Add(this.instructionsTextbox);
            this.Controls.Add(this.helpLabel);
            this.MaximumSize = new System.Drawing.Size(900, 690);
            this.Name = "HelpForm";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox instructionsTextbox;
    }
}