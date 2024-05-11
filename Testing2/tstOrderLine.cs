﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine OrderLineOne = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(OrderLineOne);
        }

        [TestMethod]
        public void OrderCompletePropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrderLine OrderLineOne = new clsOrderLine();
            //create some test dta to assign to the propertry
            Boolean TestData = true;
            //Assign the data to the property
            OrderLineOne.OrderComplete = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(OrderLineOne.OrderComplete, TestData);
        }

        [TestMethod]
        public void OrderItemIDPropertyOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            Int32 TestData = 1;
            OrderLineOne.OrderItemID = TestData;
            Assert.AreEqual(OrderLineOne.OrderItemID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            Int32 TestData = 1;
            OrderLineOne.OrderID = TestData;
            Assert.AreEqual(OrderLineOne.OrderID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            Int32 TestData = 1;
            OrderLineOne.ProductID = TestData;
            Assert.AreEqual(OrderLineOne.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            Int32 TestData = 1;
            OrderLineOne.Quantity = TestData;
            Assert.AreEqual(OrderLineOne.Quantity, TestData);
        }

        [TestMethod]
        public void ProductPropertyOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            string TestData = "iphone 14"; 
            OrderLineOne.Product = TestData;
            Assert.AreEqual(OrderLineOne.Product, TestData);
        }

        [TestMethod]
        public void TotalPriceOK()
        {
            clsOrderLine OrderLineOne = new clsOrderLine();
            decimal TestData = 16.81m;
            OrderLineOne.TotalPrice = TestData;
            Assert.AreEqual(OrderLineOne.TotalPrice, TestData);
        }
    }
}