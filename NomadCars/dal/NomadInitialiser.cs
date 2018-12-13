using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using NomadCars.Models;

namespace NomadCars.DAL
{
    public class NomadInitialiser : DropCreateDatabaseIfModelChanges<NomadDbContext>
    {
        protected override void Seed(NomadDbContext context)
        {
            // Zeeshan
            SeedCarSpec(context);
            // Zeeshan
            SeedCars(context);
            // William
            SeedPeople(context);
            // William
            SeedStaff(context);
            // Daniel
            SeeAccessory(context);
            // William
            SeedAddresses(context);
            // Daniel
            SeedImages(context);
            // Connor
            SeedPayment(context);
            // Connor
            SeedPurchases(context);


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


                }
            };
        }

        private void SeedPayment(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedImages(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedAddresses(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeeAccessory(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedStaff(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedPeople(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedCars(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }

        private void SeedCarSpec(NomadDbContext context)
        {
            var PurchaseList = new List<Purchase>
            {

            };
        }
    }
}