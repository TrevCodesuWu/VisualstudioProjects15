namespace applicationMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedkeys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        cust_Id = c.Int(nullable: false, identity: true),
                        cust_name = c.String(),
                        cust_address = c.String(),
                        cust_member = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.cust_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
        }
    }
}
