namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class empage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "emp_age", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "emp_age");
        }
    }
}
