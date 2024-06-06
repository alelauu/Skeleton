using System;
using System.Xml.Schema;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;

        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }


        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private string mFullName;
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {
                mFullName = value;
            }
        }
        private string mStreetAddress;
        public string StreetAddress
        {
            get
            {
                return mStreetAddress;

            }
            set
            {
                mStreetAddress = value;

            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;

            }
            set
            {
                mEmail = value;

            }
        }

        private string mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        private string mPostCode;
        public string PostCode
        {
            get
            {
                return mPostCode;

            }
            set
            {
                mPostCode = value;

            }
        }

        private Boolean mIsOnline;
        public bool IsOnline
        {
            get
            {
                return mIsOnline;
            }
            set
            {
                mIsOnline = value;
            }

        }











        /****** FIND METHOD ******/
        public bool Find(int CustomerId)
        {

            //create an insance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mStreetAddress = Convert.ToString(DB.DataTable.Rows[0]["StreetAddress"]);
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;

            }
        }


        /****** Valid METHOD ******/

        public string Valid(string dateOfBirth, string FullName, string streetAddress, string postCode, string email, string phoneNumber)
        {
            //create a string variable to store the error
            String Error = "";






            // Validate description
            if (string.IsNullOrEmpty(FullName))
            {
                Error += "The full name no be blank : ";
            }
            else if (FullName.Length > 50)
            {
                Error += "The full name must be less tham 6 charcters : ";
            }





            //return any error messages
            return Error;

        }


        // public string FullName { get; set; }
        // public string Email { get; set; }
        //public string PostCode { get; set; }
        //public bool IsOnline { get; set; }
        // public string StreetAddress { get; set; }
        //public string PhoneNumber { get; set; }
    }
}


