using Microsoft.AspNetCore.Mvc;
using BurguerMania_API.Services;
using BurguerMania_API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductService _service;

    public ProductsController(ProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ProductDto>> GetAllProducts()
    {
        return Ok(_service.GetAllProducts());
    }

    [HttpGet("{id}")]
    public ActionResult<ProductDto> GetProductById(int id)
    {
        var product = _service.GetProductById(id);

        if (product == null)
        {
            return NotFound(); // Produto não encontrado
        }

        return Ok(product); // Retorna o produto encontrado
    }

    [HttpGet("category/{categoryId}")]
    public ActionResult<IEnumerable<ProductDto>> GetProductsByCategoryId(int categoryId)
    {
        var products = _service.GetProductsByCategoryId(categoryId);

        if (!products.Any())
        {
            return NotFound(); // Nenhum produto encontrado para a categoria
        }

        return Ok(products); // Retorna a lista de produtos da categoria
    }


    [HttpPost]
    public ActionResult<ProductDto> CreateProduct([FromBody] CreateProductDto createProductDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var product = _service.CreateProduct(createProductDto);
        return CreatedAtAction(nameof(GetAllProducts), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult<ProductDto> UpdateProduct(int id, [FromBody] CreateProductDto updateProductDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updatedProduct = _service.UpdateProduct(id, updateProductDto);
        if (updatedProduct == null)
        {
            return NotFound(); // Produto não encontrado
        }

        return Ok(updatedProduct);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        var result = _service.DeleteProduct(id);
        if (!result)
        {
            return NotFound(); // Produto não encontrado
        }

        return NoContent(); // Retorna 204 No Content se a exclusão for bem-sucedida
    }
}
