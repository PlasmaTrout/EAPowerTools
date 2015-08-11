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
using System.IO;

namespace EAPowerTools
{
    public partial class MarkdownDockedViewer : UserControl
    {
        private EA.Repository currentRepo;
        private Markdown md;
        EA.Element element;
        EA.TaggedValue field;
        EA.TaggedValue style;
        EA.TaggedValue skin;

        public MarkdownDockedViewer()
        {
            InitializeComponent();
            md = new Markdown();
        }

        public void SetRepo(EA.Repository repo)
        {
            this.currentRepo = repo;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshWebBrowser();
        } 

        private void RefreshWebBrowser()
        {
            element = EAHelper.GetCurrentElement(currentRepo);

            if (element != null)
            {
                field = element.TaggedValuesEx.GetByName("Markdown");

                if (field == null)
                {
                    field = element.TaggedValuesEx.AddNew("Markdown", "TaggedValue");
                    field.Value = "<memo>";
                    field.Update();
                }

                style = element.TaggedValuesEx.GetByName("MarkdownStyle");
                if (style == null)
                {
                    style = element.TaggedValuesEx.AddNew("MarkdownStyle", "TaggedValue");
                    style.Value = "";
                    style.Update();
                }

                skin = element.TaggedValuesEx.GetByName("PrettifySkin");
                if (skin == null)
                {
                    skin = element.TaggedValuesEx.AddNew("PrettifySkin", "TaggedValue");
                    skin.Value = "sunburst";
                    skin.Update();
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("<link rel=\"stylesheet\" href=\"{0}\">", style.Value));
           

            string s = skin.Value;

            if (s != "default")
            {
                s = "?skin=" + s;
            }
            else
            {
                s = "";
            }

            string file = Path.GetTempPath() + "documentation.html";

            using (FileStream fs = File.Open(file, FileMode.Create))
            {
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(Properties.Resources.HTMLHeader, sb.ToString(), s, md.Transform(field.Notes));
            }


            this.webBrowser1.Navigate(file);

        }
    }
}
