namespace RestuarantApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popCategory : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Categories ON;");
            Sql("INSERT INTO Categories (id , category_name) Values(1,'Vegetarian')");
            Sql("INSERT INTO Categories (id , category_name) Values(2,'Seafood')");
            Sql("INSERT INTO Categories (id , category_name) Values(3,'Meat')");
            Sql("INSERT INTO Categories (id , category_name) Values(4,'Dessert')");
            Sql("SET IDENTITY_INSERT Categories OFF;");
        }
        
        public override void Down()
        {
        }
    }
}
