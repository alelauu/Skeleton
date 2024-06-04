using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the SupplierId property
        private Int32 mSupplierId;
        //supplierId public property
        public Int32 SupplierId
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierId;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierId = value;
            }
        }

        //private data member for the deliveryDate property
        private DateTime mDeliveryDate;
        //deliveryDate public property
        public DateTime DeliveryDate
        {
            get
            {
                //this line of code sends data out of the property
                return mDeliveryDate;
            }
            set
            {
                //this line of code allows data into the property
                mDeliveryDate = value;
            }
        }

        //private data member for the QuantityOrdered property
        private Int32 mQuantityOrdered;
        //QuantityOrdered public property
        public Int32 QuantityOrdered
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantityOrdered;
            }
            set
            {
                //this line of code allows data into the property
                mQuantityOrdered = value;
            }
        }

        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }

        //private data member for the QualityAssurance property
        private Boolean mQualityAssurance;
        //QualityAssurance public property
        public bool QualityAssurance
        {
            get
            {
                //this line of code sends data out of the property
                return mQualityAssurance;
            }
            set
            {
                //this line of code allows data into the property
                mQualityAssurance = value;
            }
        }

        //private data member for the post code property
        private string mPostCode;
        //post code public property
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into the property
                mPostCode = value;
            }
        }

        //private data member for the Address property
        private string mAddress;
        //Address public property
        public string Address
        {
            get
            {
                //this line of code sends data out of the property
                return mAddress;
            }
            set
            {
                //this line of code allows data into the property
                mAddress = value;
            }
        }

        //private data member for the ContactPhone property
        private string mContactPhone;
        //ContactPhone public property
        public string ContactPhone
        {
            get
            {
                //this line of code sends data out of the property
                return mContactPhone;
            }
            set
            {
                //this line of code allows data into the property
                mContactPhone = value;
            }
        }

        //private data member for the Email property
        private string mEmail;
        //Email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }

        //private data member for the post code property
        private string mCompanyName;
        //post code public property
        public string CompanyName
        {
            get
            {
                //this line of code sends data out of the property
                return mCompanyName;
            }
            set
            {
                //this line of code allows data into the property
                mCompanyName = value;
            }
        }

        public string Postcode { get; set; }

        public bool Find(int supplierId)
        {
            //set the private data members to the test data value
            mSupplierId = 21;
            mDeliveryDate = Convert.ToDateTime("23/12/2022");
            mQuantityOrdered = 67;
            mActive = true;
            mQualityAssurance = true;
            mPostCode = "le34pa";
            mAddress = "535 st saviours road";
            mContactPhone = "07865491211";
            mEmail = "sadjsa@gmail.com";
            mCompanyName = "ajsdjashd";
            //always return true
            return true;
        }





/*
        public bool Active { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int supplierId { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public int QuantityOrdered { get; set; }
        public bool QualityAssurance { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
       

      */
    }
}