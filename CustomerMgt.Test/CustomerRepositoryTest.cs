using CustomerMgt.BL;
using CustomerMgt.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
             EmailAddress = "agnes@gmail.com",
             AddressList = new List<Address>()
             {
                 new Address() 
                 { 
                    AddressType = AddressType.Home,
                    StreetLine1 = "Bag",
                    StreetLine2 = "Show",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                 },
                  new Address()
                 {
                     AddressType = AddressType.Office,
                     StreetLine1 = "Bode",
                     StreetLine2 = "Thomas",
                     City = "Surulere",
                     State = "Lagos",
                    Country = "Nigeria",
                    PostalCode = "10001"
                 }
             }
            };

            //Act
            var actual = customerRepo.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }

        }
    }
}
