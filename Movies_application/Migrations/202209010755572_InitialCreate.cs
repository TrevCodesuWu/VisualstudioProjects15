namespace Movies_application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customer_id = c.Int(nullable: false, identity: true),
                        customer_name = c.String(),
                        address = c.String(),
                        mobile_num = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.customer_id);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        movie_id = c.Int(nullable: false, identity: true),
                        movie_name = c.String(),
                        movie_duration = c.String(),
                        movie_age_restriction = c.String(),
                        movie_available = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.movie_id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        rent_id = c.Int(nullable: false, identity: true),
                        movie_id = c.Int(nullable: false),
                        customer_id = c.Int(nullable: false),
                        customer_name = c.String(),
                        retail_fee = c.Double(nullable: false),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.rent_id)
                .ForeignKey("dbo.Customers", t => t.customer_id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.movie_id, cascadeDelete: true)
                .Index(t => t.movie_id)
                .Index(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "movie_id", "dbo.Movies");
            DropForeignKey("dbo.Rents", "customer_id", "dbo.Customers");
            DropIndex("dbo.Rents", new[] { "customer_id" });
            DropIndex("dbo.Rents", new[] { "movie_id" });
            DropTable("dbo.Rents");
            DropTable("dbo.Movies");
            DropTable("dbo.Customers");
        }
    }
}
