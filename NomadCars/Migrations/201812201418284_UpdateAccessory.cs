namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccessory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accessories", "Description", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Accessories", "AccessoryType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accessories", "AccessoryType", c => c.String());
            AlterColumn("dbo.Accessories", "Description", c => c.String());
        }
    }
}
