using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity.TimeClock;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;

namespace Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock
{
    public class TimeClockUnitOfWork : BaseUnitOfWork, ITimeClockUnitOfWork
    {
        public TimeClockUnitOfWork(IContext context) : base( context)
        {

        }
        
        public IRepository<TimeCard> TimeClock {get; private set;}          
    }
}
