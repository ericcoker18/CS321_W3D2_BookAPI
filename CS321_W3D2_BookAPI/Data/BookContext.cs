using System;
using CS321_W3D2_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace CS321_W3D2_BookAPI.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        // TODO: implement a DbSet<Author> property
        public DbSet<Author> Authors { get; set; }

        // This method runs once when the DbContext is first used.
        public BookContext(DbContextOptions options) : base(options)
        {
            
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

        // This method runs once when the DbContext is first used.
        // It's a place where we can customize how EF Core maps our
        // model to the database. 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { id = 1, FirstName = "john", LastName = "Steinback", BirthDate = new DateTime(1902, 2, 27) });
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Grapes", AuthorId = 1 });




            base.OnModelCreating(modelBuilder);

            // TODO: configure some seed data in the authors table

            // TODO: configure some seed data in the books table

        }

    }
}

