using BurguerMania_API.Data;
using BurguerMania_API.Models;

public class UserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAll() => _context.Users.ToList();

    public User GetById(int id) => _context.Users.Find(id);

    public void Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}

