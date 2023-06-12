namespace RestuarantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class url_prop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "food_url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "food_url");
        }
    }
}
