using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ch.TimeTweet.Domain.Entity.MasterData;

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
