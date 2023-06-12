namespace PracticeGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class game_field_release_date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "release_date", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "release_date");
        }
    }
}
