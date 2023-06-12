namespace PracticeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON;");
            Sql("INSERT INTO Genres(id ,name)VALUES (1 ,'Storytelling')");
            Sql("INSERT INTO Genres(id ,name)VALUES (2 ,'Rolesplaying')");
            Sql("INSERT INTO Genres(id ,name)VALUES (3 ,'Open World')");
            Sql("INSERT INTO Genres(id ,name)VALUES (4 ,'Adventure')");
            Sql("SET IDENTITY_INSERT Genres ON;");

        }
        
        public override void Down()
        {
        }
    }
}
