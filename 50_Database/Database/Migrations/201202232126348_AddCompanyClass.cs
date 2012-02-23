using System.Data.Entity.Migrations;

namespace Ch.TimeTweet.Database.Migrations
{
    public partial class AddCompanyClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("Company", "ShortName", c => c.String(maxLength: 60));            
        }
        
        public override void Down()
        {            
            DropColumn("Company", "ShortName");
        }
    }
}
