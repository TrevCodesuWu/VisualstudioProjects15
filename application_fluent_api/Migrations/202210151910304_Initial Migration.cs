namespace application_fluent_api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dept",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        Ename = c.String(nullable: false, maxLength: 50, unicode: false),
                        Salary = c.Single(nullable: false),
                        Email = c.String(),
                        PrimaryContact = c.String(nullable: false, maxLength: 10),
                        SecondaryContact = c.String(),
                        DeptId = c.Int(nullable: false),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Teams", t => t.TeamId)
                .ForeignKey("dbo.Dept", t => t.DeptId, cascadeDelete: true)
                .Index(t => t.DeptId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.EmployeeAddresses",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        City = c.String(),
                        Zipcode = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjName = c.String(),
                        ProgLanguage = c.String(),
                        Database = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.ProjectOfEmployees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        ProjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.ProjectID })
                .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.ProjectID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptId", "dbo.Dept");
            DropForeignKey("dbo.Employees", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.ProjectOfEmployees", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.ProjectOfEmployees", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.EmployeeAddresses", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ProjectOfEmployees", new[] { "ProjectID" });
            DropIndex("dbo.ProjectOfEmployees", new[] { "EmployeeID" });
            DropIndex("dbo.EmployeeAddresses", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "TeamId" });
            DropIndex("dbo.Employees", new[] { "DeptId" });
            DropTable("dbo.ProjectOfEmployees");
            DropTable("dbo.Teams");
            DropTable("dbo.Projects");
            DropTable("dbo.EmployeeAddresses");
            DropTable("dbo.Employees");
            DropTable("dbo.Dept");
        }
    }
}
