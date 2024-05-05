using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            //creating an instance
            clsProduct ProductOne = new clsProduct();
            //a test to see that it exists
            Assert.IsNotNull(ProductOne);
        }
    }
}
