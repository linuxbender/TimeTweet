using System;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.UnitOfWork;
using Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet;

namespace Ch.TimeTweet.Infrastructure.DataSource
{
    public abstract class BaseUnitOfWork : IUnitOfWork
    {        
        protected readonly IContext _context;

        public BaseUnitOfWork(IContext context)
        {
            _context = context;            
            _context.LazyLoadingEnabled = false;
        }             

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _context.Commit();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.DisposeContext();
            }
            GC.SuppressFinalize(this);
        }

        public void DisposeUnitOfWork()
        {
            if (_context != null)
            {
                _context.DisposeContext();
                this.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
