using System.ComponentModel.DataAnnotations;

namespace BurguerMania_API.DTOs
{
    public class UpdateCategoryDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Nome deve ter entre 1 e 100 caracteres.")]
        public required string Name { get; set; }

        [StringLength(500, ErrorMessage = "A Descrição deve ter no máximo 500 caracteres.")]
        public required string Description { get; set; }

        [Url(ErrorMessage = "O campo PathImage deve ser uma URL válida.")]
        [StringLength(200, ErrorMessage = "O PathImage deve ter no máximo 200 caracteres.")]
        public required string PathImage { get; set; }
    }
}
