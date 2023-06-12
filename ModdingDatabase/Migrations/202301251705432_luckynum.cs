namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class luckynum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "luckynum", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "luckynum");
        }
    }
}
