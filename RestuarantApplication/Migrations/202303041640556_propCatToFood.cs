namespace RestuarantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propCatToFood : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Foods", "CategoryId");
            AddForeignKey("dbo.Foods", "CategoryId", "dbo.Categories", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Foods", new[] { "CategoryId" });
            DropColumn("dbo.Foods", "CategoryId");
        }
    }
}
