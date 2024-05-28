using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer : tstCustomerBase
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);

        }

        [testMethod]
        public void ActivePropertyOK()
        {

            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomer.Active = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property 
            AnCustomer.DateOfBirth = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property 
            string TestCustomer = "07360093312";

            //assign the data to the property
            AnCustomer.Number = TestData;

            //tests to see that the values are equal 
            Assert.AreEqual(AnCustomer.PhoneNumber, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "BN1 3AS";

            //assign the data to the property 
            AnCustomer.PostCode = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();

            //create some test data to assign to the property
            string TestData = "33 South St";

            //assign the data to the property 
            AnCustomer.StreetAddress = TestData;

            //test to see that the two values are the same 
            Asert.AreEqual(AnCustomer.StreetAddress, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates ome test data to assign to the property 
            string TestData = "P2718902@my365.dmu.ac.uk";

            //assign the data to the property
            AnCustomer.Email = TestData;

            //tests to see that the values are equal
            Assert.AreEqual(AnCustomer.Email, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //creates a new instance of the customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property
            string TestData = "Amenaghawon";

            //assign the data to the property 
            AnCustomer.FullName = TestData;

            //tests to see that the values are equal 
            Assert.AreEqual(AnCustomer.FullName, TestData); 
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property 
            Int34 TestData = 2;

            //assign the data to the property 
            AnCustomer.CustomerId = TestData;

            //tests to see that the values are equal 
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
    }
}
