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
            Notes = order.Notes,
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                ProductId = op.ProductId,
                Quantity = op.Quantity
            }).ToList()
        });
    }

    public OrderDto GetOrderById(int id)
    {
        var order = _orderRepository.GetOrderById(id);
        if (order == null)
        {
            throw new KeyNotFoundException("Pedido não encontrado.");
        }

        return new OrderDto
        {
            Id = order.Id,
            Status = order.Status?.Name,
            Value = order.Value,
            Notes = order.Notes,
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                ProductId = op.ProductId,
                Quantity = op.Quantity
            }).ToList()
        };
    }

    public OrderDto CreateOrder(CreateOrderDto createOrderDto)
    {
        if (createOrderDto.Products == null || !createOrderDto.Products.Any())
        {
            throw new ArgumentException("A lista de produtos não pode estar vazia.");
        }

        var order = new Order
        {
            StatusId = 1, // Sempre inicia como "Pendente"
            Value = 0,
            Notes = createOrderDto.Notes,
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
            Notes = order.Notes,
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                ProductId = op.ProductId,
                Quantity = op.Quantity
            }).ToList()
        };
    }


    public void DeleteOrder(int id)
    {
        var order = _orderRepository.GetOrderById(id);
        if (order == null)
        {
            throw new KeyNotFoundException("Pedido não encontrado.");
        }
        _orderRepository.Delete(order);
    }

    public OrderDto UpdateOrder(int id, CreateOrderDto updateOrderDto)
    {
        var order = _orderRepository.GetOrderById(id);
        if (order == null)
        {
            throw new KeyNotFoundException("Pedido não encontrado.");
        }

        _orderRepository.Update(order);

        return new OrderDto
        {
            Id = order.Id,
            Status = order.Status?.Name,
            Value = order.Value,
            Notes = order.Notes,
            Products = order.OrderProducts.Select(op => new ProductOrderDto
            {
                ProductId = op.ProductId,
                Quantity = op.Quantity
            }).ToList()
        };
    }

}
