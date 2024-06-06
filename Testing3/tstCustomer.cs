using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        string FullName = "Amenagahwon";
        string Email = "P2718902@my365.dmu.ac.uk";
        string PhoneNumber = "07360093312";
        string StreetAddress = "33 South St";
        string PostCode = "BN1 3AS";
        string DateOfBirth = DateTime.Now.ToShortDateString();

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists 
            Assert.IsNotNull(AnCustomer);

        }

        [TestMethod]
        public void IsOnlinePropertyOK()
        {

            //creates a new instance of the Customer class 
            clsCustomer AnCustomer = new clsCustomer();

            //creates some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnCustomer.IsOnline = TestData;

            //test to see that the two values are the same 
            Assert.AreEqual(AnCustomer.IsOnline, TestData);
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
            string TestData = "07360093312";

            //assign the data to the property
            AnCustomer.PhoneNumber = TestData;

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
            Assert.AreEqual(AnCustomer.StreetAddress, TestData);
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
            Int32 TestData = 2;

            //assign the data to the property 
            AnCustomer.CustomerId = TestData;

            //tests to see that the values are equal 
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            Assert.IsTrue(Found);

        }

        [TestMethod]

        public void TestCustomerIdFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestDateOfBirthFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.DateOfBirth != Convert.ToDateTime("11/07/2004"))
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void TestIsOnlineFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.IsOnline != true)
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]

        public void TestFullName()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.FullName != "Amenaghawon")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void TestPostCode()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PostCode != "BN11 3AS")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestEmail()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.Email != "Igbinidu")
            {
                OK = false;
            }
            Assert.IsFalse(OK);

        }

        [TestMethod]
        public void TestStreetAddress()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.StreetAddress != "33 South St")
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void TestPhoneNumber()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 21;
            Found = AnCustomer.Find(CustomerId);
            if (AnCustomer.PhoneNumber != "07360093312")
            {
                OK = false;
            }
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "Amenaghawon"; //this should be ok
                                   //invoke the method
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
                                    //invoke the method
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaa"; 
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "Amenaghawon"; 
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "Amenaghawon"; //this should pass
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FullName = "Amenaghawon"; //this should fail, invoke the method 
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FullName = ""; //this should pass
            FullName = FullName.PadRight(500, 'a'); 
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void FullNameExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FullName= ""; //this should pass
            FullName = FullName.PadRight(500, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber); 
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        }
    }
