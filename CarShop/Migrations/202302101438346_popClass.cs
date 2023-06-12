namespace CarShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popClass : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Classes ON;");
            Sql("INSERT INTO Classes(id , car_class) VALUES(1,'S')");
            Sql("INSERT INTO Classes(id , car_class) VALUES(2,'A')");
            Sql("INSERT INTO Classes(id , car_class) VALUES(3,'B')");
            Sql("INSERT INTO Classes(id , car_class) VALUES(4,'C')");
            Sql("INSERT INTO Classes(id , car_class) VALUES(5,'D')");
            Sql("SET IDENTITY_INSERT Classes OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
