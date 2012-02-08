using Ch.TimeTweet.Domain;
using Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet;
using Ninject;

namespace Ch.TimeTweet.Infrastructure.Configuration.Setup
{
    public class Context : IConfiguration
    {
        public IKernel _ninjectKernel { get; set; }

        public Context(IKernel ninjectKernel)
        {
            _ninjectKernel = ninjectKernel;            
        }        

        public void Initialization()
        {            
            // Set Context
            _ninjectKernel.Bind<IContext>().To<TimeTweetContext>().InRequestScope();
        }                
    }
}
