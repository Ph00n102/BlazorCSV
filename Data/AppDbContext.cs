using BlazorTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BlazorTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}