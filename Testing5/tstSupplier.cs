using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        public object AnSupplier { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //test to see that it exists
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign data to the property 
            AnSupplier.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Active, TestData);
        }
        [TestMethod]
        public void QualityAssurancePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnSupplier.Active = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.QualityAssurance, TestData);
        }

        [TestMethod]
        public void DeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date; 
            //assign the data to the property
            AnSupplier.DeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.DeliveryDate, TestData);
        }

        [TestMethod]
        public void QuantityOrderedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 8;
            //assign the data to the property
            AnSupplier.SupplierId = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.QuantityOrdered, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "le56rh";
            //assign the data to the property
            AnSupplier.Postcode = TestData; 
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Postcode, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "9jhbhvfy";
            //assign the data to the property
            AnSupplier.Address = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.Address, TestData);
        }

        [TestMethod]
        public void ContactPhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "072632762";
            //assign the data to the property
            AnSupplier.ContactPhone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.ContactPhone, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "hhfh@gmail";
            //assign the data to the property
            AnSupplier.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnSupplier.Email, TestData);
        }

        [TestMethod]
        public void CompanyNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create some test data to assign to the property
            string TestData = "hfchf";
            //assign the data to the property
            AnSupplier.CompanyName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnSupplier.CompanyName, TestData);
        }



        }

            

        }



        
    

