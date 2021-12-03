using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Auction.Webapi.Data.UnitTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void GetCustomer_ValidId()
        {
            //-- 1. Arrange ----------------------
            const int CUSTOMER_ID = 1;
            const string FNAME = "John";
            const string LNAME = "Doe";

            //-- Creating a fake ICustomerRepository object
            var repository = new Mock<ICustomerRepository>();

            //-- Setting up the repository in order to return
            //-- exactly what we expect.
            repository
                .Setup(m => m.GetCustomer(CUSTOMER_ID))
                .Returns(new Customer { FirstName = FNAME, LastName = LNAME });

            var service = new CustomerService(repository.Object);

            //-- 2. Act ----------------------
            var customer = service.GetCustomer(CUSTOMER_ID);

            //-- Assert  ----------------------
            Assert.IsTrue(customer != null);
            Assert.IsTrue(customer.FirstName == FNAME);
            Assert.IsTrue(customer.LastName == LNAME);
        }

        [TestMethod]
        [TestCategory("Manual")]
        public void GetCustomerOrderTest()
        {
            Assert.Fail("Test not implemented");
        }
    }
}
