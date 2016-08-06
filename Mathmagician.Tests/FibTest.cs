using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibTest
    {
        [TestMethod]
        public void GiveBackList()
        {
            Fib myFibNum = new Fib();
            var myList = myFibNum.CreateFibinacciSequence(6);
            Assert.IsInstanceOfType(myList, typeof(List<int>));
        }
        [TestMethod]
        public void GivesBackRightNumberOfNumbers()
        {
            Fib myFibNum = new Fib();
            var myList = myFibNum.CreateFibinacciSequence(6);
            Assert.AreEqual(myList.Count, 6);
        }
        [TestMethod]
        public void CreateOddSequence()
        {
            Fib myFibNum = new Fib();
            var myList = myFibNum.CreateFibinacciSequence(7);
            var expectedList = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            CollectionAssert.AreEqual(myList, expectedList);
        }
    }
}