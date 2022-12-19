namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3701 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DebtCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        AmountOfDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RemaingDebt = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DebtSuppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        AmountOfDebt = c.Single(nullable: false),
                        AmountPaid = c.Single(nullable: false),
                        RemaingDebt = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WayBillId = c.Int(nullable: false),
                        Code = c.String(),
                        BarcodeNo = c.String(),
                        Name = c.String(),
                        Amount = c.Int(nullable: false),
                        UnitOfPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        AddedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Waybills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WaybillId = c.Int(nullable: false),
                        ProductCode = c.String(),
                        Barcode = c.String(),
                        Price = c.Single(nullable: false),
                        Amount = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Waybills");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Sales");
            DropTable("dbo.Products");
            DropTable("dbo.DebtSuppliers");
            DropTable("dbo.DebtCustomers");
            DropTable("dbo.Customers");
        }
    }
}
