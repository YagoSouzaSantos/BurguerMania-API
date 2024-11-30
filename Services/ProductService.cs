using BurguerMania_API.DTOs;
using BurguerMania_API.Models;

public class ProductService
{
    private readonly ProductRepository _repository;

    public ProductService(ProductRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<ProductDto> GetAllProducts()
    {
        return _repository.GetAll().Select(product => new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            PathImage = product.PathImage,
            Price = product.Price,
            BaseDescription = product.BaseDescription,
            FullDescription = product.FullDescription,
            CategoryId = product.CategoryId
        });
    }

    public ProductDto CreateProduct(CreateProductDto createProductDto)
    {
        var product = new Product
        {
            Name = createProductDto.Name,
            PathImage = createProductDto.PathImage,
            Price = createProductDto.Price,
            BaseDescription = createProductDto.BaseDescription,
            FullDescription = createProductDto.FullDescription,
            CategoryId = createProductDto.CategoryId
        };

        _repository.Add(product);

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            PathImage = product.PathImage,
            Price = product.Price,
            BaseDescription = product.BaseDescription,
            FullDescription = product.FullDescription,
            CategoryId = product.CategoryId
        };
    }

    public ProductDto UpdateProduct(int id, CreateProductDto updateProductDto)
    {
        var product = _repository.GetById(id);
        if (product == null)
        {
            return null;
        }

        product.Name = updateProductDto.Name;
        product.PathImage = updateProductDto.PathImage;
        product.Price = updateProductDto.Price;
        product.BaseDescription = updateProductDto.BaseDescription;
        product.FullDescription = updateProductDto.FullDescription;
        product.CategoryId = updateProductDto.CategoryId;

        _repository.Update(product);

        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            PathImage = product.PathImage,
            Price = product.Price,
            BaseDescription = product.BaseDescription,
            FullDescription = product.FullDescription,
            CategoryId = product.CategoryId
        };
    }

    public bool DeleteProduct(int id)
    {
        var product = _repository.GetById(id);
        if (product == null)
        {
            return false;
        }

        _repository.Delete(id);
        return true;
    }
}
