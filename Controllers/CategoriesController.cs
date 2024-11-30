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

    [HttpPost]
    public ActionResult<UserDto> CreateUser(CreateCategoryDto createCategoryDto)
    {
        var user = _service.CreateCategory(createCategoryDto);
        return CreatedAtAction(nameof(GetAllCategories), new { id = user.Id }, user);
    }
}
