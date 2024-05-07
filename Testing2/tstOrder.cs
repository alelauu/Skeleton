using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder OrderOne = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(OrderOne);
        }

        [TestMethod]
        public void IsReturnedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrder OrderOne = new clsOrder();
            //create some test dta to assign to the propertry
            Boolean TestData = true;
            //Assign the data to the property
            OrderOne.IsReturned = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(OrderOne.IsReturned, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder OrderOne = new clsOrder();
            //create some test data to assign to the new property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            OrderOne.OrderDate = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(OrderOne.OrderDate, TestData);

        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder OrderOne = new clsOrder();
            Int32 TestData = 1;
            OrderOne.OrderID = TestData;
            Assert.AreEqual(OrderOne.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder OrderOne = new clsOrder();
            Int32 TestData = 1;
            OrderOne.CustomerID = TestData;
            Assert.AreEqual(OrderOne.CustomerID, TestData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            clsOrder OrderOne = new clsOrder();
            string TestData = "processed";
            OrderOne.OrderStatus = TestData;
            Assert.AreEqual(OrderOne.OrderStatus, TestData);
        }

    }
}
