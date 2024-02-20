using BookAPI.Model;

namespace BookAPI.Model
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<BookDto> Books { get; set; } = new List<BookDto>();
    }
}
