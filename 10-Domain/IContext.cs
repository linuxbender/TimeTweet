using System.Data.Entity;

namespace Ch.TimeTweet.Domain
{
    public interface IContext
    {
        bool LazyLoadingEnabled { set; }
        bool ProxyCreationEnabled { set; }
        IDbSet<TEntity> SetIDbSet<TEntity>() where TEntity : class, IEntity;
        void Commit();
        // void DisposeContext();
    }
}
