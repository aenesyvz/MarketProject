namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3707 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupplierPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        DebtSupplierId = c.Int(nullable: false),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AddedPayment = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SupplierPayments");
        }
    }
}
