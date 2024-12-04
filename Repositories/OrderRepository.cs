using BurguerMania_API.Data;
using BurguerMania_API.Models;
using Microsoft.EntityFrameworkCore;

public class OrderRepository
{
    private readonly ApplicationDbContext _context;

    public OrderRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Order> GetAll() => _context.Orders
        .Include(o => o.Status)
        .Include(o => o.OrderProducts)
        .ThenInclude(op => op.Product)
        .ToList();

    public Order? GetOrderById(int id) => _context.Orders
        .Include(o => o.Status)
        .Include(o => o.OrderProducts)
        .ThenInclude(op => op.Product)
        .FirstOrDefault(o => o.Id == id);

    public Product? GetProductById(int id) => _context.Products.Find(id);

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }

    public void Delete(Order order)
    {
        _context.Orders.Remove(order);
        _context.SaveChanges();
    }

    public void Update(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }


}
