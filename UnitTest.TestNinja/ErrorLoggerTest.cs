using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace UnitTest.TestNinja
{
    [TestFixture]
    public class ErrorLoggerTest
    {
        [Test]
        public void ErrorLog_WriteTostorege_ReturnTrue()
        {
            var Error = new ErrorLogger();
            //we want use deligate 
            Error.Log("a");
            Assert.That(Error.LastError, Is.EqualTo("a"));
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ErrorLog_WriteTostorege_ThrowsExpection(string error)
        {
            var Error = new ErrorLogger();
            //we need use deligate 
           
            Assert.That(()=>Error.Log(error),Throws.ArgumentNullException);
        }
    }
}
