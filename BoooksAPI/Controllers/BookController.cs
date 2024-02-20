using BookAPI.data;
using BookAPI.Model;
using BooksAPI;
using BooksAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Controllers
{
    [Route("api/Authors/{authorId}/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BookContext _context;

        public BooksController(BookContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetBooksByAuthor(int authorId)
        {
            var author = _context.Authors.Include(a => a.Books).FirstOrDefault(a => a.AuthorId == authorId);
            if (author == null)
            {
                return NotFound();
            }
            var books = new List<BookDto>();
            foreach(var b in author.Books)
            {
                var book = new BookDto() { Id = b.BookId, Title = b.Title, Price = b.Price, PublishDate = b.PublishDate };
            }
            return Ok(author.Books);
        }

        [HttpGet("{id}")]
        public ActionResult<BookDto> GetBookById(int authorId, int id)
        {
            var author = _context.Authors.Include(a=>a.Books).FirstOrDefault(a => a.AuthorId == authorId);
            if (author == null)
            {
                return NotFound();
            }

            var book = author.Books.FirstOrDefault(b => b.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(new BookDto { Id = book.BookId, Title= book.Title, Price = book.Price, PublishDate = book.PublishDate});
        }

        [HttpPost]
        public ActionResult<BookDto> AddBook(int authorId, BookDto book)
        {
            var author = _context.Authors.FirstOrDefault(a => a.AuthorId == authorId);
            if(author == null)
            {
                return NotFound();
            }
            var newbook = new Book() {Title = book.Title, Price = book.Price, PublishDate = book.PublishDate };
            author.Books.Add(newbook);
            _context.SaveChanges();
            return Ok(book);

        }

        [HttpPut("{id}")]
        public ActionResult<Book> EditBook(int authorId, int id, BookDto book)
        {

            var author = _context.Authors.Include(a => a.Books).FirstOrDefault(a => a.AuthorId == authorId);
            if (author == null)
            {
                return NotFound();
            }

            var index = author.Books.FindIndex(b => b.BookId == id);
            if (index == -1)
            {
                return NotFound();
            }
            author.Books[index] = new Book() { Title = book.Title, Price = book.Price, PublishDate = book.PublishDate };
            _context.SaveChanges();
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public ActionResult<string> DeleteBook(int authorId, int id)
        {
            var author = _context.Authors.Include(a => a.Books).FirstOrDefault(a => a.AuthorId == authorId);
            if (author == null)
            {
                return NotFound();
            }

            var index = author.Books.FindIndex(b => b.BookId == id);
            if (index == -1)
            {
                return NotFound();
            }
            author.Books.RemoveAt(index);
            _context.SaveChanges();
            return Ok("Livre supprimé");
        }

    }
}