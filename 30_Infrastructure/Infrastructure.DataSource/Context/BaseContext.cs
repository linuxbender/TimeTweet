﻿using System.Data;
using System.Data.Entity;
using Ch.TimeTweet.CrossCutting.Common.Constant;
using Ch.TimeTweet.Domain;

namespace Ch.TimeTweet.Infrastructure.DataSource.Context
{
    public abstract class BaseContext : DbContext, IContext
    {
        protected BaseContext(): base(StringConstant.TimeTweetConnection)
        {
           this.Configuration.LazyLoadingEnabled = false;           
        }

        public bool LazyLoadingEnabled
        {
            set { this.Configuration.LazyLoadingEnabled = value; }
        }

        public bool ProxyCreationEnabled
        {
            set { this.Configuration.ProxyCreationEnabled = value; }
        }

        public IDbSet<TEntity> SetIDbSet<TEntity>() where TEntity : class, IEntity
        {
            return this.Set<TEntity>();
        }

        public void Commit()
        {
            this.SaveChanges();
        }
        public void IsModified<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            this.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        public void IsDeleted<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            this.Entry<TEntity>(entity).State = EntityState.Deleted;
        }

        public void IsAdded<TEntity>(TEntity entity) where TEntity : class, IEntity
        {
            this.Entry<TEntity>(entity).State = EntityState.Added;
        }

        //public void DisposeContext()
        //{
        //    this.Dispose();
        //}       
    }
}
