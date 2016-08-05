using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTest
    {
        [TestMethod]
        public void GettingIntegerListBack()
        {
            //Arrange
            //Act
            //Assert.IsNotNull(LoopInt);
            //Assert.IsInstanceOfType(LoopInt, typeof(int));
        }
        [TestMethod]
        public void GiveBackList()
        {
            Integer myInteger = new Integer();
            var myList = myInteger.CreateIntegerSequence(5);
            Assert.IsInstanceOfType(myList, typeof(List<int>));
        }
        [TestMethod]
        public void GivesBackRightNumberOfNumbers()
        {
            Integer myInteger = new Integer();
            var myList = myInteger.CreateIntegerSequence(5);
            Assert.AreEqual(myList.Count, 5);
        }
        [TestMethod]
        public void SequenceTest()
        {
            Integer myInteger = new Integer();
            var myList = myInteger.CreateIntegerSequence(4);
            var expectedList = new List<int> { 0, 1, 2, 3 };
            CollectionAssert.AreEqual(myList, expectedList);
            Assert.AreEqual(myList.IndexOf(2), 2);
        }
    }
}
// new instance? Jurnell example??? And Kate's, review
// new list? 
// new list of the right number? 
// new list has the right values inside? 
// any other kind of problem like negative numbers or zero, etc. 
