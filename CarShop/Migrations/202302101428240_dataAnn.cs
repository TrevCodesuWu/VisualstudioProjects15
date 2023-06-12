namespace CarShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "name", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "model", c => c.String(nullable: false));
            AlterColumn("dbo.Cars", "released", c => c.DateTime());
            AlterColumn("dbo.Classes", "car_class", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "car_class", c => c.String());
            AlterColumn("dbo.Cars", "released", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Cars", "model", c => c.String());
            AlterColumn("dbo.Cars", "name", c => c.String());
        }
    }
}
