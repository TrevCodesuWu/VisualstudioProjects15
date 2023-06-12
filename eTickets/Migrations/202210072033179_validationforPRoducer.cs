namespace eTickets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validationforPRoducer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Producers", "ProfilePictureURL", c => c.String(nullable: false));
            AlterColumn("dbo.Producers", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Producers", "Bio", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Producers", "Bio", c => c.String());
            AlterColumn("dbo.Producers", "FullName", c => c.String());
            AlterColumn("dbo.Producers", "ProfilePictureURL", c => c.String());
        }
    }
}
