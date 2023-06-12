namespace applicationMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.customers", "cust_age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.customers", "cust_age");
        }
    }
}
