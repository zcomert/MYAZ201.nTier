using MYAZ201.nTier.Business.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.Business.Interfaces
{
    public interface IService<T>    
        where T : class, new()
    {
        IResult Add(T entity);
        IDataResult<List<T>> GetAll(Expression<Func<T, bool>> filter = null);
        IDataResult<T> Get(Expression<Func<T, bool>> filter);

        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
