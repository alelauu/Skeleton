using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class wwe want to create 
            clsCustomer ACustomer = new clsCustomer();
            //test  to see that it exists 
            Assert.IsNotNull(ACustomer);
        }
    }
}
