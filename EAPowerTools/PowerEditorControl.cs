using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace EAPowerTools
{
    public partial class PowerEditorControl : UserControl
    {

        private EA.Element currentElement;
        private InstalledFontCollection collection;

        public PowerEditorControl()
        {
            InitializeComponent();

            this.richTextBox1.TextChanged += RichTextBox1_TextChanged;
            this.toolStripSaveButton.Click += ToolStripSaveButton_Click;
            this.toolStripLIButton.Click += ToolStripLIButton_Click;
            collection = new InstalledFontCollection();
            this.toolStripFontBox.ComboBox.DisplayMember = "Name";
            this.toolStripFontBox.Items.AddRange(collection.Families);
        }

      

        private void ToolStripSaveButton_Click(object sender, EventArgs e)
        {
            if(currentElement != null)
            {
                currentElement.Notes = this.richTextBox1.Text;
                currentElement.Update();
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = this.richTextBox1.Text;
        }

        public void LoadNotes(EA.Repository repo)
        {
            if (repo != null)
            {
                currentElement = repo.GetTreeSelectedObject();
                this.richTextBox1.Text = currentElement.Notes;
            }
        }

        private void toolStripOrderedList_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "<ol>" + System.Environment.NewLine +
               this.richTextBox1.SelectedText + System.Environment.NewLine + "</ol>";
        }

        private void ToolStripLIButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = System.Environment.NewLine + "<li>" +
                this.richTextBox1.SelectedText + "</li>" + System.Environment.NewLine;
        }

        private void toolStringFontButton_Click(object sender, EventArgs e)
        {
            String font = this.toolStripFontBox.SelectedText;
            if (!string.IsNullOrEmpty(font))
            {
                this.richTextBox1.SelectedText = "<font face=\""+font+"\">" + System.Environment.NewLine +
              this.richTextBox1.SelectedText + System.Environment.NewLine + "</font>";
            }
        }

        private void toolStripBulletList_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "<ul>" + System.Environment.NewLine +
              this.richTextBox1.SelectedText + System.Environment.NewLine + "</ul>";
        }

        private void toolStripRemoveNewlines_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = this.richTextBox1.SelectedText.Replace("\n", " ");
        }

        private void toolStripBoldButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "<b>" + this.richTextBox1.SelectedText + "</b>";
        }

        private void toolStripItalicButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "<i>" + this.richTextBox1.SelectedText + "</i>";
        }

        private void toolStripUnderline_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = "<u>" + this.richTextBox1.SelectedText + "</u>";
        }
    }
}
