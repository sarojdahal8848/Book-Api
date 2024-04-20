using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using simple_crud.Models;

namespace simple_crud.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book() { Id = 1, Name = "Basic of Physics", Price = 100, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new Book() { Id = 2, Name = "Chemistry of Nature", Price = 200, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new Book() { Id = 3, Name = "Computer Programming", Price = 300, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new Book() { Id = 4, Name = "Mathematics", Price = 150, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new Book() { Id = 5, Name = "Physics of Nature", Price = 250, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow}
            );
        }
    }
}