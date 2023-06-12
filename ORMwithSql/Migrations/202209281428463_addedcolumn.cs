namespace ORMwithSql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "available", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "available");
        }
    }
}
