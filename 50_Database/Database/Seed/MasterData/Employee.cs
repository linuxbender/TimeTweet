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
                    new model.Employee{ CompanyId = 1 ,FirstName = "Jack", LastName = "Carter" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 1 ,FirstName = "Allison", LastName = "Blake" }.SetBaseEntity<model.Employee>(),                      
                    new model.Employee{ CompanyId = 5 ,FirstName = "Nina", LastName = "Dobrev" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 5 ,FirstName = "Beverly", LastName = "Barlow" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 6 ,FirstName = "Lexi", LastName = "Carter" }.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 3 ,FirstName = "Jonathan", LastName = "Williamson"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 4 ,FirstName = "Dexter", LastName = "Morgan"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 4 ,FirstName = "Rita", LastName = "Bennett"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 3 ,FirstName = "Joseph", LastName = "Quinn"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 3 ,FirstName = "Maria", LastName = "LaGuerta"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 3 ,FirstName = "Harry", LastName = "Morgan"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 2 ,FirstName = "Dean", LastName = "Winchester"}.SetBaseEntity<model.Employee>(),
                    new model.Employee{ CompanyId = 2 ,FirstName = "Sam", LastName = "Winchester"}.SetBaseEntity<model.Employee>()
                };
            }
        }
    }
}
