namespace BurguerMania_API.Services;

using BurguerMania_API.DTOs;
using BurguerMania_API.Models;

public class CategoryService
{
    private readonly CategoryRepository _repository;

    public CategoryService(CategoryRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<CategoryDto> GetAllCategories()
    {
        return _repository.GetAll().Select(category => new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            Path_image = category.Path_image
        });
    }

    public CategoryDto CreateCategory(CreateCategoryDto createCategoryDto)
    {
        var category = new Category
        {
            Name = createCategoryDto.Name,
            Description = createCategoryDto.Description,
            Path_image = createCategoryDto.Path_image
        };

        _repository.Add(category);

        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            Path_image = category.Path_image
        };
    }
}
