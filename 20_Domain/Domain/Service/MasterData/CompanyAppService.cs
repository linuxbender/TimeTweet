using System;

namespace Ch.TimeTweet.Domain.Service.MasterData
{
    public class CompanyAppService<TEntity> : ICompanyAppService<TEntity> where TEntity : class, IEntity
    {        
        public CompanyAppService(IRepository<TEntity> repo)
        {           
        }

        public string DemoService()
        {
            return String.Format("Hello World AppService");
        }
    }
}
