using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            // Arrange - first we arrange or setup for the test.
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductId = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act - by calling SayHelloTest()
            var actual = currentProduct.SayHello();

            // Assert - that the expected value defined matches the actual value returned by the method.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHello_ParameterizedConstructor()
        {
            // Arrange - first we arrange or setup for the test.
            var currentProduct = new Product(1, "Saw",
                                 "15-inch steel blade hand saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            // Act - by calling SayHelloTest()
            var actual = currentProduct.SayHello();

            // Assert - that the expected value defined matches the actual value returned by the method.
            Assert.AreEqual(expected, actual);
        }
    }
}