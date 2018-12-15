namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCounties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Addresses", "County", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Addresses", "County", c => c.String());
        }
    }
}
