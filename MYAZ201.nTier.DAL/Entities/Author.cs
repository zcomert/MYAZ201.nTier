using System;
using System.Collections.Generic;

namespace MYAZ201.nTier.DAL.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => 
            string.Concat(FirstName," ", LastName);
        public DateTime CreatedDate { get; set; }

        // collection navigation propert
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
