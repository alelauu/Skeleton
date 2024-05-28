using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public bool Active { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SupplierId { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public int QuantityOrdered { get; set; }
        public bool QualityAssurance { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
    }
}