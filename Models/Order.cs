namespace BurguerMania_API.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int StatusId { get; set; }
        public Status? Status { get; set; }

        public float Value { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
