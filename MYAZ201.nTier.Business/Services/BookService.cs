using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business.Services
{
    public class BookService : IBookService
    {
        private readonly IBookDal _bookDal;

        public BookService(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book entity)
        {
            _bookDal.Add(entity);
        }

        public void Delete(Book entity)
        {
            _bookDal.Delete(entity);
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            return _bookDal.Get(filter);
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetAll(filter);
        }

        public void Update(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
