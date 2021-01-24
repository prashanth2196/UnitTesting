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
   public class DelimterTest
    {
        [Test]
        [TestCase(-1)]
        public void Speed_LessthanZero_ThrowExpection(int speed)
        {
            var delimeter = new DemeritPointsCalculator();
           // var result = delimeter.CalculateDemeritPoints(speed);
            Assert.That(()=>delimeter.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        [TestCase(350)]
        public void Speed_MorehanZero350_ThrowExpection(int speed)
        {
            var delimeter = new DemeritPointsCalculator();
            // var result = delimeter.CalculateDemeritPoints(speed);
            Assert.That(() => delimeter.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());

        }

        [Test]
        [TestCase(70)]
        public void Speed_MorehanZero_ThrowExpection(int speed)
        {
            var delimeter = new DemeritPointsCalculator();
             var result = delimeter.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(1));

        }

        [Test]
        [TestCase(65)]
        public void Speed_MorehanZer_ThrowExpection(int speed)
        {
            var delimeter = new DemeritPointsCalculator();
             var result = delimeter.CalculateDemeritPoints(speed);
            Assert.That(result,Is.EqualTo(0) );

        }

        [Test]
        [TestCase(64)]
        public void Speed_MorehanZero64_ThrowExpection(int speed)
        {
            var delimeter = new DemeritPointsCalculator();
            var result = delimeter.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(0));

        }
    }
}
