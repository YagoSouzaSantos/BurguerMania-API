using BurguerMania_API.DTOs;
using BurguerMania_API.Models;

public class OrderService
{
    private readonly OrderRepository _orderRepository;
    private readonly ProductRepository _productRepository;

    public OrderService(OrderRepository orderRepository, ProductRepository productRepository)
    {
        _orderRepository = orderRepository;
        _productRepository = productRepository;
    }

    public IEnumerable<OrderDto> GetAllOrders()
    {
        return _orderRepository.GetAll().Select(order => new OrderDto
        {
            Id = order.Id,
            Status = order.Status?.Name,
            Value = order.Value,
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                Product = op.Product?.Name,
                Quantity = op.Quantity
            }).ToList()
        });
    }

    public OrderDto CreateOrder(CreateOrderDto createOrderDto)
    {
        var order = new Order
        {
            StatusId = 1,
            Value = 0
        };

        foreach (var productOrder in createOrderDto.Products)
        {
            var product = _productRepository.GetAll()
                .FirstOrDefault(p => p.Name.ToLower() == productOrder.Product.ToLower());

            if (product == null)
            {
                throw new Exception($"Produto '{productOrder.Product}' não encontrado.");
            }

            order.Value += (float)(product.Price * productOrder.Quantity);


            order.OrderProducts.Add(new OrderProduct
            {
                ProductId = product.Id,
                Quantity = productOrder.Quantity
            });
        }

        _orderRepository.Add(order);

        return new OrderDto
        {
            Id = order.Id,
            Status = "Pendente",
            Value = order.Value,
            Products = createOrderDto.Products
        };
    }
}
