namespace BookAPI.Model
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public string Author { get; set; }
        public DateOnly PublishDate { get; set; }
        public Decimal Price { get; set; }


    }
}
