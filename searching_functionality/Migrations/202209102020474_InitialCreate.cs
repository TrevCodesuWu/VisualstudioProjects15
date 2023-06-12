namespace searching_functionality.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        depart_id = c.String(nullable: false, maxLength: 128),
                        depart_name = c.String(),
                    })
                .PrimaryKey(t => t.depart_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employee_Id = c.Int(nullable: false, identity: true),
                        depart_name = c.String(),
                        Emp_name = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        F_name = c.String(nullable: false),
                        Department_depart_id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Employee_Id)
                .ForeignKey("dbo.Departments", t => t.Department_depart_id)
                .Index(t => t.Department_depart_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_depart_id", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_depart_id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
