using Ch.TimeTweet.CrossCutting.Common.Mapping;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.Entity.MasterData;
using Ch.TimeTweet.Domain.Entity.TimeClock;
using Ch.TimeTweet.Infrastructure.DataSource;
using Ninject;

namespace Ch.TimeTweet.Infrastructure.Configuration.Setup
{
    public class Repository : IConfiguration
    {
        public IKernel _ninjectKernel { get; set; }

        public Repository(IKernel ninjectKernel)
        {
            _ninjectKernel = ninjectKernel;            
        }  

        public void Initialization()
        {
            // Set Repository
            _ninjectKernel.Bind<IRepository<Company>>()
                .To<Repository<Company>>().InRequestScope()
                .WithConstructorArgument(ArgumentName.objectSet, c => c.Kernel.Get<IContext>().SetIDbSet<Company>());

            _ninjectKernel.Bind<IRepository<Employee>>()
                .To<Repository<Employee>>().InRequestScope()
                .WithConstructorArgument(ArgumentName.objectSet, c => c.Kernel.Get<IContext>().SetIDbSet<Employee>());

            _ninjectKernel.Bind<IRepository<Language>>()
                .To<Repository<Language>>().InRequestScope()
                .WithConstructorArgument(ArgumentName.objectSet, c => c.Kernel.Get<IContext>().SetIDbSet<Language>());

            _ninjectKernel.Bind<IRepository<State>>()
                .To<Repository<State>>().InRequestScope()
                .WithConstructorArgument(ArgumentName.objectSet, c => c.Kernel.Get<IContext>().SetIDbSet<State>());

            _ninjectKernel.Bind<IRepository<TimeCard>>()
                .To<Repository<TimeCard>>().InRequestScope()
                .WithConstructorArgument(ArgumentName.objectSet, c => c.Kernel.Get<IContext>().SetIDbSet<TimeCard>());
        }
    }
}
