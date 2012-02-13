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

        //public IRepository<Employee> Employee
        //{
        //    get
        //    {
        //        if (_employee == null)
        //        {
        //            _employee = new Repository<Employee>(_context.SetIDbSet<Employee>());
        //        }
        //        return _employee;    
        //    }
        //}

        //public IRepository<Language> Language
        //{
        //    get
        //    {
        //        if (_Language == null)
        //        {
        //            _Language = new Repository<Language>(_context.SetIDbSet<Language>());
        //        }
        //        return _Language;
        //    }
        //}

        //public IRepository<State> State
        //{
        //    get
        //    {
        //        if (_state == null)
        //        {
        //            _state = new Repository<State>(_context.SetIDbSet<State>());
        //        }
        //        return _state;
        //    }
        //}                
    }
}
