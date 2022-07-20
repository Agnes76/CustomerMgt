using CustomerMgt.BL;
using CustomerMgt.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerMgt.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
             FirstName = "Agnes",
             LastName = "Ugochukwu",
             EmailAddress = "agnes@gmail.com"
            };

            //Act
            var actual = customerRepo.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

        }
    }
}
