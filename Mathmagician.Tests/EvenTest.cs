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

        [TestMethod]
        public void EvensSequenceTest()
        {
            Even myEvens = new Even();
            List<int> generatedEvensList = myEvens.CreateEvenSequence(2);
            List<int> expectedEvensList = new List<int> {0,2};
            CollectionAssert.AreEqual(generatedEvensList,expectedEvensList);


        }

        [TestMethod]
        public void FirstValueTest()
        {
            Even myEvens = new Even();
            List<int> firstNumberOfSequence = myEvens.CreateEvenSequence(1);
            List<int> expectedFirstValue = new List<int> {0};
            CollectionAssert.AreEqual(firstNumberOfSequence,expectedFirstValue);
        }


        [TestMethod]
        public void SecondValueTest()
        {
            Even myEvens = new Even();
            List<int> firstTwoNumbersInSequence = myEvens.CreateEvenSequence(2);
            int expectedSecondValue = 2;
            Assert.AreEqual(firstTwoNumbersInSequence[1], expectedSecondValue);

        }


    }
}
