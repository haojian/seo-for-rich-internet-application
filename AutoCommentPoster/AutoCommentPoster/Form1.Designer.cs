namespace AutoCommentPoster
{
    partial class AutoCommentPoster
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
            this.AutoCommentPosterBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // AutoCommentPosterBtn
            // 
            this.AutoCommentPosterBtn.Location = new System.Drawing.Point(26, 26);
            this.AutoCommentPosterBtn.Name = "AutoCommentPosterBtn";
            this.AutoCommentPosterBtn.Size = new System.Drawing.Size(152, 23);
            this.AutoCommentPosterBtn.TabIndex = 0;
            this.AutoCommentPosterBtn.Text = "AutoCommentPoster";
            this.AutoCommentPosterBtn.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(193, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 1;
            // 
            // AutoCommentPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 306);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.AutoCommentPosterBtn);
            this.Name = "AutoCommentPoster";
            this.Text = "AutoCommentPoster";
            this.Load += new System.EventHandler(this.AutoCommentPoster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AutoCommentPosterBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

