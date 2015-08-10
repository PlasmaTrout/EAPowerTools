namespace EAPowerTools
{
    partial class MarkdownNotesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkdownNotesControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.markdownTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPreviewButton = new System.Windows.Forms.ToolStripButton();
            this.previewTab = new System.Windows.Forms.TabControl();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.previewTab.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.tabPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripSeparator1,
            this.toolStripPreviewButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // markdownTextBox
            // 
            this.markdownTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markdownTextBox.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markdownTextBox.Location = new System.Drawing.Point(3, 3);
            this.markdownTextBox.Name = "markdownTextBox";
            this.markdownTextBox.Size = new System.Drawing.Size(786, 543);
            this.markdownTextBox.TabIndex = 1;
            this.markdownTextBox.Text = resources.GetString("markdownTextBox.Text");
            this.markdownTextBox.TextChanged += new System.EventHandler(this.markdownTextBox_TextChanged);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveButton.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripPreviewButton
            // 
            this.toolStripPreviewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPreviewButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPreviewButton.Image")));
            this.toolStripPreviewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPreviewButton.Name = "toolStripPreviewButton";
            this.toolStripPreviewButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripPreviewButton.Text = "toolStripButton1";
            // 
            // previewTab
            // 
            this.previewTab.Controls.Add(this.tabEditor);
            this.previewTab.Controls.Add(this.tabPreview);
            this.previewTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewTab.Location = new System.Drawing.Point(0, 25);
            this.previewTab.Name = "previewTab";
            this.previewTab.SelectedIndex = 0;
            this.previewTab.Size = new System.Drawing.Size(800, 575);
            this.previewTab.TabIndex = 2;
            this.previewTab.SelectedIndexChanged += new System.EventHandler(this.markdownTextBox_TextChanged);
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.markdownTextBox);
            this.tabEditor.Location = new System.Drawing.Point(4, 22);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditor.Size = new System.Drawing.Size(792, 549);
            this.tabEditor.TabIndex = 0;
            this.tabEditor.Text = "Editor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.webBrowser);
            this.tabPreview.Location = new System.Drawing.Point(4, 22);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreview.Size = new System.Drawing.Size(792, 549);
            this.tabPreview.TabIndex = 1;
            this.tabPreview.Text = "Preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(786, 543);
            this.webBrowser.TabIndex = 0;
            // 
            // MarkdownNotesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previewTab);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MarkdownNotesControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.previewTab.ResumeLayout(false);
            this.tabEditor.ResumeLayout(false);
            this.tabPreview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.RichTextBox markdownTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPreviewButton;
        private System.Windows.Forms.TabControl previewTab;
        private System.Windows.Forms.TabPage tabEditor;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
