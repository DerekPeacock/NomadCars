using System.Data.Entity;
using System.Collections.Generic;
using NomadCars.Models;

namespace NomadCars.DAL
{
    public class NomadInitialiser : DropCreateDatabaseIfModelChanges<NomadDbContext>
    {
        protected override void Seed(NomadDbContext context)
        {
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
            //SeedPayment(context);
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
                    MaritalStatus = "Single",
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

        private void SeedPayment(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeedImages(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeedAddresses(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeeAccessory(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeedStaff(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeedCars(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }

        private void SeedCarSpec(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };

            PurchaseList.ForEach(p => context.Purchases.Add(p));
            context.SaveChanges();
        }
    }
}