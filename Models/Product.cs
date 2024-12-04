namespace BurguerMania_API.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        public string? PathImage { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public string? FullDescription { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
