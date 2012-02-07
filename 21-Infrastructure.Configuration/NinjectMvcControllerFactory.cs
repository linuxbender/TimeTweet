using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ch.TimeTweet.CrossCutting.Common.Mapping;
using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;
using Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.MasterData;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock;
using Ninject;
using Ch.TimeTweet.Domain.Entity.TimeClock;

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

        //public override void ReleaseController(IController controller)
        //{                        
        //    var context = _ninjectKernel.Get<IContext>();
        //    var unitOfWork = _ninjectKernel.Get<IMasterDataUnitOfWork>();            

        //    unitOfWork.DisposeUnitOfWork();
        //    context.DisposeContext();

        //    Debug.WriteLine("context hashCode " + context.GetHashCode().ToString());
        //    Debug.WriteLine("unitOfWork hashCode " + unitOfWork.GetHashCode().ToString());            
        //    base.ReleaseController(controller);
        //}

        private void MvcConfiguration()
        {
            _ninjectKernel.Bind<IContext>().To<TimeTweetContext>().InRequestScope();            
            // UnitOfWork ID
            _ninjectKernel.Bind<IMasterDataUnitOfWork>()
                .To<MasterDataUnitOfWork>().InRequestScope()
                .WithConstructorArgument(ArgumentName.context, c => c.Kernel.Get<IContext>());

            _ninjectKernel.Bind<ITimeClockUnitOfWork>()
                .To<TimeClockUnitOfWork>().InRequestScope()
                .WithConstructorArgument(ArgumentName.context, c => c.Kernel.Get<IContext>());                

                         
            //_ninjectKernel.Bind<IRepository<Employee>>().To<Repository<Employee>>();
            //_ninjectKernel.Bind<IRepository<Company>>().To<Repository<Company>>();
            //_ninjectKernel.Bind<IRepository<Language>>().To<Repository<Language>>();
            //_ninjectKernel.Bind<IRepository<State>>().To<Repository<State>>();           
        }
    }
}
