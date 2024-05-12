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

        public bool Find(int orderItemID)
        {
            mOrderItemID = 21;
            mOrderID = 21;
            mProductID = 21;
            mQuantity = 21;
            mProduct = "iphone 14";
            mOrderComplete = true;
            mTotalPrice = 16.81m;

            return true;
        }
    }
}