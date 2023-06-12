namespace GymManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User_Gender_models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        gender_name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        age = c.Int(nullable: false),
                        genderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Genders", t => t.genderId, cascadeDelete: true)
                .Index(t => t.genderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserProfiles", "genderId", "dbo.Genders");
            DropIndex("dbo.UserProfiles", new[] { "genderId" });
            DropTable("dbo.UserProfiles");
            DropTable("dbo.Genders");
        }
    }
}
