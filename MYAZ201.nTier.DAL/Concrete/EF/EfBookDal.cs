using Microsoft.EntityFrameworkCore;
using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class EfBookDal : EfBaseRepository<Book>,
        IEntityRepository<Book>,
        IBookDal
    {
        public List<Book> GetBooksWithDetails(Expression<Func<Book, bool>> filter)
        {
            using (var _context = new nTierBookDbContext())
            {
                return filter == null ?
                     _context.Books.Include(b => b.BookDetail).ToList() :
                     _context.Books.Where(filter).ToList();
            }
        }
    }
}
