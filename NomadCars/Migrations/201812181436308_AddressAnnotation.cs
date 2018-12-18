namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "House", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Addresses", "StreetName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Addresses", "TownName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Addresses", "Postcode", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "Postcode", c => c.String());
            AlterColumn("dbo.Addresses", "TownName", c => c.String());
            AlterColumn("dbo.Addresses", "StreetName", c => c.String());
            AlterColumn("dbo.Addresses", "House", c => c.String());
        }
    }
}
