using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Core.DataAccess
{
    public interface IRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>> filter=null);

        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}