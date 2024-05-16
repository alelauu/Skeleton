using System;
using System.Runtime.Remoting.Messaging;

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
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the order id to search for 
            DB.AddParameter("@OrderID", orderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            //if one record is found (there should either be one or zero)
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);
                mIsReturned = Convert.ToBoolean(DB.DataTable.Rows[0]["IsReturned"]);
                //return that everything worked OK
                return true;
            }
            //if not record was found
            else
            {
                return false;
            }
                
        }

 

    


    }
}
