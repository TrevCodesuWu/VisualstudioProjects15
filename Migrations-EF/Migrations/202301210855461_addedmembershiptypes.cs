namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmembershiptypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        durationInMonths = c.Int(nullable: false),
                        discount = c.Int(nullable: false),
                        signupfee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "MembershipTypesId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypesId");
            AddForeignKey("dbo.Customers", "MembershipTypesId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypesId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypesId" });
            DropColumn("dbo.Customers", "MembershipTypesId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
