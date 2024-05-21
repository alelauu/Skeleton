using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);

        }

    }
}
