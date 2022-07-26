﻿using CustomerMgt.BL;
using CustomerMgt.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomerMgt.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            ProductRepository productRepo = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Predator",
                ProductionDescription = "Energy Drink",
                CurrentPrice = 100.00M
            };

            //Act
            var actual = productRepo.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductionDescription, actual.ProductionDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            ProductRepository productRepo = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Predator",
                ProductionDescription = "Energy Drink",
                CurrentPrice = 100.00M,
                HasChanges = true
            };

            //Act
            var actual = productRepo.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            ProductRepository productRepo = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Predator",
                ProductionDescription = "Energy Drink",
                CurrentPrice = null,
                HasChanges = true
            };

            //Act
            var actual = productRepo.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
