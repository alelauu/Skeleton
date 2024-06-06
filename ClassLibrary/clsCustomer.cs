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

        public bool Find(int customerId)
        {
            mCustomerId = 21;
            mDateOfBirth = Convert.ToDateTime("23/12/2022");
            mIsOnline = true;
            mFullName = "Amenaghawon";
            mPostCode = "BN1 3AS";
            mEmail = "P2718902@my365.dmu.ac.uk";
            mStreetAddress = "33 South St";
            mPhoneNumber = "07360093312";

            return true;
        }
    }


    // public string FullName { get; set; }
    // public string Email { get; set; }
    //public string PostCode { get; set; }
    //public bool IsOnline { get; set; }
    // public string StreetAddress { get; set; }
    //public string PhoneNumber { get; set; }
}


