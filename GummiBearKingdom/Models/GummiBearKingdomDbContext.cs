using System;
using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearKingdomDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public GummiBearKingdomDbContext()
        {
            
        }

        public GummiBearKingdomDbContext(DbContextOptions<GummiBearKingdomDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Port=8889;database=gummibearkingdom;uid=root;pwd=root;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}