using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;

        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        private Int32 mCustomerID;

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        private DateTime mOrderDate;

        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }

        private String mOrderStatus;

        public String OrderStatus
        {
            get
            {
                return mOrderStatus;
            }
            set
            {
                mOrderStatus = value;
            }
        }

        private Boolean mIsReturned;

        public bool IsReturned
        {
            get
            {
                return mIsReturned;
            }
            set
            {
                mIsReturned = value;
            }
        }

        private Int32 mProductID;

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

        private Int32 mQuantity;

        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        //public bool IsReturned { get; set; }
        //public DateTime OrderDate { get; set; }
        //public int OrderID { get; set; }
        //public int CustomerID { get; set; }
        //public String OrderStatus { get; set; }
        //    public int ProductID { get; set; }
        //    public int Quantity { get; set; }

        public bool Find(int orderID)
        {
            mOrderID = 21;
            mCustomerID = 21;
            mProductID = 21;
            mQuantity = 21;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mOrderStatus = "processed";
            mIsReturned = true;
            //always return true 
            return true;
        }

        

    


    }
}
