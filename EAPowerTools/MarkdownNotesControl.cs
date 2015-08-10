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
        EA.Element element;
        EA.TaggedValue field;

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

        public void LoadFromRepository(EA.Repository repository)
        {
            element = EAHelper.GetCurrentElement(repository);

            if (element != null)
            {
                field = element.TaggedValuesEx.GetByName("Markdown");
                if(field == null)
                {
                    field = element.TaggedValuesEx.AddNew("Markdown", "TaggedValue");
                    field.Value = "<memo>";
                    field.Update();
                }
                
            }

            this.markdownTextBox.Text = field.Notes;
            
        }

        private void markdownTextBox_TextChanged(object sender, EventArgs e)
        {
            this.webBrowser.DocumentText = md.Transform(this.markdownTextBox.Text);
            
        }

        private void toolStripSaveButton_Click(object sender, EventArgs e)
        {
            if(element != null)
            {
                field.Value = "<memo>";
                field.Notes = this.markdownTextBox.Text;
                field.Update();
            }
        }
    }
}
