namespace EAPowerTools
{
    partial class PowerEditorControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerEditorControl));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLIButton = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStripOrderedList = new System.Windows.Forms.ToolStripButton();
            this.toolStripFontBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStringFontButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripBulletList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripRemoveNewlines = new System.Windows.Forms.ToolStripButton();
            this.toolStripBoldButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalicButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveButton,
            this.toolStripSeparator1,
            this.toolStripBulletList,
            this.toolStripOrderedList,
            this.toolStripLIButton,
            this.toolStripSeparator2,
            this.toolStripBoldButton,
            this.toolStripItalicButton,
            this.toolStripUnderline,
            this.toolStripFontBox,
            this.toolStringFontButton,
            this.toolStripSeparator3,
            this.toolStripRemoveNewlines});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveButton.Text = "toolStripSaveButton";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLIButton
            // 
            this.toolStripLIButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLIButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLIButton.Image")));
            this.toolStripLIButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLIButton.Name = "toolStripLIButton";
            this.toolStripLIButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripLIButton.Text = "toolStripButton1";
            this.toolStripLIButton.ToolTipText = "Surround With List Tag";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 575);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(387, 575);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(409, 575);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStripOrderedList
            // 
            this.toolStripOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOrderedList.Image")));
            this.toolStripOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOrderedList.Name = "toolStripOrderedList";
            this.toolStripOrderedList.Size = new System.Drawing.Size(23, 22);
            this.toolStripOrderedList.Text = "toolStripButton1";
            this.toolStripOrderedList.ToolTipText = "Surround With List Tags";
            this.toolStripOrderedList.Click += new System.EventHandler(this.toolStripOrderedList_Click);
            // 
            // toolStripFontBox
            // 
            this.toolStripFontBox.Name = "toolStripFontBox";
            this.toolStripFontBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStringFontButton
            // 
            this.toolStringFontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStringFontButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStringFontButton.Image")));
            this.toolStringFontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStringFontButton.Name = "toolStringFontButton";
            this.toolStringFontButton.Size = new System.Drawing.Size(23, 22);
            this.toolStringFontButton.Text = "toolStripButton1";
            this.toolStringFontButton.ToolTipText = "Surround with font tag";
            this.toolStringFontButton.Click += new System.EventHandler(this.toolStringFontButton_Click);
            // 
            // toolStripBulletList
            // 
            this.toolStripBulletList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBulletList.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBulletList.Image")));
            this.toolStripBulletList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBulletList.Name = "toolStripBulletList";
            this.toolStripBulletList.Size = new System.Drawing.Size(23, 22);
            this.toolStripBulletList.Text = "toolStripButton1";
            this.toolStripBulletList.ToolTipText = "Surround with unordered list";
            this.toolStripBulletList.Click += new System.EventHandler(this.toolStripBulletList_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripRemoveNewlines
            // 
            this.toolStripRemoveNewlines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRemoveNewlines.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRemoveNewlines.Image")));
            this.toolStripRemoveNewlines.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemoveNewlines.Name = "toolStripRemoveNewlines";
            this.toolStripRemoveNewlines.Size = new System.Drawing.Size(23, 22);
            this.toolStripRemoveNewlines.Text = "toolStripButton1";
            this.toolStripRemoveNewlines.ToolTipText = "Strip Newlines From Selection";
            this.toolStripRemoveNewlines.Click += new System.EventHandler(this.toolStripRemoveNewlines_Click);
            // 
            // toolStripBoldButton
            // 
            this.toolStripBoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBoldButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBoldButton.Image")));
            this.toolStripBoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBoldButton.Name = "toolStripBoldButton";
            this.toolStripBoldButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripBoldButton.Text = "toolStripButton1";
            this.toolStripBoldButton.Click += new System.EventHandler(this.toolStripBoldButton_Click);
            // 
            // toolStripItalicButton
            // 
            this.toolStripItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalicButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalicButton.Image")));
            this.toolStripItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalicButton.Name = "toolStripItalicButton";
            this.toolStripItalicButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalicButton.Text = "toolStripButton1";
            this.toolStripItalicButton.Click += new System.EventHandler(this.toolStripItalicButton_Click);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderline.Image")));
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripUnderline.Text = "toolStripButton1";
            this.toolStripUnderline.Click += new System.EventHandler(this.toolStripUnderline_Click);
            // 
            // PowerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PowerEditorControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripLIButton;
        private System.Windows.Forms.ToolStripButton toolStripOrderedList;
        private System.Windows.Forms.ToolStripComboBox toolStripFontBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStringFontButton;
        private System.Windows.Forms.ToolStripButton toolStripBulletList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripRemoveNewlines;
        private System.Windows.Forms.ToolStripButton toolStripBoldButton;
        private System.Windows.Forms.ToolStripButton toolStripItalicButton;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
    }
}
