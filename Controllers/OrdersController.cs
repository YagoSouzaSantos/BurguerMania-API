using Microsoft.AspNetCore.Mvc;
using BurguerMania_API.Services;
using BurguerMania_API.DTOs;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly OrderService _service;

    public OrdersController(OrderService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<OrderDto>> GetAllOrders()
    {
        return Ok(_service.GetAllOrders());
    }

    [HttpPost]
    public ActionResult<OrderDto> CreateOrder([FromBody] CreateOrderDto createOrderDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var order = _service.CreateOrder(createOrderDto);
            return CreatedAtAction(nameof(GetAllOrders), new { id = order.Id }, order);
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }
}
