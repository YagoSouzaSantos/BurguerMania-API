namespace BurguerMania_API.DTOs;
public class CategoryDto
{
    public int Id { get; set; }
    public string ?Name { get; set; }
    public string ?Description { get; set; }
    public string ?Path_image { get; set; }
}