using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer : tstCustomerBase
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);

        }

        public void ActivePropertyOK()
        { 

            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomer.Active= TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

    }
}
