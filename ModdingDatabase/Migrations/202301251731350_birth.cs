namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "birth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "birth");
        }
    }
}
