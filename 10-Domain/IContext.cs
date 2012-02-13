using System.Data.Entity;

namespace Ch.TimeTweet.Domain
{
    public interface IContext
    {
        bool LazyLoadingEnabled { set; }
        bool ProxyCreationEnabled { set; }
        IDbSet<TEntity> SetIDbSet<TEntity>() where TEntity : class, IEntity;
        void Commit();
        void isModified<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void isDeleted<TEntity>(TEntity entity) where TEntity : class, IEntity;
        void isAdded<TEntity>(TEntity entity) where TEntity : class, IEntity;
        // void DisposeContext();
    }
}
