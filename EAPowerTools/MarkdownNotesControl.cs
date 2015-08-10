using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarkdownSharp;

namespace EAPowerTools
{
    public partial class MarkdownNotesControl : UserControl
    {
        Markdown md;

        public string MarkdownText
        {
            set
            {
                this.markdownTextBox.Text = value;
            }
            get
            {
                return this.markdownTextBox.Text;
            }
        }

        public MarkdownNotesControl()
        {
            InitializeComponent();
            md = new Markdown();
        }

        private void markdownTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webBrowser.DocumentText = md.Transform(this.markdownTextBox.Text);
        }
    }
}
