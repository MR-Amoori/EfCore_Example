namespace EfCore_Sample.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<BookToCategories> BookToCategories { get; set; }
    }

    public class BookCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookToCategories> BookToCategories { get; set; }
    }

    public class BookToCategories
    {
        public int BookId { get; set; }
        public Book Book { get; set; }


        public int CategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
    }
}
