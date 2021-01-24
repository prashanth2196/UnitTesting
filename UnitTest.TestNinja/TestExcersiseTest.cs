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
    public class TestExcersiseTest
    {
       [Test]
       [TestCase(15)]
      
       public void GetOutput_DivisiableNumber_Returntrue(int number)
        {
            var fizbuzz = new FizzBuzz();
            Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
            //Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("Buzz"));
            //Assert.That(fizbuzz.GetOutput(number), !(!Is.EqualTo(3) || !Is.EqualTo(5)));
        }

        [Test]
        [TestCase(5)]

        public void GetOutput_DivisiableNumber5_Returntrue(int number)
        {
            var fizbuzz = new FizzBuzz();
            //Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
            Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("Buzz"));
            //Assert.That(fizbuzz.GetOutput(number), !(!Is.EqualTo(3) || !Is.EqualTo(5)));
        }

        [Test]
        [TestCase(3)]

        public void GetOutput_DivisiableNumber3_Returntrue(int number)
        {
            var fizbuzz = new FizzBuzz();
            //Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("FizzBuzz"));
            Assert.That(fizbuzz.GetOutput(number), Is.EqualTo("Fizz"));
            //Assert.That(fizbuzz.GetOutput(number), !(!Is.EqualTo(3) || !Is.EqualTo(5)));
        }

    }
}
