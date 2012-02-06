using System;
using Ch.TimeTweet.Domain.Entity;
using Ch.TimeTweet.Domain.Service;

namespace Ch.TimeTweet.Domain
{
    public interface IUnitOfWork
    {        
        void Rollback();
        void Commit();
    }
}
