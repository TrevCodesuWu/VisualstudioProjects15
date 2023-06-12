namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class username : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "username");
        }
    }
}
