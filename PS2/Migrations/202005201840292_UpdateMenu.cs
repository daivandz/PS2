namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Menus", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.Menus", "Tipo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "Client", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Orders", "Detail", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Orders", "Status", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Detail", c => c.String(nullable: false));
            AlterColumn("dbo.Orders", "Client", c => c.String(nullable: false));
            AlterColumn("dbo.Menus", "Tipo", c => c.String(nullable: false));
            AlterColumn("dbo.Menus", "Description", c => c.String());
            AlterColumn("dbo.Menus", "Name", c => c.String(nullable: false));
        }
    }
}
