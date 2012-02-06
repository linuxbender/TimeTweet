using System;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity.TimeClock;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;

namespace Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock
{
    public class TimeClockUnitOfWork : BaseUnitOfWork, ITimeClockUnitOfWork
    {
        private IRepository<TimeCard> _timeCard;        

        public TimeClockUnitOfWork(IContext context) : base( context)
        {

        }

        public IRepository<TimeCard> TimeClock
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
    }
}
