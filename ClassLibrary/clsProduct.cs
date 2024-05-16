using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int Id { get; set; }
        //public int ProductID { get; set; }
        //public string ProductName { get; set; }
        //public string ProductBrand { get; set; }
        //public string ProductColour { get; set; }
        //public string ProductCapacity { get; set; }
        //public bool InStock { get; set; }
        //private data member for the product id property
        private Int32 mProductID;


        //productid public property
        public Int32 ProductID 
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }

        private string mProductName;
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        private string mProductBrand;
        public string ProductBrand
        {
            get
            {
                return mProductBrand;
            }
            set
            {
                mProductBrand = value;
            }
        }

        private string mProductColour;
        public string ProductColour
        {
            get
            {
                return mProductColour;
            }
            set
            {
                mProductColour = value;
            }
        }

        private string mProductCapacity;
        public string ProductCapacity
        {
            get
            {
                return mProductCapacity;
            }
            set
            {
                mProductCapacity = value;
            }
        }

        private Boolean mInStock;
        public Boolean InStock
        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }

        private decimal mProductPrice;
        public decimal ProductPrice
        {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public bool Find(int productID)
        { 
            /*
            //set the private data members to the test data value
            mProductID = 4;
            mProductBrand = "Apple";
            mInStock = true;
            mProductPrice = Convert.ToInt32(999);
            //always return true
            return true;
            */
            
            //creating an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for
            DB.AddParameter("@ProductID", productID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductBrand = Convert.ToString(DB.DataTable.Rows[0]["ProductBrand"]);
                mProductColour = Convert.ToString(DB.DataTable.Rows[0]["ProductColour"]);
                mProductCapacity = Convert.ToString(DB.DataTable.Rows[0]["ProductCapacity"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
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
        
        public String Valid(string productName, string productBrand, string productColour, string productCapacity, double productPrice, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the productName is blank
            if (productName.Length == 0)
            {
                //record the error
                Error = Error + "The product name may not be blank : ";

            }
            if (productName.Length > 30)
            {
                Error = Error + "The product name must be less than 30 characters : ";
            }

            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (productBrand.Length == 0)
            {
                //record the error
                Error = Error + "The product brand may not be blank : ";

            }
            if (productBrand.Length > 15)
            {
                Error = Error + "The product brand must be less than 15 characters : ";
            }

            if (productColour.Length == 0)
            {
                //record the error
                Error = Error + "The product colour may not be blank : ";

            }
            if (productColour.Length > 20)
            {
                Error = Error + "The product colour must be less than 20 characters : ";
            }

            if (productCapacity.Length == 0)
            {
                //record the error
                Error = Error + "The product capacity may not be blank : ";

            }
            if (productCapacity.Length > 5)
            {
                Error = Error + "The product colour must be less than 5 characters : ";
            }
            return Error;
        }
    }
}