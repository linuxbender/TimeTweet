using System.Data.Entity.Migrations;
using Ch.TimeTweet.Infrastructure.DataSource.Context.TimeTweet;

namespace Ch.TimeTweet.Database.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<TimeTweetContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(TimeTweetContext context)
        {
            context.Company.AddOrUpdate(
                 c => c.Name, Database.Seed.MasterData.Company.Populate);

            context.Employee.AddOrUpdate(
                 c => c.CompanyId, Database.Seed.MasterData.Employee.Populate);
        }
    }
}
//PARAMETER
//    -SourceMigration <String>
//        Only valid with -Script. Specifies the name of a particular migration to use
//        as the update's starting point. If ommitted, the last applied migration in
//        the database will be used.

//    -TargetMigration <String>
//        Specifies the name of a particular migration to update the database to. If
//        ommitted, the current model will be used.

//    -Script [<SwitchParameter>]
//        Generate a SQL script rather than executing the pending changes directly.

//    -Force [<SwitchParameter>]
//        Specifies that data loss is acceptable during automatic migration of the
//        database.

//    -ProjectName <String>
//        Specifies the project that contains the migration configuration type to be
//        used. If ommitted, the default project selected in package manager console
//        is used.

//    -StartUpProjectName <String>
//        Specifies the configuration file to use for named connection strings. If
//        omitted, the specified project's configuration file is used.

//    -ConfigurationTypeName <String>
//        Specifies the migrations configuration to use. If omitted, migrations will
//        attempt to locate a single migrations configuration type in the target
//        project.

//    -ConnectionStringName <String>
//        Specifies the name of a connection string to use from the application's
//        configuration file.

//    -ConnectionString <String>
//        Specifies the the connection string to use. If omitted, the context's
//        default connection will be used.

//    -ConnectionProviderName <String>
//        Specifies the provider invariant name of the connection string.

//    <CommonParameters>
//        Dieses Cmdlet unterstützt folgende allgemeine Parameter: "Verbose", "Debug",
//        "ErrorAction", "ErrorVariable", "WarningAction", "WarningVariable",
//        "OutBuffer" und "OutVariable". Weitere Informationen
//        erhalten Sie mit dem Befehl "get-help about_commonparameters".

// Code base run migration
//
//var configuration = new Configuration();
//var migrator = new DbMigrator(configuration);
//migrator.Update();

//HINWEISE
//    Zum Aufrufen der Beispiele geben Sie Folgendes ein: "get-help Update-Database -examples".
//    Weitere Informationen erhalten Sie mit folgendem Befehl: "get-help Update-Database -detailed".
//    Technische Informationen erhalten Sie mit folgendem Befehl: "get-help Update-Database -full".

// use the method Down()
// Update-Database -TargetMigration:AddShortName -StartUpProjectName Database -Force -Verbose

// init the method Up()
// Update-Database -StartUpProjectName Database
// Output:
// PM> Update-Database -StartUpProjectName Database
// Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
// No pending explicit migrations.
// Applying automatic migration: 201202232046177_AutomaticMigration.


// rerun after you change the entity - code first - you will see the changes in your script
// Add-Migration 201202232111259_AddCompanyClass -StartUpProjectName Database -Force
// Update-Database -TargetMigration:201202232126348_AddCompanyClass -StartUpProjectName Database -Force -Verbose
