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

        IEnumerable<T> Include<TProperty>(Expression<Func<T, IEnumerable<TProperty>>> predicate);
        IEnumerable<T> LoadRelation<TProperty>(Expression<Func<T, TProperty>> predicate) where TProperty : class;

        T First(Expression<Func<T, bool>> predicate);

        T FindById(int id);

        void Insert(T newEntity);
        void Delete(T entity);
    }
}
