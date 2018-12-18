namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetMigrations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                {
                    AccessoryID = c.Int(nullable: false, identity: true),
                    Description = c.String(),
                    AccessoryType = c.String(),
                })
                .PrimaryKey(t => t.AccessoryID);

            CreateTable(
                "dbo.Cars",
                c => new
                {
                    CarID = c.Int(nullable: false, identity: true),
                    Colour = c.String(),
                    NumberPlate = c.String(),
                    VINNo = c.String(),
                    BodyType = c.String(),
                    Mileage = c.Int(nullable: false),
                    TransmissionType = c.String(),
                    NoPreviousOwner = c.Int(nullable: false),
                    AccelerationTo60 = c.Int(nullable: false),
                    Sold = c.Boolean(nullable: false),
                    Delivered = c.Boolean(nullable: false),
                    CO2Emissions = c.Int(nullable: false),
                    CarSpecID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.CarID)
                .ForeignKey("dbo.CarSpecs", t => t.CarSpecID, cascadeDelete: true)
                .Index(t => t.CarSpecID);

            CreateTable(
                "dbo.CarSpecs",
                c => new
                {
                    CarSpecID = c.Int(nullable: false, identity: true),
                    Make = c.Int(nullable: false),
                    Model = c.Int(nullable: false),
                    EngineSize = c.Int(nullable: false),
                    Doors = c.Int(nullable: false),
                    Length = c.Single(nullable: false),
                    Width = c.Single(nullable: false),
                    BHP = c.Int(),
                    BootCapacity = c.Int(),
                    Petrol = c.Boolean(nullable: false),
                    MPG = c.Int(nullable: false),
                    Diesel = c.Boolean(nullable: false),
                    Electric = c.Boolean(nullable: false),
                    Seats = c.Int(nullable: false),
                    TaxGroup = c.Int(nullable: false),
                    TopSpeed = c.Int(nullable: false),
                    DriveTrain = c.Int(nullable: false),
                    BodyType = c.Int(nullable: false),
                    Range = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.CarSpecID);

            CreateTable(
                "dbo.CarImages",
                c => new
                {
                    CarImageID = c.Int(nullable: false, identity: true),
                    Car_CarID = c.Int(),
                })
                .PrimaryKey(t => t.CarImageID)
                .ForeignKey("dbo.Cars", t => t.Car_CarID)
                .Index(t => t.Car_CarID);

            CreateTable(
                "dbo.Addresses",
                c => new
                {
                    AddressID = c.Int(nullable: false),
                    House = c.String(nullable: false, maxLength: 30),
                    StreetName = c.String(maxLength: 30),
                    TownName = c.String(nullable: false, maxLength: 30),
                    Postcode = c.String(nullable: false, maxLength: 8),
                    County = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.People", t => t.AddressID)
                .Index(t => t.AddressID);

            CreateTable(
                "dbo.People",
                c => new
                {
                    PersonID = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false, maxLength: 20),
                    LastName = c.String(nullable: false, maxLength: 20),
                    HomePhoneNumber = c.String(maxLength: 16),
                    MobilePhoneNumber = c.String(maxLength: 16),
                    Email = c.String(nullable: false, maxLength: 100),
                    DateOfBirth = c.DateTime(nullable: false),
                    MaritalStatus = c.Int(nullable: false),
                    IsCustomer = c.Boolean(nullable: false),
                    IsStaff = c.Boolean(nullable: false),
                    PaymentCard_PaymentCardID = c.Int(),
                })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.PaymentCards", t => t.PaymentCard_PaymentCardID)
                .Index(t => t.PaymentCard_PaymentCardID);

            CreateTable(
                "dbo.PaymentCards",
                c => new
                {
                    PaymentCardID = c.Int(nullable: false, identity: true),
                    CardType = c.Int(nullable: false),
                    CardNumber = c.String(),
                    NameOnCard = c.String(),
                    SecurityNumber = c.Short(nullable: false),
                    ExpiryMonth = c.Int(nullable: false),
                    ExpiryYear = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.PaymentCardID);

            CreateTable(
                "dbo.Staffs",
                c => new
                {
                    StaffID = c.Int(nullable: false),
                    Department = c.Int(nullable: false),
                    JobPosition = c.Int(nullable: false),
                    Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    StartDate = c.DateTime(nullable: false),
                    ImageURL = c.String(),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.StaffID)
                .ForeignKey("dbo.People", t => t.StaffID)
                .Index(t => t.StaffID);

            CreateTable(
                "dbo.Purchases",
                c => new
                {
                    PurchaseID = c.Int(nullable: false, identity: true),
                    InvoiceNumber = c.String(),
                    IsInvoiced = c.Boolean(nullable: false),
                    HasRegistrationDocument = c.Boolean(nullable: false),
                    IsReturned = c.Boolean(nullable: false),
                    Refund = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IntrestRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    TransactionType = c.Int(nullable: false),
                    PersonID = c.Int(nullable: false),
                    StaffID = c.Int(nullable: false),
                    CarID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.Cars", t => t.CarID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.PersonID)
                .Index(t => t.StaffID)
                .Index(t => t.CarID);

            CreateTable(
                "dbo.CarAccessories",
                c => new
                {
                    Car_CarID = c.Int(nullable: false),
                    Accessory_AccessoryID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Car_CarID, t.Accessory_AccessoryID })
                .ForeignKey("dbo.Cars", t => t.Car_CarID, cascadeDelete: true)
                .ForeignKey("dbo.Accessories", t => t.Accessory_AccessoryID, cascadeDelete: true)
                .Index(t => t.Car_CarID)
                .Index(t => t.Accessory_AccessoryID);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.Purchases", "PersonID", "dbo.People");
            DropForeignKey("dbo.Purchases", "CarID", "dbo.Cars");
            DropForeignKey("dbo.Addresses", "AddressID", "dbo.People");
            DropForeignKey("dbo.Staffs", "StaffID", "dbo.People");
            DropForeignKey("dbo.People", "PaymentCard_PaymentCardID", "dbo.PaymentCards");
            DropForeignKey("dbo.CarImages", "Car_CarID", "dbo.Cars");
            DropForeignKey("dbo.Cars", "CarSpecID", "dbo.CarSpecs");
            DropForeignKey("dbo.CarAccessories", "Accessory_AccessoryID", "dbo.Accessories");
            DropForeignKey("dbo.CarAccessories", "Car_CarID", "dbo.Cars");
            DropIndex("dbo.CarAccessories", new[] { "Accessory_AccessoryID" });
            DropIndex("dbo.CarAccessories", new[] { "Car_CarID" });
            DropIndex("dbo.Purchases", new[] { "CarID" });
            DropIndex("dbo.Purchases", new[] { "StaffID" });
            DropIndex("dbo.Purchases", new[] { "PersonID" });
            DropIndex("dbo.Staffs", new[] { "StaffID" });
            DropIndex("dbo.People", new[] { "PaymentCard_PaymentCardID" });
            DropIndex("dbo.Addresses", new[] { "AddressID" });
            DropIndex("dbo.CarImages", new[] { "Car_CarID" });
            DropIndex("dbo.Cars", new[] { "CarSpecID" });
            DropTable("dbo.CarAccessories");
            DropTable("dbo.Purchases");
            DropTable("dbo.Staffs");
            DropTable("dbo.PaymentCards");
            DropTable("dbo.People");
            DropTable("dbo.Addresses");
            DropTable("dbo.CarImages");
            DropTable("dbo.CarSpecs");
            DropTable("dbo.Cars");
            DropTable("dbo.Accessories");
        }
    }
}
