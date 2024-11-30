using BurguerMania_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public required DbSet<User> Users { get; set; }  
        public required DbSet<Category> Categories { get; set; }  
        public required DbSet<Product> Products { get; set; }  
        public required DbSet<Order> Orders { get; set; }  
        public required DbSet<OrderProduct> OrderProducts { get; set; }  
        public required DbSet<Status> Status { get; set; }  
    }
}
