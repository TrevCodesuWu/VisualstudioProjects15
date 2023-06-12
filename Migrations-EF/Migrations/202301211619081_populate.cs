namespace Migrations_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MembershipTypes ON;");

            Sql("INSERT INTO MembershipTypes (Id ,durationInMonths, discount , signupfee)  VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id ,durationInMonths, discount , signupfee)  VALUES (2,1,10,30)");
            Sql("INSERT INTO MembershipTypes (Id ,durationInMonths, discount , signupfee)  VALUES (3,3,15,90)");
            Sql("INSERT INTO MembershipTypes (Id ,durationInMonths, discount , signupfee)  VALUES (4,12,20,300)");

            Sql("SET IDENTITY_INSERT MembershipTypes OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
