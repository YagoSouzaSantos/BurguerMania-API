using Microsoft.AspNetCore.Mvc;
using BurguerMania_API.Services;
using BurguerMania_API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly CategoryService _service;

    public CategoriesController(CategoryService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<CategoryDto>> GetAllCategories()
    {
        return Ok(_service.GetAllCategories());
    }

    [HttpGet("{id}")]
    public ActionResult<CategoryDto> GetCategoryById(int id)
    {
        var category = _service.GetCategoryById(id);

        if (category == null)
        {
            return NotFound();
        }

        return Ok(category);
    }


    [HttpPost]
    public ActionResult<CategoryDto> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var category = _service.CreateCategory(createCategoryDto);
        return CreatedAtAction(nameof(GetAllCategories), new { id = category.Id }, category);
    }

    [HttpPut("{id}")]
    public ActionResult<CategoryDto> UpdateCategory(int id, [FromBody] UpdateCategoryDto updateCategoryDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updatedCategory = _service.UpdateCategory(id, updateCategoryDto);

        if (updatedCategory == null)
        {
            return NotFound(); // Categoria não encontrada
        }

        return Ok(updatedCategory);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteCategory(int id)
    {
        var result = _service.DeleteCategory(id);

        if (!result)
        {
            return NotFound(); // Categoria não encontrada
        }

        return NoContent(); // Retorna 204 No Content se a exclusão for bem-sucedida
    }


}
