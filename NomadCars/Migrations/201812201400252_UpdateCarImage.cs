namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCarImage : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CarImages", "Car_CarID", "dbo.Cars");
            DropIndex("dbo.CarImages", new[] { "Car_CarID" });
            RenameColumn(table: "dbo.CarImages", name: "Car_CarID", newName: "CarID");
            AddColumn("dbo.CarImages", "ImageURL", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CarImages", "Description", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CarImages", "Caption", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.CarImages", "ImageFormat", c => c.Int(nullable: false));
            AddColumn("dbo.CarImages", "Position", c => c.Int(nullable: false));
            AlterColumn("dbo.CarImages", "CarID", c => c.Int(nullable: false));
            CreateIndex("dbo.CarImages", "CarID");
            AddForeignKey("dbo.CarImages", "CarID", "dbo.Cars", "CarID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CarImages", "CarID", "dbo.Cars");
            DropIndex("dbo.CarImages", new[] { "CarID" });
            AlterColumn("dbo.CarImages", "CarID", c => c.Int());
            DropColumn("dbo.CarImages", "Position");
            DropColumn("dbo.CarImages", "ImageFormat");
            DropColumn("dbo.CarImages", "Caption");
            DropColumn("dbo.CarImages", "Description");
            DropColumn("dbo.CarImages", "ImageURL");
            RenameColumn(table: "dbo.CarImages", name: "CarID", newName: "Car_CarID");
            CreateIndex("dbo.CarImages", "Car_CarID");
            AddForeignKey("dbo.CarImages", "Car_CarID", "dbo.Cars", "CarID");
        }
    }
}
