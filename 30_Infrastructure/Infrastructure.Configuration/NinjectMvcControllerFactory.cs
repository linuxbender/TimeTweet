using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ch.TimeTweet.CrossCutting.Common.Mapping;
using Ch.TimeTweet.Infrastructure.Configuration.Setup;
using Ninject;

namespace Ch.TimeTweet.Infrastructure.Configuration
{
    public class NinjectMvcControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectMvcControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            _ninjectKernel.Settings.InjectNonPublic = true;
            Setup();                   
        }

        private void Setup()
        {
            _ninjectKernel.Bind<IConfiguration>().To<Context>().InSingletonScope()
            .WithConstructorArgument(ArgumentName.ninjectKernel, _ninjectKernel);
            _ninjectKernel.Get<Context>().Initialization();

            _ninjectKernel.Bind<IConfiguration>().To<Repository>().InSingletonScope()
            .WithConstructorArgument(ArgumentName.ninjectKernel, _ninjectKernel);
            _ninjectKernel.Get<Repository>().Initialization();

            _ninjectKernel.Bind<IConfiguration>().To<UnitOfWork>().InSingletonScope()
            .WithConstructorArgument(ArgumentName.ninjectKernel, _ninjectKernel);
            _ninjectKernel.Get<UnitOfWork>().Initialization();                   
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
    }
}
