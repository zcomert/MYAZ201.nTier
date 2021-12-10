namespace MYAZ201.nTier.DAL.Entities
{
    public class BookAuthor
    {
        public int BookAuthorId { get; set; }
        
        // FK
        public int BookId { get; set; }
        // Navigation property
        public Book Book { get; set; }

        // FK
        public int AuthorId { get; set; }
        // Navigation property
        public Author Author { get; set; }
    }
}
