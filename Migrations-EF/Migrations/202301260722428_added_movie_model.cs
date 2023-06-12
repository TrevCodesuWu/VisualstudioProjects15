namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_movie_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        movie_id = c.Int(nullable: false, identity: true),
                        movie_name = c.String(nullable: false, maxLength: 30),
                        duration_min = c.Int(nullable: false),
                        release_date = c.DateTime(nullable: false),
                        left_stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.movie_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
