using Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Domain.UnitOfWork.MasterData
{
    public interface IMasterDataUnitOfWork : IUnitOfWork
    {
        IRepository<Company> Company { get; }
        IRepository<Employee> Employee { get; }
        IRepository<Language> Language { get; }
        IRepository<State> State { get; }
    }
}
