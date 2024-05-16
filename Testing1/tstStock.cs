using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        //create some test data to pass the method
        string ProductName = "Pixel 8a";
        string ProductBrand = "HUAWEI";
        string ProductColour = "Titanium Grey";
        string ProductCapacity = "512GB";
        double ProductPrice = 1299.99;
        string DateAdded = DateTime.Now.ToShortDateString();
        bool InStock = false;

        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance
            clsProduct ProductOne = new clsProduct();
            //a test to see that it exists
            Assert.IsNotNull(ProductOne);
        }

        [TestMethod]
        public void InStockPropertyOK() 
        {
            //creating an instance
            clsProduct ProductOne = new clsProduct();

            //creating test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ProductOne.InStock = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(ProductOne.InStock, TestData);
        }

        [TestMethod]
        public void ProductIdPropertyOK() 
        {
            clsProduct ProductOne = new clsProduct();
            Int32 TestData = 4;
            ProductOne.ProductID = TestData;
            Assert.AreEqual(ProductOne.ProductID, TestData);
        }

        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsProduct ProductOne = new clsProduct();
            string TestData = "iPhone 13 Pro";
            ProductOne.ProductName = TestData;
            Assert.AreEqual(ProductOne.ProductName, TestData);
        }

        [TestMethod]
        public void ProductBrandPropertyOK()
        {
            clsProduct ProductOne = new clsProduct();
            string TestData = "Samsung";
            ProductOne.ProductBrand = TestData;
            Assert.AreEqual(ProductOne.ProductBrand, TestData);
        }

        [TestMethod]
        public void ProductColourPropertyOK() 
        {
            clsProduct ProductOne = new clsProduct();
            string TestData = "Blue";
            ProductOne.ProductColour = TestData;
            Assert.AreEqual(ProductOne.ProductColour, TestData);
        }

        [TestMethod]
        public void ProductCapacityPropertyOK()
        {
            clsProduct ProductOne = new clsProduct();
            string TestData = "256GB";
            ProductOne.ProductCapacity = TestData;
            Assert.AreEqual(ProductOne.ProductCapacity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creating an instance of the class
            clsProduct ProductOne = new clsProduct();
            //creating a boolean variable to store the results ofthe validation
            Boolean Found = false;
            //creating some test data to use with the method
            Int32 ProductID = 4;
            //invoke the method
            Found = ProductOne.Find(ProductID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        /************** FIND METHODS **************/
        [TestMethod]
        public void TestProductIDFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductID != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductName != "Pixel 8a")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductBrandFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductBrand != "Google")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductColourFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductColour != "Aloe")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductCapacityFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductCapacity != "128GB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductPriceFound()
        {
            clsProduct ProductOne = new clsProduct();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assumed)
            Boolean OK = true;
            //creating some test data
            Int32 ProductID = 6;
            //invoking the method
            Found = ProductOne.Find(ProductID);
            //checking the product id
            if (ProductOne.ProductPrice != Convert.ToInt32(499))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /************** VALID METHOD **************/

        [TestMethod]
        public void ValidMethodOK()
        {
            //creating an instance of the class
            clsProduct ProductOne = new clsProduct();
            //string variable to store error message
            String Error = "";
            //invoking the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        /************** TEST MIN/MAX METHODS **************/

        /*** ProductName ***/

        [TestMethod]
        public void ProductNameMinLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = ""; //triggers an error
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "a";
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "aa";
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; 
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; 
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; 
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "aaaaaaaaaaaaaaa"; //passes
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*** DateAdded ***/

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            DateTime TestDate;
            string DateAdded = "this is not a date!";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        /*** ProductBrand ***/

        [TestMethod]
        public void ProductBrandMinLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = ""; //triggers an error
            //invoke the method
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "a";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMinPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "aa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMaxLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "aaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "aaaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMaxPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "aaaaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandMid()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductBrand = "aaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductBrandExtremeMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a'); 
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        /*** ProductColour ***/

        [TestMethod]
        public void ProductColourMinLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "a";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMinPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "aa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMaxLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "aaaaaaaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "aaaaaaaaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMaxPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "aaaaaaaaaaaaaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourMid()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductColour = "aaaaaaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductColourExtremeMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(100, 'a');
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        /*** ProductCapacity ***/
        [TestMethod]
        public void ProductCapacityMinLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMin()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "a";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMinPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "aa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMaxLessOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "aaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "aaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMaxPlusOne()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "aaaaaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapacityMid()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductCapacity = "aaa";
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductCapcityExtremeMax()
        {
            clsProduct ProductOne = new clsProduct();
            String Error = "";
            string ProductName = "";
            ProductName = ProductName.PadRight(50, 'a');
            Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, ProductPrice, DateAdded);
            Assert.AreNotEqual(Error, "");
        }
    }
}
