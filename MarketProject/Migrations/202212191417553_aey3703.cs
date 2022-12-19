namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3703 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Waybills", "ProductName", c => c.String());
            DropColumn("dbo.Waybills", "Barcode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Waybills", "Barcode", c => c.String());
            DropColumn("dbo.Waybills", "ProductName");
        }
    }
}
