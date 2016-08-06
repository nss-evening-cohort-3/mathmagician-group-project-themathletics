using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTest
    {
        [TestMethod]
        public void GiveBackList()
        {
            Integer myInteger = new Integer();
            List<int> myList = myInteger.CreateIntegerSequence(5);
            Assert.IsInstanceOfType(myList, typeof(List<int>));
        }
        [TestMethod]
        public void GivesBackRightNumberOfNumbers()
        {
            Integer myInteger = new Integer();
            List<int> myList = myInteger.CreateIntegerSequence(5);
            Assert.AreEqual(myList.Count, 5);
        }
        [TestMethod]
        public void SequenceTest()
        {
            Integer myInteger = new Integer();
            List<int> myList = myInteger.CreateIntegerSequence(4);
            List<int> expectedList = new List<int> { 0, 1, 2, 3 };
            CollectionAssert.AreEqual(myList, expectedList);
            Assert.AreEqual(myList.IndexOf(2), 2);
        }
    }
}
