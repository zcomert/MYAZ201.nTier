using MYAZ201.nTier.DAL.Abstract;
using MYAZ201.nTier.DAL.Entities;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class EfBookDetail : EfBaseRepository<BookDetail>,
        IEntityRepository<BookDetail>,
        IBookDetailDal
    {

    }
}
