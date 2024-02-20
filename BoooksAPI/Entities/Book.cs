using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BooksAPI.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        //public string Author { get; set; }
        public Author? Author { get; set; }
        public int AuthorId { get; set; }
        public DateOnly PublishDate { get; set; }
        public decimal Price { get; set; }
    }
}
