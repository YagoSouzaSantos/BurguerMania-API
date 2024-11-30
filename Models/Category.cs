using System.ComponentModel.DataAnnotations;

namespace BurguerMania_API.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ?Name { get; set; }

        [Required]
        public string ?Description { get; set; }

        [Required]
        public string ?Path_image { get; set; }
    }
}