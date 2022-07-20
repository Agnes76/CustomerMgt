using CustomerMgt.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerMgt.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Agnes",
                LastName = "Ugochukwu"
            };

            string expected = "Ugochukwu Agnes";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Ugochukwu"
            };
            string expected = "Ugochukwu";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Agnes"
            };
            string expected = "Agnes";

            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Ella";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Daniel";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Francis";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Ugochukwu",
                EmailAddress =  "ugochukwuagnes@gmail.com"
            };
            bool expected = true;

            //Act
            bool actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            Customer customer = new Customer
            {
                EmailAddress = "ugochukwuagnes@gmail.com"
            };
            var expected = false;

            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
