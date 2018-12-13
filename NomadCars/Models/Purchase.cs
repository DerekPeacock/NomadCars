using NomadCars.Models;
using System;
/// <summary>
/// Connor
/// </summary>
/// 
namespace NomadCars.Models
{
    public class Purchase
    {
        /// <summary>
        /// A specific number given to each invoice in order for each to be identified within the database for the 
        /// purposes of tracking or record keeping, i.e. for end of week or annual car sales.
        /// </summary>
        public string InvoiceNumber { get; set; }
        /// <summary>
        /// A detailed receipt of the purchase made by the customer, including the product, 
        /// amount, address of the customer, address of the seller as well as the date of payment.
        /// </summary>
        public bool Invoice { get; set; }
        /// <summary>
        /// The document, held by the sales team, for the customer to complete in order for the 
        /// car to be registered in their name, as per the law of the government.
        /// </summary>
        public bool VehicleRegistrationDocument { get; set; }
        /// <summary>
        /// A record of the database representing whether or not the customer has returned the car. 
        /// This will be allowed within a 30 day period of time.
        /// </summary>
        public bool Return_ { get; set; }
        /// <summary>
        /// The cost of the car returned to the customer as part of the refund procedure. 
        /// Note this only applies if the customer requests a refund due to a fault discovered in the car before the 30 day time period has concluded.
        /// </summary>
        public int Refund { get; set; }

        public decimal Intrest { get; set; }
        //Nullable
        public String TransactionType { get; set; }

        public int PersonID { get; set; }

        public int StaffID { get; set; }

        public int CarID { get; set; }

        public virtual Car Car { get; set; }

        public virtual Person Customer { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
