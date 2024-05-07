using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public bool IsReturned { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string OrderStatus { get; set; }
    }
}