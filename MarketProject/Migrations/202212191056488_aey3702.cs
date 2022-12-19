namespace MarketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aey3702 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "UserName", c => c.Int(nullable: false));
        }
    }
}
