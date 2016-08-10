using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTest
    {
        

        [TestMethod]
        public void DoesThisGiveBackAPrimesList() //Checking that we are returning a list
        {
            // Arrange section
            Prime myPrimes = new Prime();
            // Act
            List<int> primesTestList = myPrimes.CreatePrimeSequence(5);
            // Assert
            Assert.IsInstanceOfType(primesTestList, typeof(List<int>));
        }

        [TestMethod]
        public void DoesThisGiveBackRightNumberOfPrimes() //Checking that list is the right size in number of numbers
        {
            // Arrange
            Prime myPrimes = new Prime();
            // Act
           List<int> primeTestList = myPrimes.CreatePrimeSequence(5);
            // Assert
            Assert.AreEqual(primeTestList.Count, 6);

        }

        [TestMethod]
        public void DoesThisGiveBackTheRightPrimesValues()
        {
            Prime myPrimes = new Prime();
            List<int> myCodeGeneratedPrimesList = myPrimes.CreatePrimeSequence(2);
            List<int> testExpectedPrimesList = new List<int> {0,2};
            CollectionAssert.AreEqual(myCodeGeneratedPrimesList,testExpectedPrimesList);


        }

        [TestMethod]
        public void CorrectFirstPrimeValue()
        {
            Prime myPrimes = new Prime();
            List<int> firstNumberOfCodeGenPrimeSequence = myPrimes.CreatePrimeSequence(1);
            List<int> testExpectedFirstPrimeValue = new List<int> {0};
            CollectionAssert.AreEqual(firstNumberOfCodeGenPrimeSequence,testExpectedFirstPrimeValue);
        }


        [TestMethod]
        public void CorrectSecondPrimeValue()
        {
            Prime myPrimes = new Prime();
            List<int> firstTwoNumbersFromCodeGenPrimeSequence = myPrimes.CreatePrimeSequence(2);
            int expectedSecondPrimeValue = 2;
            Assert.AreEqual(firstTwoNumbersFromCodeGenPrimeSequence[1], expectedSecondPrimeValue);

        }


    }
}
