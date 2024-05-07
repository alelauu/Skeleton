namespace ClassLibrary
{
    public class clsOrderLine
    {
        public bool OrderComplete { get; set; }
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string Product { get; set; }
        public decimal TotalPrice { get; set; }
    }
}