using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAPowerTools;

namespace EAPowerToolsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPowerEditor()
        {
            PowerEditor editor = new PowerEditor();
            editor.ShowDialog();
        }
    }
}
