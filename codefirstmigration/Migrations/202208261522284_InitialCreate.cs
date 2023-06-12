namespace codefirstmigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.customers",
                c => new
                    {
                        cust_id = c.String(nullable: false, maxLength: 128),
                        cust_name = c.String(),
                        cust_address = c.String(),
                        cust_salary = c.String(),
                    })
                .PrimaryKey(t => t.cust_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.customers");
        }
    }
}
