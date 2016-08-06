using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        

        [TestMethod]
        public void GiveBackEvensList() //Checking that we are returning a list
        {
            // Arrange section
            Even myEven = new Even();
            // Act
            var evensTestList = myEven.CreateEvenSequence(5);
            // Assert
            Assert.IsInstanceOfType(evensTestList, typeof(List<int>));
        }

        [TestMethod]
        public void GivesBackRightNumberOfEvens() //Checking that list is the right size in number of numbers
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
