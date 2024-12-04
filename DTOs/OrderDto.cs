using System.Collections.Generic;

namespace BurguerMania_API.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
        public float Value { get; set; }
        public List<ProductOrderDto>? Products { get; set; }
    }
}
