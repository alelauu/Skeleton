using System;

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
        //public int AmountInStock { get; set; }
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

        private Int32 mAmountInStock;
        public Int32 AmountInStock
        {
            get
            {
                return mAmountInStock;
            }
            set
            {
                mAmountInStock = value;
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
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mAmountInStock = Convert.ToInt32(DB.DataTable.Rows[0]["AmountInStock"]);
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
    }
}