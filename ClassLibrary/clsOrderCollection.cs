using System;
using System.Collections.Generic;
using System.Data.Common;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
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
        List<clsOrder> mOrderList = new List<clsOrder>();
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
        public clsOrder ThisOrder { get; set; }
    }
}