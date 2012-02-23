using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch.TimeTweet.Domain.Service.MasterData
{
    public interface ICompanyAppService<TEntity> where TEntity : class, IEntity
    {
        string DemoService();
    }
}
