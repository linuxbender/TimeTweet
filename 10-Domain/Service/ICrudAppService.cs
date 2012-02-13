using System.Collections.Generic;

namespace Ch.TimeTweet.Domain.Service
{
    interface ICrudAppService<TEntity> where TEntity : class, IEntity
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> Read();
        TEntity ReadById(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
