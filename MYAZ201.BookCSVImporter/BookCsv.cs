namespace MYAZ201.BookCSVImporter
{
    public class BookCsv
    {
        public string Title { get; set; }
        public string Author { get; set; }      // Author -> Fullname
        public string Description { get; set; } // BookDetail -> Description

        public int Year { get; set; }           // BookDetail -> Year
        public string Country { get; set; }     // BookDetail -> Country
        public string Language { get; set; }    // BookDetail -> Language
        public int NumberOfPage { get; set; }   // BookDetail -> NumberOfPage
        public string ImageURL { get; set; }
        public string Link { get; set; }        // BookDetail -> NumberOfPage

        public override string ToString()
        {
            return $"{Title} " +
                $"\n\t Year: {Year} " +
                $"\n\t Link: {Link}";
        }


    }
}
