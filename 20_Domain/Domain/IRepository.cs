using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ch.TimeTweet.Domain
{
    public interface IRepository<T> where T :class
    {
        IQueryable<T> AsQueryable();

        IEnumerable<T> SelectAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        IEnumerable<T> EagerLoad<TProperty>(Expression<Func<T, TProperty>> path);
        IEnumerable<T> EagerDeepLoad<TProperty>(Expression<Func<T, TProperty>> path);

        T First(Expression<Func<T, bool>> predicate);

        T FindById(int id);

        void Update(T entity);

        void Insert(T newEntity);

        void Delete(T entity);
    }
}
