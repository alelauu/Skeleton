using System;
using System.Collections.Generic;
using System.Data.Common;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private member data for thisOrder
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder OrderOne = new clsOrder();
                OrderOne.IsReturned = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsReturned"]);
                OrderOne.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                OrderOne.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                OrderOne.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                OrderOne.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                OrderOne.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                OrderOne.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                mOrderList.Add(OrderOne);
                Index++;
            }
        }

        //private data member for the list

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsReturned", mThisOrder.IsReturned);

            return DB.Execute("sproc_tblOrder_Insert");

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderStatus", mThisOrder.OrderStatus);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@IsReturned", mThisOrder.IsReturned);

            DB.Execute("sproc_tblOrder_Update");
        }
    }
}