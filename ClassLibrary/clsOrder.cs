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

    //public bool IsReturned { get; set; }
    //public DateTime OrderDate { get; set; }
    //public int OrderID { get; set; }
    //public int CustomerID { get; set; }
    //public String OrderStatus { get; set; }

        public bool Find(int orderID)
        {
            mOrderID = 21;
            mCustomerID = 21;
            mOrderDate = Convert.ToDateTime("23/12/2022");
            mOrderStatus = "processed";
            mIsReturned = true;
            //always return true 
            return true;
        }

        

    


    }
}
