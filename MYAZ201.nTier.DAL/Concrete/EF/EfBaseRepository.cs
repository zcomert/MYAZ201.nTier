using Microsoft.EntityFrameworkCore;
using MYAZ201.nTier.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class EfBaseRepository<T> : IEntityRepository<T>
        where T : class, new()
    {
        public void Add(T entity)
        {
            using (var _context = new nTierBookDbContext())
            {
                _context.Entry(entity).State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new nTierBookDbContext())
            {
                _context.Entry(entity).State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (var _context = new nTierBookDbContext())
            {
                return _context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (var _context = new nTierBookDbContext())
            {
                return filter==null ? 
                    _context.Set<T>().ToList() :
                    _context.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new nTierBookDbContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
