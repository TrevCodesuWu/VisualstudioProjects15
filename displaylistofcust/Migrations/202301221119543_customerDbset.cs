namespace displaylistofcust.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerDbset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        customerName = c.String(),
                        customerAddress = c.String(),
                    })
                .PrimaryKey(t => t.customerID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
