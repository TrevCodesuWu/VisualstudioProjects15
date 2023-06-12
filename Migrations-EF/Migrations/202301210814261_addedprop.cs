namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "isSubscribedToNewsLetter", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "name", c => c.String());
            DropColumn("dbo.Customers", "isSubscribedToNewsLetter");
        }
    }
}
