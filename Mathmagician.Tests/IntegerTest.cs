using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTest
    {
        [TestMethod]
        public void IntegerEnsureICanCreatAnInstance()
        {
            //Arrange

            //Act
            Integer my_int = new Integer(); //What I want to be able to do. 

            //Assert
            Assert.IsNotNull(my_int);
        }
    }
}
