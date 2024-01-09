namespace Orders.Services.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public string UserName { get; set; }
        public int ProductPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalProce { get; set; }
    }
}
