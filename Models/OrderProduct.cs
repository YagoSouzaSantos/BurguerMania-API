namespace BurguerMania_API.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; } // Foreign key referencing Product
        public Product? Product { get; set; }

        public int OrderId { get; set; } // Foreign key referencing Order
        public Order? Order { get; set; }

        public int Quantity { get; set; }
    }
}
