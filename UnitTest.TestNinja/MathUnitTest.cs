using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

using Math = TestNinja.Fundamentals.Math;

namespace UnitTest.TestNinja
{
    [TestClass]
  public  class MathUnitTest
    {
        [TestMethod]
        public void Add_TwoNumbers_ReturnsTrue()
        {
            var math = new Math();
            int expected = 5;
            var result = math.Add(2, 3);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Max_FirstIslaregestInTwoNumbers_ReturnsTrue()
        {
            var math = new Math();
            int expected = 7;
            var result = math.Max(7, 6);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SecondIsMax_laregestInTwoNumbers_ReturnsTrue()
        {
            var math = new Math();
            int expected = 12;
            var result = math.Max(7, 12);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Max_ArgumentsAreEqual_ReturnsTrue()
        {
            var math = new Math();
            int expected = 1;
            var result = math.Max(1, 1);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetOddNumber_Oddnumber_Returntrue()
        {
            var math = new Math( );
            int expected = 5;
            var result = math.GetOddNumbers(10).Count();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result);
            // OVERLOADS
            
        }
        [Test]
        public void GetOddNumber_Oddnumber_Returntru()
        {
            var math = new Math();
           // int expected = 5;
            var result = math.GetOddNumbers(5);
            NUnit.Framework.Assert.That(result, Does.Contain(1));
            NUnit.Framework.Assert.That(result,Is.EquivalentTo(new [] {1,3,5 }));
            // OVERLOADS

        }
    }
}
