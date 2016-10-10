using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace RepositoryPattern.BasicExample
{
    public interface IRepository<T> where T : EntityBase
    {
        T GetById(int id);
        IQueryable<T> List();
        IQueryable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}