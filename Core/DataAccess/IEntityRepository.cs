﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity
    {
        //Standart entity operations.
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetList(Expression<Func<T, bool>>? expression = null);
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>>? expression = null);
        T Get(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        IQueryable<T> Query();
        int GetCount(Expression<Func<T, bool>>? expression = null);
        Task<int> GetCountAsync(Expression<Func<T, bool>>? expression = null);
        Task<int> Execute(FormattableString interpolatedQueryString);
    }
}
