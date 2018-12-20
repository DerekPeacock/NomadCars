namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentCardID : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.People", name: "PaymentCard_PaymentCardID", newName: "PaymentCardID");
            RenameIndex(table: "dbo.People", name: "IX_PaymentCard_PaymentCardID", newName: "IX_PaymentCardID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.People", name: "IX_PaymentCardID", newName: "IX_PaymentCard_PaymentCardID");
            RenameColumn(table: "dbo.People", name: "PaymentCardID", newName: "PaymentCard_PaymentCardID");
        }
    }
}
