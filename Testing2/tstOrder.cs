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

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrder OrderOne = new clsOrder();
            Int32 TestData = 1;
            OrderOne.ProductID = TestData;
            Assert.AreEqual(OrderOne.ProductID, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder OrderOne = new clsOrder();
            Int32 TestData = 1;
            OrderOne.Quantity = TestData;
            Assert.AreEqual(OrderOne.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder OrderOne = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 OrderID = 21;
            //invoke the method
            Found = OrderOne.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder OrderOne = new clsOrder();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method 
            Found = OrderOne.Find(OrderID);
            // check the order ID
            if (OrderOne.OrderID != 21)
            {

                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if(OrderOne.CustomerID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if(OrderOne.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.OrderStatus != "processed")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
             
        }

        [TestMethod]
        public void TestIsReturnedFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.IsReturned != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.ProductID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder OrderOne = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.Quantity != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
