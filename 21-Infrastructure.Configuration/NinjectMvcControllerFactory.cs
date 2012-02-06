using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.MasterData;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock;
using Ninject;
using Ch.TimeTweet.Infrastructure.DataSource;
using Ch.TimeTweet.Domain.Entity.MasterData;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet;
using System.Data.Entity;
using Ch.TimeTweet.Domain.Entity.TimeClock;
using Ch.TimeTweet.CrossCutting.Common.Mapping;

namespace Ch.TimeTweet.Infrastructure.Configuration
{
    public class NinjectMvcControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectMvcControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            MvcConfiguration();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {            
            return controllerType == null ? null : _ninjectKernel.Get(controllerType) as IController;
        }

        public override void ReleaseController(IController controller)
        {
            _ninjectKernel.Dispose();
            base.ReleaseController(controller);
        }

        private void MvcConfiguration()
        {
            //_ninjectKernel.Bind<IContext>().To<TimeTweetContext>();
            //_ninjectKernel.Bind<IDbSet<Company>>().To<DbSet<Company>>();
            //_ninjectKernel.Bind<IDbSet<Employee>>().To<DbSet<Employee>>();
            //_ninjectKernel.Bind<IDbSet<TimeCard>>().To<DbSet<TimeCard>>();

            _ninjectKernel.Bind<IMasterDataUnitOfWork>().To<MasterDataUnitOfWork>().WithConstructorArgument(ArgumentName.context, new TimeTweetContext());
            _ninjectKernel.Bind<ITimeClockUnitOfWork>().To<TimeClockUnitOfWork>().WithConstructorArgument(ArgumentName.context, new TimeTweetContext());

                         
            //_ninjectKernel.Bind<IRepository<Employee>>().To<Repository<Employee>>();
            //_ninjectKernel.Bind<IRepository<Company>>().To<Repository<Company>>();
            //_ninjectKernel.Bind<IRepository<Language>>().To<Repository<Language>>();
            //_ninjectKernel.Bind<IRepository<State>>().To<Repository<State>>();           
        }
    }
}
