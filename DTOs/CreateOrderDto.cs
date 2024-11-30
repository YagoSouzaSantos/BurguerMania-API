using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BurguerMania_API.DTOs
{
    public class CreateOrderDto
    {
        [Required]
        public List<ProductOrderDto>? Products { get; set; }

        public string? Notes { get; set; }
    }

    public class ProductOrderDto
    {
        [Required]
        public int ProductId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public int Quantity { get; set; }
    }
}
