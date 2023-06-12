namespace displaylistofcust.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingMember : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT MembershipTypes ON;");
            Sql("INSERT INTO MembershipTypes (Id , signupfee , durationInMonths , discount) VALUES (1 ,0 , 0 ,0)");
            Sql("INSERT INTO MembershipTypes (Id , signupfee , durationInMonths , discount) VALUES (2 ,30 , 1 ,10)");
            Sql("INSERT INTO MembershipTypes (Id , signupfee , durationInMonths , discount) VALUES (3 ,90 , 3 ,15)");
            Sql("INSERT INTO MembershipTypes (Id , signupfee , durationInMonths , discount) VALUES (4 ,300 , 12 ,20)");
            Sql("SET IDENTITY_INSERT MembershipTypes OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
