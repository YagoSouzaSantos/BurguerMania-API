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

    public Order GetById(int id) => _context.Orders
        .Include(o => o.Status)
        .Include(o => o.OrderProducts)
        .ThenInclude(op => op.Product)
        .FirstOrDefault(o => o.Id == id);

    public void Add(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}
