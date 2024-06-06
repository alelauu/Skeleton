using System;
using System.Xml.Schema;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerId;
        public bool Find(int customerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", customerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if (DB.Count == 1)
            {
                CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                FullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                StreetAddress = Convert.ToString(DB.DataTable.Rows[0]["StreetAddress"]);
                PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                Email = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                PhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                IsOnline = Convert.ToBoolean(DB.DataTable.Rows[0]["IsOnline"]);
                DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                return true;
            }
            else
            {
                return false;
            }

        }
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
    }


    // public string FullName { get; set; }
    // public string Email { get; set; }
    //public string PostCode { get; set; }
    //public bool IsOnline { get; set; }
    // public string StreetAddress { get; set; }
    //public string PhoneNumber { get; set; }
}


