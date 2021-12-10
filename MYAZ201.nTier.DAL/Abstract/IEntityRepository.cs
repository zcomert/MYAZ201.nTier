﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T: class, new()
    {
        void Add(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);

        void Update(T entity);
        void Delete(T entity);
    }
}

