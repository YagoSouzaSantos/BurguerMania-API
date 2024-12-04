namespace BurguerMania_API.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PathImage { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? FullDescription { get; set; }
        public int CategoryId { get; set; }
    }
}
