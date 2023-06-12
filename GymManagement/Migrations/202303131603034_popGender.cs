namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popGender : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genders ON;");
            Sql("INSERT INTO Genders(id , gender_name) VALUES(1,'Male')");
            Sql("INSERT INTO Genders(id , gender_name) VALUES(2,'Female')");
            Sql("SET IDENTITY_INSERT Genders OFF;"); 
        }
        
        public override void Down()
        {
        }
    }
}
