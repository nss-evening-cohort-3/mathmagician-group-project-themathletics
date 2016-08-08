using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        

        [TestMethod]
        public void DoesThisGiveBackAnEvensList() //Checking that we are returning a list
        {
            // Arrange section
            Even myEven = new Even();
            // Act
            var evensTestList = myEven.CreateEvenSequence(5);
            // Assert
            Assert.IsInstanceOfType(evensTestList, typeof(List<int>));
        }

        [TestMethod]
        public void DoesThisGiveBackRightNumberOfEvens() //Checking that list is the right size in number of numbers
        {
            // Arrange
            Even myEven = new Even();
            // Act
           List<int> evensTestList = myEven.CreateEvenSequence(5);
            // Assert
            Assert.AreEqual(evensTestList.Count, 5);

        }

        [TestMethod]
        public void DoesThisGiveBackTheRightEvensValues()
        {
            Even myEvens = new Even();
            List<int> myCodeGeneratedEvensList = myEvens.CreateEvenSequence(2);
            List<int> testExpectedEvensList = new List<int> {0,2};
            CollectionAssert.AreEqual(myCodeGeneratedEvensList,testExpectedEvensList);


        }

        [TestMethod]
        public void CorrectFirstValue()
        {
            Even myEvens = new Even();
            List<int> firstNumberOfCodeGenSequence = myEvens.CreateEvenSequence(1);
            List<int> testExpectedFirstValue = new List<int> {0};
            CollectionAssert.AreEqual(firstNumberOfCodeGenSequence,testExpectedFirstValue);
        }


        [TestMethod]
        public void CorrectSecondValueTest()
        {
            Even myEvens = new Even();
            List<int> firstTwoNumbersFromCodeGenSequence = myEvens.CreateEvenSequence(2);
            int expectedSecondValue = 2;
            Assert.AreEqual(firstTwoNumbersFromCodeGenSequence[1], expectedSecondValue);

        }


    }
}
