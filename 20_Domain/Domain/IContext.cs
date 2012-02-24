using System.Data.Entity;
using Ch.TimeTweet.Domain.Entity;

namespace Ch.TimeTweet.Domain
{
    public interface IContext
    {
        bool LazyLoadingEnabled { set; }
        bool ProxyCreationEnabled { set; }
        IDbSet<TEntity> SetIDbSet<TEntity>() where TEntity : class, IEntity;
        void Commit();
        void IsModified<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void IsDeleted<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void IsAdded<TEntity>(TEntity entity) where TEntity : class, IEntity;
        // void DisposeContext();
    }
}
