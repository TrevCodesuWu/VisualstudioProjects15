namespace applicationMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvalidationforborrow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.borrows",
                c => new
                    {
                        borrow_Id = c.Int(nullable: false, identity: true),
                        borrower_name = c.String(),
                        borrower_age = c.String(),
                        borrower_hometown = c.String(),
                        cust_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.borrow_Id)
                .ForeignKey("dbo.customers", t => t.cust_Id, cascadeDelete: true)
                .Index(t => t.cust_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.borrows", "cust_Id", "dbo.customers");
            DropIndex("dbo.borrows", new[] { "cust_Id" });
            DropTable("dbo.borrows");
        }
    }
}
