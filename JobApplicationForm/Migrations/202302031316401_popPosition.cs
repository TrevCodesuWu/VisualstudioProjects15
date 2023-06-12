namespace JobApplicationForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popPosition : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Positions ON;");
            Sql("INSERT INTO Positions(id ,position ,pay ,durationMonths) VALUES (1,'Employee',5000,36)");
            Sql("INSERT INTO Positions(id ,position ,pay ,durationMonths) VALUES (2,'Part-Time',3500,24)");
            Sql("INSERT INTO Positions(id ,position ,pay ,durationMonths) VALUES (3,'Manager',8000,120)");
            Sql("INSERT INTO Positions(id ,position ,pay ,durationMonths) VALUES (4,'Supervisor',10000,60)");
            Sql("SET IDENTITY_INSERT Positions OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
