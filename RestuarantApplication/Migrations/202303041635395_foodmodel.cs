namespace RestuarantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foodmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        food_name = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        country = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Foods");
        }
    }
}
