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
            List<int> myList = myFibNum.CreateFibSequence(6);
            Assert.IsInstanceOfType(myList, typeof(List<int>));
        }
        [TestMethod]
        public void GivesBackRightNumberOfNumbers()
        {
            Fib myFibNum = new Fib();
            List<int> myList = myFibNum.CreateFibSequence(6);
            Assert.AreEqual(myList.Count, 6);
        }
        [TestMethod]
        public void CreateFibSequence()
        {
            Fib myFibNum = new Fib();
            List<int> myList = myFibNum.CreateFibSequence(7);
            List<int> expectedList = new List<int> { 1, 1, 2, 3, 5, 8, 13 };
            CollectionAssert.AreEqual(myList, expectedList);
            Assert.AreEqual(myList.IndexOf(8), 5);
        }
    }
}