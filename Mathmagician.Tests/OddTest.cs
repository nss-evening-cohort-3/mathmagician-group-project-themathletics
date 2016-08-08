using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class OddTest
    {
        [TestMethod]
        public void GiveBackList()
        {
            Odd myOddNum = new Odd();
            List<int> myList = myOddNum.CreateOddSequence(6);
            Assert.IsInstanceOfType(myList, typeof(List<int>));
        }
        [TestMethod]
        public void GivesBackRightNumberOfNumbers()
        {
            Odd myOddNum = new Odd();
            List<int> myList = myOddNum.CreateOddSequence(6);
            Assert.AreEqual(myList.Count, 6);
        }
        [TestMethod]
        public void CreateOddSequence()
        {
            Odd myOddNum = new Odd();
            List<int> myList = myOddNum.CreateOddSequence(4);
            List<int> expectedList = new List<int> { 1, 3, 5, 7 };
            CollectionAssert.AreEqual(myList, expectedList);
            Assert.AreEqual(myList.IndexOf(5), 2);
        }
    }
}