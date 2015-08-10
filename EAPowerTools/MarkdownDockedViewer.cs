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
    public partial class MarkdownDockedViewer : UserControl
    {
        private EA.Repository currentRepo;
        private Markdown md;

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
            EA.Element element = EAHelper.GetCurrentElement(currentRepo);
            if (element != null)
            {
                EA.TaggedValue tv = (EA.TaggedValue) element.TaggedValuesEx.GetByName("Markdown");
                EA.TaggedValue st = (EA.TaggedValue)element.TaggedValuesEx.GetByName("MarkdownStyle");

                string styleLink = String.Format("<link rel=\"stylesheet\" href=\"{0}\">", st.Value);

                if (tv != null)
                {
                    this.webBrowser1.DocumentText =
                        String.Format(Properties.Resources.HTMLHeader, styleLink, md.Transform(tv.Notes));
                }
            }
           
        }
    }
}
