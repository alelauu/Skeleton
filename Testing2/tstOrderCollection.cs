using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects 
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an Item to the list
            //create the item of test data 
            clsOrder TestItem = new clsOrder();
            //set its properties 
            TestItem.IsReturned = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.CustomerID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "Processed";
            //add the item to the test list
            TestList.Add(TestItem);
            //assgin the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }

        

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.IsReturned = true;
            TestOrder.OrderID = 1;
            TestOrder.ProductID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.Quantity = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderStatus = "Processed";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.IsReturned = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.CustomerID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "Processed";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        
    }
}
