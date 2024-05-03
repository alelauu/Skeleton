using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Creates a new instance of the Staff Class
            clsStaff NewStaff = new clsStaff();

            //Test to see that it exists
            Assert.IsNotNull(NewStaff);
        }
    }
}
