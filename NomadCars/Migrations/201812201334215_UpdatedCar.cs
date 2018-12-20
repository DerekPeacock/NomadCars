namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Colour", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "NumberPlate", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Cars", "VINNo", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Cars", "TransmissionType", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "NoPreviousOwner", c => c.Int());
            DropColumn("dbo.Cars", "BodyType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "BodyType", c => c.String());
            AlterColumn("dbo.Cars", "NoPreviousOwner", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "TransmissionType", c => c.String());
            AlterColumn("dbo.Cars", "VINNo", c => c.String());
            AlterColumn("dbo.Cars", "NumberPlate", c => c.String());
            AlterColumn("dbo.Cars", "Colour", c => c.String());
        }
    }
}
