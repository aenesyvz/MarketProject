namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3705 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Waybills", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Waybills", "TotalPrice");
        }
    }
}
