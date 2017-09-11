using Microsoft.EntityFrameworkCore;
using SafeHavenAPI.Models;

namespace SafeHavenAPI.Data
{
    public class SafeHavenAPIContext : DbContext
    {
        public SafeHavenAPIContext(DbContextOptions<SafeHavenAPIContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
        public DbSet<AccessRight> AccessRight { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Image> Image { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

            modelBuilder.Entity<Image>()
                .Property(b => b.DateCreated)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }
}
