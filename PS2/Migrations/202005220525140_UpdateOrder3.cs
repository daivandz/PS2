namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Total");
        }
    }
}
