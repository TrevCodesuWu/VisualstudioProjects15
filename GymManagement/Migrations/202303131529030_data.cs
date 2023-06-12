namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class data : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genders", "gender_name", c => c.String(nullable: false));
            AlterColumn("dbo.UserProfiles", "name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserProfiles", "name", c => c.String());
            AlterColumn("dbo.Genders", "gender_name", c => c.String());
        }
    }
}
