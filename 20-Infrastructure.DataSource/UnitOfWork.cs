using System;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity;
using Ch.TimeTweet.Infrastructure.DataSource.TimeTweet;

namespace Ch.TimeTweet.Infrastructure.DataSource
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private IRepository<TimeCard> _timeCard;
        private IRepository<Person> _person;
        private IRepository<Company> _company;
        private IContext _context;

        public UnitOfWork()
        {
            _context = new TimeTweetContext();
            _context.LazyLoadingEnabled = false;
        }

        public IRepository<Person> Person
        {
            get
            {
                if (_person == null)
                {
                    _person = new Repository<Person>(_context.SetIDbSet<Person>());
                }
                return _person;
            }
        }

        public IRepository<TimeCard> TimeCard
        {
            get
            {
                if (_timeCard == null)
                {
                    _timeCard = new Repository<TimeCard>(_context.SetIDbSet<TimeCard>());
                }
                return _timeCard;
            }
        }

        public IRepository<Company> Company
        {
            get
            {
                if (_company == null)
                {
                    _company = new Repository<Company>(_context.SetIDbSet<Company>());
                }
                return _company;
            }
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
    }
}
