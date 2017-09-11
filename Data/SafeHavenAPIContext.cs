using Microsoft.EntityFrameworkCore;
using SafeHavenAPI.Models;

namespace SafeHavenAPI.Data
{
    public class SafeHavenAPIContext : DbContext
    {
        public SafeHavenAPIContext(DbContextOptions<SafeHavenAPIContext> options)
            : base(options)
        { }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }
}
