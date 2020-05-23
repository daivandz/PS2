namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenu3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "Image", c => c.Binary(nullable: false));
        }
    }
}
