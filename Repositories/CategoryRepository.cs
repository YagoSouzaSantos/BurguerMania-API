using BurguerMania_API.Data;
using BurguerMania_API.Models;

public class CategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> GetAll() => _context.Categories.ToList();

    public Category GetById(int id) => _context.Categories.Find(id);

    public void Add(Category category)
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }
}

