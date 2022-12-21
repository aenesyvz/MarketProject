namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3704 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditSales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        SaleId = c.Int(nullable: false),
                        DebtCustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CreditSales");
        }
    }
}
