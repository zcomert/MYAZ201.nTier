using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MYAZ201.nTier.DAL.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        List<Book> GetBooksWithDetails(Expression<Func<Book, bool>> filter);
    }
}

