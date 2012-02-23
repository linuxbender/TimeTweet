using Ninject;

namespace Ch.TimeTweet.Infrastructure.Configuration.Setup
{
    public interface IConfiguration
    {
        IKernel _ninjectKernel { get; set; }

        void Initialization();
    }
}
