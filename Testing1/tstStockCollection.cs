using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
