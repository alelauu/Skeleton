using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        string FullName = "Sally";
        string Email = "P1234567@my365.dmu.ac.uk";
        string Address = "The glassworks, Leicester,LE1 5AN";
        string Number = "07497070476";
        string StartDate = DateTime.Now.ToShortDateString();

        /*******Creates an instance of the test class******/
        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instanc eof the Staff Class
            clsStaff NewStaff = new clsStaff();

            //Tests to see if it exists
            Assert.IsNotNull(NewStaff);


        }

        [TestMethod]
        public void IsOnlinePropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //Creates some test data to assign to the property
            Boolean TestStaff = true;

            //Assign the data to the property
            NewStaff.IsOnline = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.IsOnline, TestStaff);
        }

        [TestMethod]
        public void StartDatePropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //Creates some test data to assign to the property
            DateTime TestStaff = DateTime.Now.Date;

            //Assign the data to the property
            NewStaff.StartDate = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.StartDate, TestStaff);
        }


        [TestMethod]
        public void NumberPropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            String TestStaff = "07497070472";

            //Assign the data to the property
            NewStaff.Number = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.Number, TestStaff);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            String TestStaff = "The glassworks, Leicester,LE1 5AN";

            //Assign the data to the property
            NewStaff.Address = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.Address, TestStaff);
        }


        [TestMethod]
        public void EmailPropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            String TestStaff = "P2765365@my365.dmu.ac.uk";

            //Assign the data to the property
            NewStaff.Email = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.Email, TestStaff);
        }


        [TestMethod]
        public void FullNamePropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            String TestStaff = "Abbie";

            //Assign the data to the property
            NewStaff.FullName = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.FullName, TestStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            Int32 TestStaff = 2;

            //Assign the data to the property
            NewStaff.StaffId = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.StaffId, TestStaff);
        }





        /***********FIND METHOD***********/

        [TestMethod]
        public void FindMethodOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //Creates a Boolean variable to store the results of the validation
            Boolean Found = false;

            //Creates some test data to assign to the property
            Int32 StaffId = 6;

            //Invokes the "Find" method
            Found = NewStaff.Find(StaffId);

            //Tests to see that the values are equal
            Assert.IsTrue(Found);
        }

        /***********VALID METHOD***********/

        [TestMethod]
        public void ValidMethodOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store an error message
            String Error = "";

            //invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);
        }


        /***********Property Data Test***********/

        [TestMethod]
        public void TestStaffIdFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.StaffId != 6)
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartDateFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.StartDate != Convert.ToDateTime("07/01/2019"))
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNumberFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();



            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.Number != "07497070476")
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.Address != "The glassworks, Leicester,LE1 5AN")
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.Email != "P1234567@my365.dmu.ac.uk")
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestFullNameFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.FullName != "Sally")
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestIsOnlineFound()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Initialises a boolean variable to store the result of the method

            Boolean Found = false;

            // This boolean variable then checks if the data is ok
            Boolean OK = true;

            //Creates some test data to assign to the method
            Int32 StaffId = 6;

            //Invokes the method
            Found = NewStaff.Find(StaffId);

            //Checks the staff ID
            if (NewStaff.IsOnline != true)
            {
                OK = false;
            }

            //Tests to see that the values are correct
            Assert.IsTrue(OK);
        }


        /*****************Test Log Tests*****************/

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "a";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "aa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FullNameExtremeMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string FullName = "";
            FullName = FullName.PadRight(500, 'a'); //This test should fail

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /**********EMAIL VALIDATION METHODS**************/

        [TestMethod]
        public void EmailMinLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "a";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "aa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "";
            Email = Email.PadRight(255, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "";

            Email = Email.PadRight(254, 'a');
            Email = Email.PadRight(254, 'a');

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "";
            Email = Email.PadRight(256, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Email = "";

            Email = Email.PadRight(127, 'a');

            Email = Email.PadRight(127, 'a');

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }


        /**********ADDRESS VALIDATION METHODS**************/
        [TestMethod]
        public void AddressMinLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "a";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "aa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";
            Address = Address.PadRight(254, 'a');

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";
            Address = Address.PadRight(255, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";
            Address = Address.PadRight(256, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";
            Address = Address.PadRight(127, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Address = "";
            Address = Address.PadRight(500, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /**********NUMBER VALIDATION METHODS**************/


        [TestMethod]
        public void NumberMinLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = ""; //Should Fail

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NumberMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "a";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumbersMinPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "aa";

            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberMaxLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "";
            Number = Number.PadRight(10, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "";
            Number = Number.PadRight(11, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NumberMaxPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "";
            Number = Number.PadRight(12, 'a'); //Should fail
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NumberMid()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "";
            Number = Number.PadRight(5, 'a');
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NumberExtremeMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method, should trigger an error
            string Number = "";
            Number = Number.PadRight(500, 'a'); //Should fail
            //Invoke the method
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }




        /**********START DATE VALIDATION METHODS**************/

        [TestMethod]
        public void StartDateExtremeMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //Changes the date to what it is minus 100 years
            TestDate = TestDate.AddYears(-100);

            //Converts the date variable to a string variable
            string StartDate = TestDate.ToString();

            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StartDateExtremeLessOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //Changes the date to what it is minus 1 day
            TestDate = TestDate.AddDays(-1);

            //Converts the date variable to a string variable
            string StartDate = TestDate.ToString();

            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //Converts the date variable to a string variable
            string StartDate = TestDate.ToString();

            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //Changes the date to what it is plus 1 day
            TestDate = TestDate.AddDays(1);

            //Converts the date variable to a string variable
            string StartDate = TestDate.ToString();

            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Creates some test data to pass to the method
            DateTime TestDate;

            //set the date to todays date
            TestDate = DateTime.Now.Date;

            //Changes the date to what it is plus 100 years
            TestDate = TestDate.AddYears(100);

            //Converts the date variable to a string variable
            string StartDate = TestDate.ToString();

            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();

            //String variable to store any error message
            String Error = "";

            //Set the date to a non date value
            string StartDate = "This is not the permitted date value";


            //Invokes the method:
            Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);

            //Tests to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
