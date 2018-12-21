namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePurchase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Purchases", "InvoiceNumber", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Purchases", "InvoiceNumber", c => c.String());
        }
    }
}
