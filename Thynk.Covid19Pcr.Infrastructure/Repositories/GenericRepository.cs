using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Thynk.Covid19Pcr.Application.Extensions;
using Thynk.Covid19Pcr.Application.Interfaces.Repositories;
using Thynk.Covid19Pcr.Infrastructure.DbContexts;

namespace Thynk.Covid19Pcr.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);

            return entity;
        }

        public IQueryable<T> FilterAsNoTracking(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dbSet.AsNoTracking();
            if (filter != null)
                query = query.Where(filter);

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty).AsNoTracking();
                }
            }
           
            return query;
        }

        public async Task<T> FirstOrDefaultInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = dbSet;

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }

            return await query.FirstOrDefaultAsync(filter);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return dbSet.FirstOrDefault(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await dbSet.FirstOrDefaultAsync(match);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).AsEnumerable<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsNoTracking(Expression<Func<T, bool>> keySelector)
        {
            return await dbSet.AsNoTracking().Where(keySelector).ToListAsync();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().AsEnumerable();
        }

        public IEnumerable<TEntity> SqlQuery<TEntity>(string sql, params object[] parameters) where TEntity : new()
        {
            return _context.Database.GetModelFromSqlQuery<TEntity>(sql, parameters);
        }
    }
}
