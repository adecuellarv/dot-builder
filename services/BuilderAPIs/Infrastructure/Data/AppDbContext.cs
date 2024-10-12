using BuilderAPIs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BuilderAPIs.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<FrameworkCategories> FrameworkCategories { get; set; }
        public DbSet<Frameworks> Frameworks { get; set; }
        public DbSet<Components> Components { get; set; }
        public DbSet<Items> Items { get; set; }
    }
}
