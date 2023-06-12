namespace PracticeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popMoreGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON;");
            Sql("INSERT INTO Genres(id ,name)VALUES (5 ,'18+')");
            Sql("INSERT INTO Genres(id ,name)VALUES (6 ,'Adult')");
            Sql("SET IDENTITY_INSERT Genres OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
