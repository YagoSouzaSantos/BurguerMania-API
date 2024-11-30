using BurguerMania_API.DTOs;
using BurguerMania_API.Models;
using System.Collections.Generic;
using System.Linq;

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
                ProductId = op.ProductId, // Altere aqui
                Quantity = op.Quantity
            }).ToList()
        });
    }

    public OrderDto CreateOrder(CreateOrderDto createOrderDto)
    {
        var order = new Order
        {
            StatusId = 1, // Sempre inicia como "Pendente"
            Value = 0,
            OrderProducts = new List<OrderProduct>()
        };

        foreach (var productOrder in createOrderDto.Products)
        {
            var product = _productRepository.GetById(productOrder.ProductId);

            if (product == null)
            {
                throw new Exception($"Produto com ID '{productOrder.ProductId}' não encontrado.");
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
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                ProductId = op.ProductId, // Mantenha a consistência aqui também
                Quantity = op.Quantity
            }).ToList()
        };
    }
}
