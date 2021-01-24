using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace UnitTest.TestNinja
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        //Test Method Name consists of Methodname_Senareio_ExpectedResult 
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            Reservation reservation = new Reservation();//Arrange
            var result = reservation.CanBeCancelledBy(new User
            {
                IsAdmin = true
            });//Act
            Assert.IsTrue(result);//Assert

        }

        [TestMethod]
        public void CanBeCancelledBy_MadeBy_ReturnsTrue()
        {           
            var user = new User();
            Reservation reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user);              
            Assert.IsTrue( result);
        }
        [TestMethod]
        public void CanBeCancelledBy_SomeOtheruser_ReturnsFalse()
        {        
            Reservation reservation = new Reservation ();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin=false});
            Assert.IsFalse(result);
        }
    }
}