using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public void ThisIsNotATest()
        {

        }

        [TestMethod]
        public void TestThatThisIsTrue()
        {
            // Arrange section

            // Act ''

            // Assert ''
            //Assert.Fail();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            // Arrange
            // Act
            // Assert
            Assert.Fail();
        }
    }
}
