using System.ComponentModel.DataAnnotations;

namespace BurguerMania_API.DTOs
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Nome deve ter entre 1 e 100 caracteres.")]
        public required string Name { get; set; }

        [StringLength(500, ErrorMessage = "A Descrição deve ter no máximo 500 caracteres.")]
        public required string Description { get; set; }

        [Url(ErrorMessage = "O campo PathImage deve ser uma URL válida.")]
        public required string PathImage { get; set; }
    }
}
