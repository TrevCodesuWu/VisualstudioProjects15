namespace ModdingDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        person_id = c.String(nullable: false, maxLength: 128),
                        name = c.String(nullable: false),
                        age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.person_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
