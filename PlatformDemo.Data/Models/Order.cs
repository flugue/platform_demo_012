namespace PlatformDemo.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
