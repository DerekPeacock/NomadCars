namespace NomadCars.Migrations
{
    using System.Data.Entity.Migrations;
    using NomadCars.Models;
    using NomadCars.DAL;
    using System.Collections.Generic;

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
                    DateOfBirth = new System.DateTime(1998, 10, 10),
                    Email = "william.foster@nomad.com",
                    IsCustomer = false,
                    IsStaff = true,
                    MaritalStatus = MaritalSatusOptions.SINGLE
                }
            };

            PeopleList.ForEach(p => context.People.Add(p));
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

            //PurchaseList.ForEach(p => context.Purchases.Add(p));
            //context.SaveChanges();
        }

        private void SeedPaymentCard(NomadDbContext context)
        {
            var PaymentCardList = new List<PaymentCard>
            {

            };

            //PaymentCardList.ForEach(p => context.PaymentCards.Add(p));
            //context.SaveChanges();
        }

        private void SeedImages(NomadDbContext context)
        {
            var CarImageList = new List<CarImage>
            {

            };

            //CarImageList.ForEach(i => context.CarImages.Add(i));
            //context.SaveChanges();
        }

        private void SeedAddresses(NomadDbContext context)
        {
            var AddressList = new List<Address>
            {

            };

            //AddressList.ForEach(a => context.Addresses.Add(a));
            //context.SaveChanges();
        }

        private void SeeAccessory(NomadDbContext context)
        {
            var AccessoryList = new List<Accessory>
            {

            };

            //AccessoryList.ForEach(a => context.Accessories.Add(a));
            //context.SaveChanges();
        }

        private void SeedStaff(NomadDbContext context)
        {
            var StaffList = new List<Staff>
            {

            };

            //StaffList.ForEach(s => context.Staff.Add(s));
            //context.SaveChanges();
        }

        private void SeedCars(NomadDbContext context)
        {
            var CarList = new List<Car>
            {

            };

            CarList.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();
        }

        private void SeedCarSpec(NomadDbContext context)
        {
            var SpecList = new List<CarSpec>
            {

            };

            SpecList.ForEach(c => context.CarSpecs.Add(c));
            context.SaveChanges();
        }
    }
}

