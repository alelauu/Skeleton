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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("SupplierId", supplierId);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterByAddressId");
            //if one record is found (there should be either one ore zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private members
                mSupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierId"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mQuantityOrdered = Convert.ToInt32(DB.DataTable.Rows[0]["QuantityOrdered"]);
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mQualityAssurance = Convert.ToBoolean(DB.DataTable.Rows[0]["QualityAssurance"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mContactPhone = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCompanyName = Convert.ToString(DB.DataTable.Rows[0]["CompanyName"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {

                //return false indicating there is a problem
                return false;
            }

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