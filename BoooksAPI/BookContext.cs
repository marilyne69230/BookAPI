using BooksAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BooksAPI
{
    public class BookContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Books;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var authors = new Author[]
            {
                new Author { AuthorId = 1, FirstName = "Aylan", LastName = "Naili" },
                new Author { AuthorId = 2, FirstName = "Jacque", LastName = "Sassi" },
                new Author { AuthorId = 3, FirstName = "Louis", LastName = "Pham" },
                new Author { AuthorId = 4, FirstName = "Pierre", LastName = "Madaci" },
                new Author { AuthorId = 5, FirstName = "Paul", LastName = "Pena" },
             };
            modelBuilder.Entity<Author>().HasData(authors);

            var books = new Book[]
            {
                new Book { BookId = 1, AuthorId = 1, Title = "Salut les copains", PublishDate = new DateOnly(1990,1,1), Price = 16.50m }
            };
            modelBuilder.Entity<Book>().HasData(books);
        }

    
    }
}
