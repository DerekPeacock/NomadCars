namespace NomadCars.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity;
    using NomadCars.Models;
    using NomadCars.DAL;
    using System.Collections.Generic;
    using System.Linq;


    internal sealed class Configuration : DbMigrationsConfiguration<NomadDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NomadDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // William
            SeedPeople(context);

            // William
            SeedStaff(context);

            // William
            SeedAddresses(context);

            // Zeeshan
            SeedCarSpec(context);

            // Zeeshan
            SeedCars(context);

            // Daniel
            //SeeAccessory(context);
            // Daniel
            //SeedImages(context);
            // Connor
            //SeedPaymentCard(context);
            // Connor
            //SeedPurchases(context);
        }

        private void SeedPeople(NomadDbContext context)
        {
            var PeopleList = new List<Person>
            {
                new Person
                {
                    PersonID = 1,
                    FirstName = "William",
                    LastName = "Foster",
                    DateOfBirth = new System.DateTime(1994, 8, 28),
                    Email = "william.foster@nomad.com",
                    IsCustomer = false,
                    IsStaff = true,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 2,
                    FirstName = "Connor",
                    LastName = "Patey",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "connor.patey@nomad.com",
                    IsCustomer = false,
                    IsStaff = true,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 3,
                    FirstName = "Daniel",
                    LastName = "Schafer-Smith",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "daniel.schafer_smith@nomad.com",
                    IsCustomer = false,
                    IsStaff = true,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 4,
                    FirstName = "Zeeshan",
                    LastName = "Akhlaq",
                    DateOfBirth = new System.DateTime(1999, 10, 10),
                    Email = "zeeshan.akhlaq@nomad.com",
                    IsCustomer = false,
                    IsStaff = true,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 5,
                    FirstName = "Tomas",
                    LastName = "Green",
                    DateOfBirth = new System.DateTime(1994, 12, 2),
                    Email = "TomasGreen94@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 6,
                    FirstName = "Ben",
                    LastName = "Miller",
                    DateOfBirth = new System.DateTime(1992, 3, 12),
                    Email = "Miller92@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Single
                },
                new Person
                {
                    PersonID = 7,
                    FirstName = "Lilly",
                    LastName = "Erickson",
                    DateOfBirth = new System.DateTime(1985, 7, 30),
                    Email = "Lilly1985@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Married
                },
                new Person
                {
                    PersonID = 8,
                    FirstName = "Joshua",
                    LastName = "Knight",
                    DateOfBirth = new System.DateTime(1990, 11, 23),
                    Email = "JoshKnight90@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Married
                },
                new Person
                {
                    PersonID = 9,
                    FirstName = "Emily",
                    LastName = "White",
                    DateOfBirth = new System.DateTime(1981, 4, 5),
                    Email = "EWhite@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Divorced
                },
                new Person
                {
                    PersonID = 10,
                    FirstName = "Eliot",
                    LastName = "Meyers",
                    DateOfBirth = new System.DateTime(1956, 9, 21),
                    Email = "EliotMey@gmail.com",
                    IsCustomer = true,
                    IsStaff = false,
                    MaritalStatus = MaritalSatusOptions.Other
                }

            };

            PeopleList.ForEach(p => context.People.AddOrUpdate(i => i.LastName, p));
            context.SaveChanges();
        }

        /// <summary>
        /// Connor
        /// </summary>
        private void SeedPurchases(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {
                new Purchase
                {
                    PurchaseID = 1,
                    InvoiceNumber =  "Invoice No 1001",
                    IsInvoiced = true,
                    HasRegistrationDocument = true,
                    IsReturned = false,
                    Refund = 0.00m,
                    IntrestRate = 3.00m,
                    TransactionType = TransactionTypes.CARD,
                    CarID = 1,
                    PersonID = 1,
                    StaffID = 1
                }
            };

            //context.SaveChanges();
        }

        private void SeedPaymentCard(NomadDbContext context)
        {
            var PaymentCardList = new List<PaymentCard>
            {

            };

            //context.SaveChanges();
        }

        private void SeedImages(NomadDbContext context)
        {
            var CarImageList = new List<CarImage>
            {

            };

            //context.SaveChanges();
        }

        private void SeedAddresses(NomadDbContext context)
        {
            var AddressList = new List<Address>
            {
                new Address
                {
                    AddressID = 1,
                    House = "8",
                    StreetName = "Kestrel Way",
                    TownName = "Aylesbury",
                    Postcode = "HP190GH",
                    County = Counties.Buckinghamshire
                },
                new Address
                {
                    AddressID = 2,
                    House = "22",
                    StreetName = "Iron Road",
                    TownName = "Aylesbury",
                    Postcode = "HP208UG",
                    County = Counties.Buckinghamshire
                },
                new Address
                {
                    AddressID = 3,
                    House = "12",
                    StreetName = "Mercia Close",
                    TownName = "Aylesbury",
                    Postcode = "HP214OF",
                    County = Counties.Buckinghamshire
                },
                new Address
                {
                    AddressID = 4,
                    House = "43",
                    StreetName = "Potters Way",
                    TownName = "Chesham",
                    Postcode = "HP236LT",
                    County = Counties.Buckinghamshire
                }

            };

            //context.SaveChanges();
        }

        private void SeeAccessory(NomadDbContext context)
        {
            var AccessoryList = new List<Accessory>
            {

            };

            //context.SaveChanges();
        }

        private void SeedStaff(NomadDbContext context)
        {
            var StaffList = new List<Staff>
            {
                new Staff
                { 
                    StaffID = 1,
                    Department = DepartmentOptions.Management,
                    JobPosition = JobPositionOptions.SalesManager,
                    Salary = 24000m,
                    StartDate = new System.DateTime(2017,10, 10)
                },
                new Staff
                {
                    StaffID = 2,
                    Department = DepartmentOptions.Accounts,
                    JobPosition = JobPositionOptions.Accountant,
                    Salary = 28000m,
                    StartDate = new System.DateTime(2017, 10, 10)
                },
                new Staff
                {
                    StaffID = 3,
                    Department = DepartmentOptions.Management,
                    JobPosition = JobPositionOptions.LocationManager,
                    Salary = 30000m,
                    StartDate = new System.DateTime(2017, 10, 10)
                },
                new Staff
                {
                    StaffID = 4,
                    Department = DepartmentOptions.Sales,
                    JobPosition = JobPositionOptions.SalesRepresentative,
                    Salary = 21000m,
                    StartDate = new System.DateTime(2017, 10, 10)
                }

            };

            StaffList.ForEach(s => context.Staff.AddOrUpdate(p => p.StaffID, s));
            context.SaveChanges();
        }

        private void SeedCars(NomadDbContext context)
        {
            var CarList = new List<Car>
            {

            };

            CarList.ForEach(c => context.Cars.AddOrUpdate(p => p.CarID, c));
            context.SaveChanges();
        }

        private void SeedCarSpec(NomadDbContext context)
        {
            var SpecList = new List<CarSpec>
            {
                new CarSpec
                {
                    CarSpecID  = 1,
                    Make = CarMakes.BMW,
                    Model = CarModels.BMW_420d,
                    Petrol = true,
                    Diesel = false,
                    Electric = false,
                    TaxGroup = TaxGroups.D,
                    BodyType = BodyTypes.Coupe,
                    DriveTrain = DriveTrains.Rear_Wheel_Drive,
                    TopSpeed = 180,
                    Doors = 4,
                    Range = 300,
                    EngineSize = EngineSizes.CC_1999,
                    Length = 4638,
                    Width = 2017,
                    Seats = 5,
                    BHP = 181,
                    BootCapacity = 5,
                    MPG = 40
                }
            };

            SpecList.ForEach(c => context.CarSpecs.AddOrUpdate(p => p.CarSpecID, c));
            context.SaveChanges();
        }
    }
}

