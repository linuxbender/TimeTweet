using model = Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Database.Seed.MasterData
{
    public static class Employee
    {
        public static model.Employee[] Populate
        {
            get
            {
                return new model.Employee[]
                {
                    new model.Employee{ CompanyId = 1 ,FirstName = "Gregory", LastName = "House" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 2 ,FirstName = "Nina", LastName = "Dobrev" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 3 ,FirstName = "Jonathan", LastName = "Williamson"}.SetBaseEntity<model.Employee>()
                };
            }
        }
    }
}
