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
            PathImage = category.PathImage
        });
    }

    public CategoryDto CreateCategory(CreateCategoryDto createCategoryDto)
    {
        var category = new Category
        {
            Name = createCategoryDto.Name,
            Description = createCategoryDto.Description,
            PathImage = createCategoryDto.PathImage
        };

        _repository.Add(category);

        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            PathImage = category.PathImage
        };
    }

    public CategoryDto GetCategoryById(int id)
    {
        var category = _repository.GetById(id);

        if (category == null)
        {
            return null; // Categoria não encontrada
        }

        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            PathImage = category.PathImage
        };
    }

    public CategoryDto UpdateCategory(int id, UpdateCategoryDto updateCategoryDto)
    {
        var category = _repository.GetById(id);
        if (category == null)
        {
            return null;
        }

        category.Name = updateCategoryDto.Name;
        category.Description = updateCategoryDto.Description;
        category.PathImage = updateCategoryDto.PathImage;

        _repository.Update(category);

        return new CategoryDto
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            PathImage = category.PathImage
        };
    }
    public bool DeleteCategory(int id)
    {
        var category = _repository.GetById(id);
        if (category == null)
        {
            return false;
        }

        _repository.Delete(id);
        return true;
    }

}
