namespace MYAZ201.nTier.DAL.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }
       
        
        public string ISSN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Year { get; set; }

        // FK : Unique
        public int BookId { get; set; }
        // Navigation property
        public Book Book { get; set; }

    }
}
