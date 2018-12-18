namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarSpecs", "BHP", c => c.Int());
            AlterColumn("dbo.CarSpecs", "BootCapacity", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarSpecs", "BootCapacity", c => c.Int(nullable: false));
            AlterColumn("dbo.CarSpecs", "BHP", c => c.Int(nullable: false));
        }
    }
}
