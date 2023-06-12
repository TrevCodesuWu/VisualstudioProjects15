namespace codefirstnewProjectone.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Cat_id = c.Int(nullable: false, identity: true),
                        Cat_Name = c.String(),
                    })
                .PrimaryKey(t => t.Cat_id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        staff_id = c.String(nullable: false, maxLength: 128),
                        staff_name = c.String(),
                        surname = c.String(),
                        staff_age = c.Int(nullable: false),
                        staff_points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.staff_id);
            
            CreateTable(
                "dbo.Tblitems",
                c => new
                    {
                        item_id = c.String(nullable: false, maxLength: 128),
                        item_desc = c.String(),
                        Cat_id = c.Int(nullable: false),
                        item_size = c.String(),
                        item_cost = c.Double(nullable: false),
                        vat = c.Double(nullable: false),
                        selling = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.item_id)
                .ForeignKey("dbo.Categories", t => t.Cat_id, cascadeDelete: true)
                .Index(t => t.Cat_id);
            
            CreateTable(
                "dbo.transactions",
                c => new
                    {
                        Trans_no = c.Int(nullable: false, identity: true),
                        Staff_Id = c.String(maxLength: 128),
                        item_id = c.String(maxLength: 128),
                        Trans_amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Trans_no)
                .ForeignKey("dbo.Staffs", t => t.Staff_Id)
                .ForeignKey("dbo.Tblitems", t => t.item_id)
                .Index(t => t.Staff_Id)
                .Index(t => t.item_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transactions", "item_id", "dbo.Tblitems");
            DropForeignKey("dbo.transactions", "Staff_Id", "dbo.Staffs");
            DropForeignKey("dbo.Tblitems", "Cat_id", "dbo.Categories");
            DropIndex("dbo.transactions", new[] { "item_id" });
            DropIndex("dbo.transactions", new[] { "Staff_Id" });
            DropIndex("dbo.Tblitems", new[] { "Cat_id" });
            DropTable("dbo.transactions");
            DropTable("dbo.Tblitems");
            DropTable("dbo.Staffs");
            DropTable("dbo.Categories");
        }
    }
}
