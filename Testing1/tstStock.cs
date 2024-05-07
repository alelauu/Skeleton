using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
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
        public void AmountInStockPropertyOK()
        {
            clsProduct ProductOne = new clsProduct();
            Int32 TestData = 1;
            ProductOne.AmountInStock = TestData;
            Assert.AreEqual(ProductOne.AmountInStock, TestData);
        }
    }
}
