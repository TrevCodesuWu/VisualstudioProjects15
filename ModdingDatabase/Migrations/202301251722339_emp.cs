namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class emp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        emp_id = c.Int(nullable: false, identity: true),
                        emp_name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.emp_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
