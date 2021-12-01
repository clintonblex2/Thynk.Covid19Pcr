using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Thynk.Covid19Pcr.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsNoTracking(Expression<Func<T, bool>> keySelector);
        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        T Add(T entity);
        IQueryable<T> FilterAsNoTracking(
            Expression<Func<T, bool>> filter = null,
            params Expression<Func<T, object>>[] includeProperties);
        Task<T> FirstOrDefaultInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties);
        IEnumerable<TEntity> SqlQuery<TEntity>(String sql, params object[] parameters) where TEntity : new();
    }
}
