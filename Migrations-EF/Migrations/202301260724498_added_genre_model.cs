namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_genre_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        genre_id = c.Int(nullable: false, identity: true),
                        genre_name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.genre_id);
            
            AddColumn("dbo.Movies", "Genre_id", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "Genre_id");
            AddForeignKey("dbo.Movies", "Genre_id", "dbo.Genres", "genre_id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genre_id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genre_id" });
            DropColumn("dbo.Movies", "Genre_id");
            DropTable("dbo.Genres");
        }
    }
}
