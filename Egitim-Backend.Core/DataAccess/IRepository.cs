using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Egitim_Backend.Core.Entities;

namespace Egitim_Backend.Core.DataAccess
{
    public interface IRepository<T> where T:class,IEntity,new()
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(long id);

        Task AddAsync(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}