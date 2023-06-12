namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class death : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "guessdeath", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "guessdeath");
        }
    }
}
