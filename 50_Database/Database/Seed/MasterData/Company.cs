using model = Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Database.Seed.MasterData
{
    public static class Company
    {
        public static model.Company[] Populate
        {
            get
            {
                return new model.Company[]
                {
                    new model.Company{ Name = "TimeTweet", ShortName = "TT" }.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Company - 2012", ShortName = "Com12" }.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Company - 2011", ShortName = "Com11"}.SetBaseEntity<model.Company>()
                };
            }
        }
    }
}
