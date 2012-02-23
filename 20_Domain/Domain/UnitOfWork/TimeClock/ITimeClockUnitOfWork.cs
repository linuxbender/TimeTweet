using Ch.TimeTweet.Domain.Entity.TimeClock;

namespace Ch.TimeTweet.Domain.UnitOfWork.TimeClock
{
    public interface ITimeClockUnitOfWork : IUnitOfWork
    {
        IRepository<TimeCard> TimeClock { get; }
    }
}
