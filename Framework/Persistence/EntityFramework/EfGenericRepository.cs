using Framework.Entities;
using Framework.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace Framework.Persistence.EntityFramework
{
    public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity>
        where TEntity :BaseEntity,IEntity, new()
        where TContext : DbContext, new()
    {
        private TContext CreateContext()=>new TContext();

        public async Task AddAsync(TEntity entity)
        {
            using (var context = CreateContext())
            {
                await context.AddAsync(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            using(var context = CreateContext())
            {
                return predicate == null ? 
                    await context.Set<TEntity>().AsNoTracking().ToListAsync(): 
                    await context.Set<TEntity>().AsNoTracking().Where(predicate).ToListAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using(var context = CreateContext())
            {
                return await context.Set<TEntity>().AsNoTracking().SingleOrDefaultAsync(filter);
            }
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using(var context = CreateContext())
            {
                context.Remove(entity);
                await context.SaveChangesAsync();
            }
        }

        public async Task RemoveAsyncById(int id)
        {
            using (var context = CreateContext())
            {
                var deletedEntity = await context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id ==id);
                await RemoveAsync(deletedEntity);
            }
            
        }

        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity);
                await context.SaveChangesAsync();
            }
        }
    }
}
