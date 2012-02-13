﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Ch.TimeTweet.Domain;

namespace Ch.TimeTweet.Infrastructure.DataSource
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        private IContext _context;
        private IDbSet<TEntity> _objectSet;

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

        public IEnumerable<TEntity> Include<TProperty>(Expression<Func<TEntity, IEnumerable<TProperty>>> predicate)
        {
            return _objectSet.Where(t => t.Id > 0).Include(predicate);
        }

        public IEnumerable<TEntity> LoadRelation<TProperty>(Expression<Func<TEntity, TProperty>> predicate) where TProperty : class
        {
            return _objectSet.Where(t => t.Id > 0).Include(predicate);
        }

        public void Update(TEntity entity)
        {
            _objectSet.Attach(entity);
            _context.isModified<TEntity>(entity);
        }
    }
}