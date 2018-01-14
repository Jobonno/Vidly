namespace Vidly_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres (Id, Name) Values(1, 'Comedy')");
            Sql("Insert into Genres (Id, Name) Values(2, 'Action')");
            Sql("Insert into Genres (Id, Name) Values(3, 'Family')");
            Sql("Insert into Genres (Id, Name) Values(4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
