using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method 
        string OrderDate = DateTime.Now.ToShortDateString();
        string OrderStatus = "Processed";

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
            Int32 OrderID = 6;
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
            Int32 OrderID = 6;
            //invoke the method 
            Found = OrderOne.Find(OrderID);
            // check the order ID
            if (OrderOne.OrderID != 6)
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
            Int32 OrderID = 6;
            Found = OrderOne.Find(OrderID);
            if(OrderOne.CustomerID != 1818)
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
            Int32 OrderID = 6;
            Found = OrderOne.Find(OrderID);
            if(OrderOne.OrderDate != Convert.ToDateTime("15/05/2023"))
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
            Int32 OrderID = 6;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.OrderStatus != "Processed")
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
            Int32 OrderID = 6;
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
            Int32 OrderID = 6;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.ProductID != 1414)
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
            Int32 OrderID = 6;
            Found = OrderOne.Find(OrderID);
            if (OrderOne.Quantity != 11)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder OrderOne = new clsOrder();
            string Error = "";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        //First test ORder Status
        [TestMethod] 
        public void OrderStatusMinLessOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMin()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "a";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "aa";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxLessOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaa";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMax()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaaa";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "aaaaaaaaaa";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMaxPlusOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "aaaaaaaaaaaaaaaaaaaaa";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMax()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderStatus = "";
            OrderStatus = OrderStatus.PadRight(100, 'a');
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder OrderOne = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke method
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDate = TestDate.ToString();
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMin()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDate = TestDate.ToString();
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string OrderDate = TestDate.ToString();
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDate = TestDate.ToString();
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder OrderOne = new clsOrder();
            String Error = "";
            string OrderDate = "this is not a date!";
            Error = OrderOne.Valid(OrderStatus, OrderDate);
            Assert.AreNotEqual(Error, "");
        }
        

    }
}
