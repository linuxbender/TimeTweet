using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Ch.TimeTweet.Domain;

namespace Ch.TimeTweet.Infrastructure.DataSource
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly IContext _context;
        private readonly IDbSet<TEntity> _objectSet;

        public Repository(IContext context)
        {
            _context = context;
            _objectSet = context.SetIDbSet<TEntity>();
        }

        public Repository(IDbSet<TEntity> objectSet)
        {
            _objectSet = objectSet;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _objectSet.Where(predicate);
        }

        public TEntity FindById(int id)
        {
            return _objectSet.Single(t => t.Id == id && t.Id > 0);
        }

        public void Add(TEntity newEntity)
        {
            _objectSet.Add(newEntity);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return _objectSet.Where(t => t.Id > 0);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return _objectSet.Where(t => t.Id > 0);
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return _objectSet.First(predicate);
        }

        public void Insert(TEntity newEntity)
        {            
            _objectSet.Add(newEntity);
        }

        public void Delete(TEntity entity)
        {
            if(entity.Id != 0)
            _objectSet.Remove(entity);
        }

        public IEnumerable<TEntity> EagerLoad<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {            
            return _objectSet.Where(t => t.Id > 0).Include(path);            
        }

        public IEnumerable<TEntity> EagerDeepLoad<TProperty>(Expression<Func<TEntity, TProperty>> path)
        {
            return _objectSet.Where(t => t.Id > 0).Include(path);
            //_context.Entry<TEntity>().Reference(path).Load();
        }

        public void Update(TEntity entity)
        {
            _objectSet.Attach(entity);
            _context.IsModified<TEntity>(entity);
        }
    }
}