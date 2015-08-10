using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAPowerTools
{
    class MarkdownStyle
    {
        public String Name { get; set; }
        public String CSSLink { get; set; }

        public MarkdownStyle(string name, string link)
        {
            this.Name = name;
            this.CSSLink = link;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
