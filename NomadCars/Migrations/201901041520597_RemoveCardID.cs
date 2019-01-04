namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCardID : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "PaymentCardID", "dbo.PaymentCards");
            DropIndex("dbo.People", new[] { "PaymentCardID" });
            DropPrimaryKey("dbo.PaymentCards");
            AlterColumn("dbo.PaymentCards", "PaymentCardID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PaymentCards", "PaymentCardID");
            CreateIndex("dbo.PaymentCards", "PaymentCardID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "PaymentCardID", c => c.Int());
            DropIndex("dbo.PaymentCards", new[] { "PaymentCardID" });
            DropPrimaryKey("dbo.PaymentCards");
            AlterColumn("dbo.PaymentCards", "PaymentCardID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PaymentCards", "PaymentCardID");
            CreateIndex("dbo.People", "PaymentCardID");
            AddForeignKey("dbo.People", "PaymentCardID", "dbo.PaymentCards", "PaymentCardID");
        }
    }
}
