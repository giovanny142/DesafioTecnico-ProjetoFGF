using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNove.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Nome)
                .HasMaxLength(60);

            modelBuilder.Entity<Product>()
                .Property(p => p.ean)
                .HasMaxLength(14);

            modelBuilder.Entity<Product>()
                .HasData(
                new Product { Id = 1, Nome = "JBL", ean = 123456 }
                );
        }
        
    }
}
