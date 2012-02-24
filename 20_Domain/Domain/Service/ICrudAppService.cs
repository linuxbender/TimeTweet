﻿using System.Collections.Generic;
using Ch.TimeTweet.Domain.Entity;

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
