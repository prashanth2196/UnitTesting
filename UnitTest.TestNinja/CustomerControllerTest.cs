
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
   public class CustomerControllerTest
    {
        [Test]
        public void GetCustomer_GetCustomerRecord_ReturnOk()
        {
            var customer = new CustomerController();
            var result = customer.GetCustomer(3);
            Assert.That(result, Is.InstanceOf<ActionResult>());
            
        }

        [Test]
        public void GetCustomer_GetCustomerRecord_ReturnNotFound()
        {
            var customer = new CustomerController();
            var result = customer.GetCustomer(0);
            Assert.That(result, Is.InstanceOf<NotFound>());

        }
    }
}
