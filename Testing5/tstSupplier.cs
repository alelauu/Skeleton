using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        public object AnSupplier { get; private set; }
        public object SupplierId { get; private set; }

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
            AnSupplier.QualityAssurance = TestData;
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
            AnSupplier.QuantityOrdered = TestData;
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestSupplierIdOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier id
            if (AnSupplier.SupplierId != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Postcode property
            if (AnSupplier.Postcode != "le34pa")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Address property
            if (AnSupplier.Address != "535 st saviours road")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactPhoneOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the ContactPhone property
            if (AnSupplier.ContactPhone != "07865491211")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the Email property
            if (AnSupplier.Email != "sadjsa@gmail.com")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCompanyNameOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the CompanyName property
            if (AnSupplier.CompanyName != "ajsdjashd")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityOrderedOK()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the results of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the QuantityOrdered property
            if (AnSupplier.QuantityOrdered != 67)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the DeliveryDate property
            if (AnSupplier.DeliveryDate != Convert.ToDateTime("12/08/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQualityAssuranceFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the QualityAssurance property
            if (AnSupplier.QualityAssurance != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 SupplierId = 21;
            //invoke the method
            Found = AnSupplier.Find(SupplierId);
            //check the active property
            if (AnSupplier.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}









