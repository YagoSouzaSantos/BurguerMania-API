using System.ComponentModel.DataAnnotations;

namespace BurguerMania_API.DTOs
{
    public class CreateProductDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Nome deve ter entre 1 e 100 caracteres.")]
        public string? Name { get; set; }

        [Url(ErrorMessage = "O campo PathImage deve ser uma URL válida.")]
        public string? PathImage { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Preço deve ser maior que zero.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A Descrição Básica é obrigatória.")]
        public string? Description { get; set; }

        public string? FullDescription { get; set; }

        [Required(ErrorMessage = "O campo CategoryId é obrigatório.")]
        public int CategoryId { get; set; }
    }
}
