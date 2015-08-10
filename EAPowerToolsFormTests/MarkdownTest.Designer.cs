namespace EAPowerToolsFormTests
{
    partial class MarkdownTest
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
            this.markdownNotesControl1 = new EAPowerTools.MarkdownNotesControl();
            this.SuspendLayout();
            // 
            // markdownNotesControl1
            // 
            this.markdownNotesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markdownNotesControl1.Location = new System.Drawing.Point(0, 0);
            this.markdownNotesControl1.MarkdownText = "";
            this.markdownNotesControl1.Name = "markdownNotesControl1";
            this.markdownNotesControl1.Size = new System.Drawing.Size(858, 619);
            this.markdownNotesControl1.TabIndex = 0;
            // 
            // MarkdownTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 619);
            this.Controls.Add(this.markdownNotesControl1);
            this.Name = "MarkdownTest";
            this.Text = "MarkdownTest";
            this.Load += new System.EventHandler(this.MarkdownTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EAPowerTools.MarkdownNotesControl markdownNotesControl1;
    }
}