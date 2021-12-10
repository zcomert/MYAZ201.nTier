using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Entities;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class EfAuthorDal : EfBaseRepository<Author>, 
        IEntityRepository<Author>,
        IAuthorDal
    {

    }
}
