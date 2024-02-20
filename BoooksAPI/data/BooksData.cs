using BookAPI.Model;

namespace BookAPI.data
{
    public class BooksData
    {
        public List<AuthorDto> Authors { get; set; }
        public static BooksData current = new BooksData();
        public BooksData()
        {
            Authors = new List<AuthorDto>() {
                new AuthorDto()
                {
                    Id = 1,
                    FirstName = "Jeff",
                    LastName = "Olson",
                    Books = new List<BookDto>()
                    {
                        new BookDto() {
                            Id = 1,
                            Title = "The slight Edge",
                            PublishDate = new DateOnly(2013, 11, 04),
                            Price = 24.50m,
                        },
                        new BookDto() {
                            Id = 2,
                            Title = "The Agile Manager's Guide to Getting Organized",
                            PublishDate = new DateOnly(1998, 01, 01),
                            Price = 22.50m,
                        }
                    }
                },
                new AuthorDto()
                {
                    Id = 2,
                    FirstName = "Charles",
                    LastName = "Duhigg",
                    Books = new List<BookDto>()
                    {
                        new BookDto() {
                            Id = 3,
                            Title = "Power Of Habits",
                            PublishDate = new DateOnly(2012, 02, 28),
                            Price = 23.50m,
                        },
                        new BookDto() {
                            Id = 4,
                            Title = "Supercommunicators",
                            PublishDate = new DateOnly(1998, 01, 01),
                            Price = 20.50m,
                        }
                    }
                },
                new AuthorDto()
                {
                    Id = 3,
                    FirstName = "James",
                    LastName = "Clear",
                    Books = new List<BookDto>()
                    {
                        new BookDto() {
                            Id = 5,
                            Title = "Atmic Habits",
                            PublishDate = new DateOnly(2018, 10, 16),
                            Price = 16.50m,
                        },
                        new BookDto() {
                            Id = 6,
                            Title = "Supercommunicators",
                            PublishDate = new DateOnly(2024, 02, 26),
                            Price = 20.98m,
                        }
                    }
                },

            };
        }
    }
}
