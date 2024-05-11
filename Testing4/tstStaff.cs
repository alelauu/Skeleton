using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {

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
        public void PostCodePropertyOK()
        {
            //Creates a new instance of the Staff class

            clsStaff NewStaff = new clsStaff();


            //Creates some test data to assign to the property
            String TestStaff = "LE1 5AN";

            //Assign the data to the property
            NewStaff.PostCode = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.PostCode, TestStaff);
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
        public void TestPostCodeFound()
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
            if (NewStaff.PostCode != "LE1 7AN")
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
    }
    }


