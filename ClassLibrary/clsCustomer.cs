using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PostCode { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CustomerId { get; set; }
        public string StreetAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}