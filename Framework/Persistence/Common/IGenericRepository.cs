using Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Persistence.Common
{
    public interface IGenericRepository<T> where T:IEntity, new()
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveAsyncById(int id);
    }
}
