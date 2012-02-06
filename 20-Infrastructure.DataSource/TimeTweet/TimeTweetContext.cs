using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Ch.TimeTweet.Domain.Entity;

namespace Ch.TimeTweet.Infrastructure.DataSource.TimeTweet
{
    public class TimeTweetContext : BaseContext
    {        
        static TimeTweetContext()
        {
            Database.SetInitializer<TimeTweetContext>(null);
            //Database.Delete(StringConstant.TimeTweetConnection);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TimeTweetContext>());            
        }
        
        public IDbSet<Company> Company { get; set; }
        public IDbSet<Person> Person { get; set; }
        public IDbSet<TimeCard> TimeCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }        
    }
}
