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

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.IsReturned = true;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.CustomerID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderStatus = "Processed";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.IsReturned = true;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ProductID = 1;
            TestItem.CustomerID = 1;
            TestItem.Quantity = 1;
            TestItem.OrderStatus = "Processed";
            //set ThisOrder to the test datae 
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test record
            TestItem.IsReturned = false;
            TestItem.OrderDate = DateTime.Now;
            TestItem.ProductID = 4;
            TestItem.CustomerID = 4;
            TestItem.Quantity = 4;
            TestItem.OrderStatus = "shipped";
            //set record based on the new test data 
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            //update the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if ThisOrder matche the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);


        }

        
    }
}
