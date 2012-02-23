using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ch.TimeTweet.Domain.Entity.MasterData;
using Ch.TimeTweet.Domain.Entity.TimeClock;

namespace Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet
{
    public class TimeTweetContext : BaseContext
    {        
        static TimeTweetContext()
        {
            Database.SetInitializer<TimeTweetContext>(null);
            // No Need - using Migration EF 4.3
            //Database.Delete(StringConstant.TimeTweetConnection);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TimeTweetContext>());                       
        }
        
        public IDbSet<Company> Company { get; set; }
        public IDbSet<Employee> Employee { get; set; }
        public IDbSet<TimeCard> TimeCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {                        
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }        
    }
}
