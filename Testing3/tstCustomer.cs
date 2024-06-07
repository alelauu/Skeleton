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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
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
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string FullName = "Amenaghawon"; //this should fail, invoke the method 
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
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
            string FullName = ""; //this should pass
            FullName = FullName.PadRight(500, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "a";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "aa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "aaaaaaaa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "aaaaaaaaa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "aaaaaaaaa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PostCode = "aaaa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StreetAddressMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetAddressMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "a";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetAddressMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "aa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetAddressMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(49, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StreetAddressMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "";
            StreetAddress.PadRight(50, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetAddressMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetAddressMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string StreetAddress = "";
            StreetAddress = StreetAddress.PadRight(25, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "a";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "aa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            StreetAddress.PadRight(50, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer AnAddress = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(25, 'a');
            //invoke the method
            Error = AnAddress.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber  = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "a";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string PhoneNumber = "aa";
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            PhoneNumber = PhoneNumber.PadRight(49, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            PhoneNumber.PadRight(50, 'a');
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string Date = TestDate.ToString();
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error,"");


        }

        [TestMethod] 
        public void DateOfBirthMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        
    }
}
