namespace CarShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class classClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        car_class = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Cars", "ClassId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "ClassId");
            AddForeignKey("dbo.Cars", "ClassId", "dbo.Classes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "ClassId", "dbo.Classes");
            DropIndex("dbo.Cars", new[] { "ClassId" });
            DropColumn("dbo.Cars", "ClassId");
            DropTable("dbo.Classes");
        }
    }
}
