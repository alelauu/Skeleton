using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderItemID;

        public Int32 OrderItemID
        {
            get
            {
                return mOrderItemID;
            }
            set
            {
                mOrderItemID = value;
            }
        }

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

        private String mProduct;

        public String Product
        {
            get
            {
                return mProduct;
            }
            set
            {
                mProduct = value;
            }
        }

        private Boolean mOrderComplete;

        public bool OrderComplete
        {
            get
            {
                return mOrderComplete;
            }
            set
            {
                mOrderComplete = value;
            }
        }

        private decimal mTotalPrice;

        public decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }




        //    public bool OrderComplete { get; set; }
        //    public int OrderItemID { get; set; }
        //    public int OrderID { get; set; }
        //    public int ProductID { get; set; }
        //    public int Quantity { get; set; }
        //    public string Product { get; set; }
        //    public decimal TotalPrice { get; set; }

        /**** Find Method ****/
        public bool Find(int OrderItemID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order item id to search for 
            DB.AddParameter("@OrderItemID", OrderItemID);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderItemID");
            //if one record is found (there should either be one or zero
            if (DB.Count == 1)
            {
                mOrderItemID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderItemID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mProduct = Convert.ToString(DB.DataTable.Rows[0]["Product"]);
                mOrderComplete = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderComplete"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Total Price"]);
                //return everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }

        }
    }
}