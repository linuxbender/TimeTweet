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
                    new model.Company{ Name = "Supernatural", ShortName = "SN" }.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Dexter Inc.", ShortName = "Dex"}.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Eureka Inc.", ShortName = "Eureka"}.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Breaking Bad", ShortName = "BB"}.SetBaseEntity<model.Company>(),
                    new model.Company{ Name = "Californication", ShortName = "CC Inc."}.SetBaseEntity<model.Company>()                    
                };
            }
        }
    }
}
