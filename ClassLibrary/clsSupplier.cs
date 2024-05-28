using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SupplierId { get; set; }
        public int Postcode { get; set; }
        public string Address { get; set; }
    }
}