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
    }
}