namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birthD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthD", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "birthD");
        }
    }
}
