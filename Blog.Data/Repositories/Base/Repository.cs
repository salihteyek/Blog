using Blog.Core.Data.Repositories;
using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        protected readonly DbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Remove(entity);
            });
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null) 
            { 
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties) 
                {
                    query = query.Include(item);
                } 
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _dbSet;
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }
            return await query.SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => 
            { 
                _dbSet.Update(entity); 
            });
        }
    }
}
