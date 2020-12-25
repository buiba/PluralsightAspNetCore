using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PluralsightAspNetCore.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies", Description = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit pies", Description = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fruit pies", Description = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Fruit pies", Description = "Fruit pies" });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 1,
                Name = "Apple Pie",
                Price = 12.95m,
                ShortDescription = "Our famous apple pies"
            },
            new Pie
            {
                PieId = 2,
                Name = "Apple Pie",
                Price = 12.95m,
                ShortDescription = "Our famous apple pies"
            },
            new Pie
            {
                PieId = 3,
                Name = "Apple Pie",
                Price = 12.95m,
                ShortDescription = "Our famous apple pies"
            },
            new Pie
            {
                PieId = 4,
                Name = "Apple Pie",
                Price = 12.95m,
                ShortDescription = "Our famous apple pies"
            }
            );
        }
    }
}
