namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "name", c => c.String());
        }
    }
}
