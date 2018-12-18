namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarSpecUpdates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarSpecs", "Make", c => c.Int(nullable: false));
            AlterColumn("dbo.CarSpecs", "Model", c => c.Int(nullable: false));
            AlterColumn("dbo.CarSpecs", "TaxGroup", c => c.Int(nullable: false));
            AlterColumn("dbo.CarSpecs", "DriveTrain", c => c.Int(nullable: false));
            AlterColumn("dbo.CarSpecs", "BodyType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarSpecs", "BodyType", c => c.String());
            AlterColumn("dbo.CarSpecs", "DriveTrain", c => c.String());
            AlterColumn("dbo.CarSpecs", "TaxGroup", c => c.String());
            AlterColumn("dbo.CarSpecs", "Model", c => c.String());
            AlterColumn("dbo.CarSpecs", "Make", c => c.String());
        }
    }
}
