namespace CarShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnClass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "car_class", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "car_class", c => c.String(nullable: false));
        }
    }
}
