using CustomerMgt.BL;
using CustomerMgt.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerMgt.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            OrderRepository orderRepo = new OrderRepository();

            Order expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00,
                00, new TimeSpan(7, 0, 0))
            };

            // Act
            var actual = orderRepo.Retrieve(10);

            // Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
    
}
