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

    [HttpGet("{id}")]
    public ActionResult<OrderDto> GetOrderById(int id)
    {
        var order = _service.GetOrderById(id);

        if (order == null)
        {
            return NotFound(); // Retorna 404 Not Found se o pedido não existir
        }

        return Ok(order); // Retorna 200 OK com os dados do pedido
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

    [HttpPut("{id}")]
    public ActionResult<OrderDto> UpdateOrder(int id, [FromBody] CreateOrderDto updateOrderDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var updatedOrder = _service.UpdateOrder(id, updateOrderDto);
            return Ok(updatedOrder);
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }


    [HttpDelete("{id}")]
    public ActionResult DeleteOrder(int id)
    {
        try
        {
            _service.DeleteOrder(id);
            return NoContent();
        }
        catch (KeyNotFoundException)
        {
            return NotFound();
        }
        catch (Exception ex)
        {
            return BadRequest(new { message = ex.Message });
        }
    }

}
