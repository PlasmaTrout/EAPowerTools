﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPowerToolsFormTests
{
    public partial class MarkdownTest : Form
    {
        public MarkdownTest()
        {
            InitializeComponent();
            this.markdownNotesControl1.MarkdownText = Properties.Resources.TestMarkdownNote;
            
        }

        private void MarkdownTest_Load(object sender, EventArgs e)
        {
            //this.markdownNotesControl1.UpdateWebBrowser();
        }
    }
}
