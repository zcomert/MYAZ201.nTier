using MYAZ201.nTier.Business.Utilities.Results;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MYAZ201.nTier.Business.Interfaces
{
    public interface IBookService : IService<Book>
    {
        IDataResult<List<Book>> GetBooksWithDetails(Expression<Func<Book, bool>> filter=null);
    }
}
