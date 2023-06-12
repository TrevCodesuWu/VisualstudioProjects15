namespace JobApplicationForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnn_added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.JobForms", "personName", c => c.String(nullable: false));
            AlterColumn("dbo.JobForms", "address", c => c.String(nullable: false));
            AlterColumn("dbo.JobForms", "phoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Positions", "position", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Positions", "position", c => c.String());
            AlterColumn("dbo.JobForms", "phoneNumber", c => c.String());
            AlterColumn("dbo.JobForms", "address", c => c.String());
            AlterColumn("dbo.JobForms", "personName", c => c.String());
        }
    }
}
