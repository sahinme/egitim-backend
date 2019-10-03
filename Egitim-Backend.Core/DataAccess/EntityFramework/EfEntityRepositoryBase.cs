using System.Linq;
using System.Threading.Tasks;
using Egitim_Backend.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Egitim_Backend.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {

        public IQueryable<TEntity> GetAll()
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>();
            }
        }
        public IQueryable<TEntity> Get(long id)
        {
            using (var context = new TContext())
            {
                return (IQueryable<TEntity>)context.Set<TEntity>().Find(id);

            }
        }

        public async Task AddAsync(TEntity entity)
        {
            using (var context=new TContext())
            {
                var addedEntity=  context.Entry(entity);
                addedEntity.State = EntityState.Added; 
                await context.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var context=new TContext())
            {
                var updatedEntity= context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            using (var context=new TContext())
            {
                var deletedEntity= context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }
    }
}