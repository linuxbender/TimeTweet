using Ch.TimeTweet.CrossCutting.Common.Mapping;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity.MasterData;
using Ch.TimeTweet.Domain.Entity.TimeClock;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;
using Ch.TimeTweet.Infrastructure.DataSource;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.MasterData;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock;
using Ninject;
using Ninject.Parameters;

namespace Ch.TimeTweet.Infrastructure.Configuration.Setup
{
    public class UnitOfWork :IConfiguration
    {
        public IKernel _ninjectKernel { get; set; }

        public UnitOfWork(IKernel ninjectKernel)
        {
            _ninjectKernel = ninjectKernel;            
        }     

        public void Initialization()
        {
            // Set UnitOfWork MasterData
            _ninjectKernel.Bind<IMasterDataUnitOfWork>()
                .To<MasterDataUnitOfWork>().InRequestScope()
                .WithConstructorArgument(ArgumentName.context, c => c.Kernel.Get<IContext>())
                .WithParameter(new PropertyValue(PropertyName.Employee, c => c.Kernel.Get<Repository<Employee>>()))
                .WithParameter(new PropertyValue(PropertyName.Company, c => c.Kernel.Get<Repository<Company>>()))
                .WithParameter(new PropertyValue(PropertyName.Language, c => c.Kernel.Get<Repository<Language>>()))
                .WithParameter(new PropertyValue(PropertyName.State, c => c.Kernel.Get<Repository<State>>()));

            // Set UnitOfWork TimeClock
            _ninjectKernel.Bind<ITimeClockUnitOfWork>()
                .To<TimeClockUnitOfWork>().InRequestScope()
                .WithConstructorArgument(ArgumentName.context, c => c.Kernel.Get<IContext>())
                .WithParameter(new PropertyValue(PropertyName.TimeCard, c => c.Kernel.Get<Repository<TimeCard>>()));                     
        }
    }
}
