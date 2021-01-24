using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace UnitTest.TestNinja
{
    [TestClass]
   public class HtmlFormaterTest
    {
        [TestMethod]
        public void HTMLformater_Bold_ReturnTrue()
        {
            var HtmlFormat = new HtmlFormatter();
            var result = HtmlFormat.FormatAsBold("abc");
            var output = "<strong>abc</strong>";
            Assert.AreEqual(output, result);
        }
    }
}
