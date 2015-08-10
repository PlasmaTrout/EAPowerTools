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

            this.toolstripStyleBox.Items.Add(new MarkdownStyle("Bootstrap 3", "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css"));
            this.toolstripStyleBox.Items.Add(new MarkdownStyle("Marx", "https://cdnjs.cloudflare.com/ajax/libs/marx/1.3.0/marx.min.css"));
            this.toolstripStyleBox.SelectedIndex = 0;
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
            UpdateWebBrowser();
        }

        private void markdownTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateWebBrowser();

        }

        public void UpdateWebBrowser()
        {
            string styleLink = String.Format("<link rel=\"stylesheet\" href=\"{0}\">", ((MarkdownStyle)this.toolstripStyleBox.SelectedItem).CSSLink);
            this.webBrowser.DocumentText =
                String.Format(Properties.Resources.HTMLHeader, styleLink, md.Transform(this.markdownTextBox.Text));
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

        private void toolstripStyleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWebBrowser();
        }

        private void MarkdownNotesControl_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            UpdateWebBrowser();
        }
    }
}
