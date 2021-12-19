using MYAZ201.nTier.Business.Interfaces;
using MYAZ201.nTier.Business.Utilities.Results;
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

        public IResult Add(Book entity)
        {
            try
            {
                _bookDal.Add(entity);
                return Result.SuccessResult("The book has been added.");
            }
            catch (Exception ex)
            {
                return Result.ErrorResult(ex.Message);
            }
          
        }

        public IResult Delete(Book entity)
        {
            try
            {
                _bookDal.Delete(entity);
                return Result.SuccessResult("The book has been removed.");
            }
            catch (Exception ex)
            {
                return Result.ErrorResult(ex.Message);
            }
        }

        public IDataResult<Book> Get(Expression<Func<Book, bool>> filter)
        {
            Book data = null;
            try
            {
                data = _bookDal.Get(filter);
                return DataResult<Book>.SuccessDataResult(data, "The book has been read.");
            }
            catch (Exception ex)
            {
                return ErrorDataResult<Book>.ErrorDataResult(data, ex.Message);
            }
        }

        public IDataResult<List<Book>> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            List<Book> data = null;
            try
            {
                data = _bookDal.GetAll(filter);
                return DataResult<List<Book>>.SuccessDataResult(data, "The book list has been retrieved.");
            }
            catch (Exception ex)
            {
                return DataResult<List<Book>>.ErrorDataResult(data, ex.Message);
            }
        }

        public IResult Update(Book entity)
        {
            try
            {
                _bookDal.Update(entity);
                return Result.SuccessResult("The book has been updated.");
            }
            catch (Exception ex)
            {
                return Result.ErrorResult(ex.Message);
            }
        }
    }
}
