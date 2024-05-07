using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
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
            String TestStaff = "2";

            //Assign the data to the property
            NewStaff.StaffId = TestStaff;

            //Tests to see that the values are equal
            Assert.AreEqual(NewStaff.StaffId, TestStaff);
        }
    }
    }


