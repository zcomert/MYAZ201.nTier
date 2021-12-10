using System.Collections.Generic;

namespace MYAZ201.nTier.DAL.Entities
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryName { get; set; }
        public string Description { get; set; }

        // collection navigation property
        public ICollection<Book> Books { get; set; }
    }
}
