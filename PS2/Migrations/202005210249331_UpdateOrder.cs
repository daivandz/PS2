namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Note", c => c.String(nullable: false, maxLength: 500));
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "MenuId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "MenuId");
            AddForeignKey("dbo.Orders", "MenuId", "dbo.Menus", "id", cascadeDelete: true);
            DropColumn("dbo.Orders", "Detail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Detail", c => c.String(nullable: false, maxLength: 500));
            DropForeignKey("dbo.Orders", "MenuId", "dbo.Menus");
            DropIndex("dbo.Orders", new[] { "MenuId" });
            DropColumn("dbo.Orders", "MenuId");
            DropColumn("dbo.Orders", "Date");
            DropColumn("dbo.Orders", "Note");
        }
    }
}
