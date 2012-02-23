
namespace Ch.TimeTweet.Domain.Service.MasterData
{
    public interface ICompanyAppService<TEntity> where TEntity : class, IEntity
    {
        string DemoService();
    }
}
