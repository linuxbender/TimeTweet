using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ch.TimeTweet.Domain.UnitOfWork.MasterData;
using Ch.TimeTweet.Domain.UnitOfWork.TimeClock;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.MasterData;
using Ch.TimeTweet.Infrastructure.DataSource.UnitOfWork.TimeClock;
using Ninject;

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
            _ninjectKernel.Bind<IMasterDataUnitOfWork>().To<MasterDataUnitOfWork>();
            _ninjectKernel.Bind<ITimeClockUnitOfWork>().To<TimeClockUnitOfWork>();
        }
    }
}
