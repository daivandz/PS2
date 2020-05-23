namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Status", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Status", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
