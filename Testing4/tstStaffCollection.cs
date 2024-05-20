using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            //tests to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //Creates an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();

            //Creates some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();

            //Creates the test data items

            clsStaff TestStaff = new clsStaff();

            //Appends it to the list
            TestStaff.IsOnline = true;
            TestStaff.StaffId = 6;
            TestStaff.FullName = "Sally";
            TestStaff.Email = "P1234567@my365.dmu.ac.uk";
            TestStaff.Address = "The glassworks, Leicester,LE1 5AN";
            TestStaff.Number = "07497070476";
            TestStaff.StartDate = DateTime.Now;

            //Adds the item to the test list
            TestList.Add(TestStaff);

            //Assings the data to the property
            AllStaff.StaffList = TestList;

            //Tests to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);


        }
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //Creates an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();

            //Creates some test data to assign to the property
            clsStaff TestStaff = new clsStaff();

            //Appends it to the list
            TestStaff.IsOnline = true;
            TestStaff.StaffId = 6;
            TestStaff.FullName = "Sally";
            TestStaff.Email = "P1234567@my365.dmu.ac.uk";
            TestStaff.Address = "The glassworks, Leicester,LE1 5AN";
            TestStaff.Number = "07497070476";
            TestStaff.StartDate = DateTime.Now;

            //Assign the data to the property
            AllStaff.ThisStaff = TestStaff;

            //Tests to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }





        [TestMethod]

        public void ListAndCountOK()
        {

            //Creates an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            //Creates some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();

            //Creates the test data items

            clsStaff TestStaff = new clsStaff();

            //Appends it to the list
            TestStaff.IsOnline = true;
            TestStaff.StaffId = 6;
            TestStaff.FullName = "Sally";
            TestStaff.Email = "P1234567@my365.dmu.ac.uk";
            TestStaff.Address = "The glassworks, Leicester,LE1 5AN";
            TestStaff.Number = "07497070476";
            TestStaff.StartDate = DateTime.Now;

            //Adds the item to the test list
            TestList.Add(TestStaff);

            //Assings the data to the property
            AllStaff.StaffList = TestList;

            //Tests to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //Creates an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            //Creates the items of the test data
            clsStaff TestStaff = new clsStaff();

            //Variable is created to store the primary number
            Int32 PrimaryKey = 0;

            //Set the properties
            TestStaff.IsOnline = true;
            TestStaff.StaffId = 7;
            TestStaff.FullName = "John";
            TestStaff.Email = "P2345678@my365.dmu.ac.uk";
            TestStaff.Address = "The glassworks, Leicester,LE1 5AN";
            TestStaff.Number = "07497070478";
            TestStaff.StartDate = DateTime.Now;

            //Set the ThisStaff to the test data
            AllStaff.ThisStaff = TestStaff;

            //Adds the record 
            PrimaryKey = AllStaff.Add();

            //Sets the primary key of the test data
            TestStaff.StaffId = PrimaryKey;

            //Finds the record
            AllStaff.ThisStaff.Find(PrimaryKey);

            //Tests to see that th 2 values are equal
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ReportByFullNameOK()
        {
            //create an instance of the staff collection class
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //Apply a blank string, should return all records
            FilteredStaff.ReportByFullName("");

            //Test to see that the values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //Creates an instance of the class we want to create 
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //Apply a Name that doesn't exist
            FilteredStaff.ReportByFullName(" ");

            //Test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //Creates an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //Variable to store the outcome
            Boolean OK = true;

            //Apply a full name that doesn't exist
            FilteredStaff.ReportByFullName("Tim");

            //Check to see that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {

                //Check to see that the first record is 8
                if (FilteredStaff.StaffList[0].StaffId != 8)
                {
                    OK = false;
                }
                //Check to see that the second record is 9
                if (FilteredStaff.StaffList[1].StaffId != 9)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //Tests to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}