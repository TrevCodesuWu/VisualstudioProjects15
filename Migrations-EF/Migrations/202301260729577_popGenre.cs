namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON;");
            Sql("INSERT INTO Genres (genre_id , genre_name) VALUES (1,'Horror')");
            Sql("INSERT INTO Genres (genre_id , genre_name) VALUES (2,'Comedy')");
            Sql("INSERT INTO Genres (genre_id , genre_name) VALUES (3,'Documentary')");
            Sql("INSERT INTO Genres (genre_id , genre_name) VALUES (4,'Love')");
            Sql("INSERT INTO Genres (genre_id , genre_name) VALUES (5,'Sci-fi')");
            Sql("SET IDENTITY_INSERT Genres OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
