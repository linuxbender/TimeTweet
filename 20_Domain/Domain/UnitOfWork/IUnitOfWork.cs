using System;

namespace Ch.TimeTweet.Domain.UnitOfWork
{
    public interface IUnitOfWork // : IDisposable
    {    	
        void Rollback();
        void Commit();
        // void DisposeUnitOfWork();
    }
}
