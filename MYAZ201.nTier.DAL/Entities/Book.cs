using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.DAL.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        // navigation property
        public BookDetail BookDetail { get; set; }
        // FK
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
