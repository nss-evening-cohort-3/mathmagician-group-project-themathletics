using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        

        [TestMethod]
        public void GiveBackEvensList()
        {
            // Arrange section
            Even myEven = new Even();
            // Act
            var evensTestList = myEven.CreateEvenSequence(5);
            // Assert
            Assert.IsInstanceOfType(evensTestList, typeof(List<int>));
        }

        [TestMethod]
        public void GivesBackRightNumberOfEvens()
        {
            // Arrange
            Even myEven = new Even();
            // Act
           var evensTestList = myEven.CreateEvenSequence(5);
            // Assert
            Assert.AreEqual(evensTestList.Count, 5);

        }
    }
}
