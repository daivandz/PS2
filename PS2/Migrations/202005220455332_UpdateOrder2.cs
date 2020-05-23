namespace PS2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "Note");
            DropColumn("dbo.Orders", "Date");
            DropColumn("dbo.Orders", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Orders", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Orders", "Note", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Orders", "Quantity");
        }
    }
}
