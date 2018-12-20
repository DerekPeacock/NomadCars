namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePaymentCard : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PaymentCards", "CardNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PaymentCards", "NameOnCard", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.PaymentCards", "SecurityNumber", c => c.String(nullable: false, maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PaymentCards", "SecurityNumber", c => c.Short(nullable: false));
            AlterColumn("dbo.PaymentCards", "NameOnCard", c => c.String());
            AlterColumn("dbo.PaymentCards", "CardNumber", c => c.String());
        }
    }
}
