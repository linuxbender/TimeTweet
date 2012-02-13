using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity.MasterData;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;

namespace Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.MasterData
{
    public class MasterDataUnitOfWork : BaseUnitOfWork, IMasterDataUnitOfWork
    {
        public MasterDataUnitOfWork(IContext context) : base(context)
        {
        }

        public IRepository<Company> Company { get; private set; }
        public IRepository<Employee> Employee { get; private set; }
        public IRepository<Language> Language { get; private set; }
        public IRepository<State> State { get; private set; }
        
        //public IRepository<Company> Company
        //{
        //    get 
        //    {
        //        if (_company == null)
        //        {
        //            _company = new Repository<Company>(_context.SetIDbSet<Company>());
        //        }
        //        return _company; 
        //    }
        //}        
    }
}
