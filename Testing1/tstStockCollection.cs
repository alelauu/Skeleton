using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllProducts = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);
        }
        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllProducts = new clsStockCollection();
            //creating some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its propertites
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ProductList, TestList);
        }
        [TestMethod]
        public void ThisProductPropertyOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsProduct TestItem = new clsProduct();
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            AllProducts.ThisProduct = TestItem;
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllProducts = new clsStockCollection();
            //creating some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsProduct> TestList = new List<clsProduct>();
            //add an item to the list
            //create the item of test data
            clsProduct TestItem = new clsProduct();
            //set its propertites
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllProducts.ProductList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            TestItem.ProductID = PrimaryKey;
            //find the record
            AllProducts.ThisProduct.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllProducts.ThisProduct, TestItem); 
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            TestItem.ProductID = PrimaryKey;
            //modify the test record
            TestItem.InStock = false;
            TestItem.ProductID = 11;
            TestItem.ProductName = "Test2";
            TestItem.ProductBrand = "Samsung";
            TestItem.ProductColour = "Purple";
            TestItem.ProductCapacity = "128GB";
            TestItem.ProductPrice = 249;
            TestItem.DateAdded = DateTime.Now;
            AllProducts.ThisProduct = TestItem;
            AllProducts.Update();
            AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.AreEqual(AllProducts.ThisProduct, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsProduct TestItem = new clsProduct();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.InStock = true;
            TestItem.ProductID = 9;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Nokia";
            TestItem.ProductColour = "Pink";
            TestItem.ProductCapacity = "64GB";
            TestItem.ProductPrice = 379;
            TestItem.DateAdded = DateTime.Now;
            //set ThisProduct to the test data
            AllProducts.ThisProduct = TestItem;
            //add the record
            PrimaryKey = AllProducts.Add();
            TestItem.ProductID = PrimaryKey;
            AllProducts.ThisProduct.Find(PrimaryKey);
            //delete the record
            AllProducts.Delete();
            Boolean Found = AllProducts.ThisProduct.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            clsStockCollection AllProducts = new clsStockCollection();
            clsStockCollection FilteredProducts = new clsStockCollection();
            FilteredProducts.ReportByProductName("");
            Assert.AreEqual(AllProducts.Count, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductNameNoneFound() 
        {
            clsStockCollection FilteredProducts = new clsStockCollection();
            //apply a product name that doesn't exist
            FilteredProducts.ReportByProductName("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredProducts.Count);
        }
        [TestMethod]
        public void ReportByProductNameDataFound()
        {
            clsStockCollection FilteredProducts = new clsStockCollection();
            Boolean OK = true;
            //apply a product name that doesn't exist
            FilteredProducts.ReportByProductName("Galaxy S24 Ultra");
            //check that the correct number of records are found
            if (FilteredProducts.Count == 2)
            {
                if (FilteredProducts.ProductList[0].ProductID != 2)
                {
                    OK = false;
                }
                if (FilteredProducts.ProductList[1].ProductID != 29)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
