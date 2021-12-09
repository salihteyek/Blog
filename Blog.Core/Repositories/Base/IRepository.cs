﻿using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Core.Data.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate, params Expression<Func<T,object>>[] includeProperties);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
    }
}
