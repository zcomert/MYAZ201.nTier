using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Entities;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class EfBookDal : EfBaseRepository<Book>,
        IEntityRepository<Book>,
        IBookDal
    {

    }
}
