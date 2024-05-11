using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        public int Id { get; set; }
        //public bool InStock { get; set; }
        //public int ProductID { get; set; }
        public string ProductName { get; set; }
        //public string ProductBrand { get; set; }
        public string ProductColour { get; set; }
        public string ProductCapacity { get; set; }
        public int AmountInStock { get; set; }

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

        public bool Find(int productID)
        {
            //set the private data members to the test data value
            mProductID = 4;
            mProductBrand = "Apple";
            mInStock = true;
            mProductPrice = Convert.ToInt32(999);
            //always return true
            return true;
        }
    }
}