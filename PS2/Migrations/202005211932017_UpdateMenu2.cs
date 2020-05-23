namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenu2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Image", c => c.Binary(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Image");
        }
    }
}
