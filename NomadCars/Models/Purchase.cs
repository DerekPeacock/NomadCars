 using NomadCars.Models;
using System;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Connor
/// </summary>
/// 
namespace NomadCars.Models
{
    public enum TransactionTypes
    {
        Cash,
        Card,
        Loan,
        HP
    }
    public class Purchase
    {
        public int PurchaseID { get; set; }
        
        /// <summary>
        /// A specific number given to each invoice in order for each to be identified within the database for the 
        /// purposes of tracking or record keeping, i.e. for end of week or annual car sales.
        /// </summary>
        /// 
        [StringLength(20), Required]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// A detailed receipt of the purchase made by the customer, including the product, 
        /// amount, address of the customer, address of the seller as well as the date of payment.
        /// </summary>
        public bool IsInvoiced { get; set; }
        
        /// <summary>
        /// The document, held by the sales team, for the customer to complete in order for the 
        /// car to be registered in their name, as per the law of the government.
        /// </summary>
        public bool HasRegistrationDocument { get; set; }
        
        /// <summary>
        /// A record of the database representing whether or not the customer has returned the car. 
        /// This will be allowed within a 30 day period of time.
        /// </summary>
        public bool IsReturned { get; set; }
        
        /// <summary>
        /// The cost of the car returned to the customer as part of the refund procedure. 
        /// Note this only applies if the customer requests a refund due to a fault discovered in the car before the 30 day time period has concluded.
        /// </summary>
        public decimal Refund { get; set; }

        public decimal IntrestRate { get; set; }
        
        //Nullable
        public TransactionTypes TransactionType { get; set; }

        // person buying the car (could be staff)
        public int PersonID { get; set; }

        // Member of staff selling the car
        public int StaffID { get; set; }

        // car being bought
        public int CarID { get; set; }


        public virtual Car Car { get; set; }


        public virtual Person Customer { get; set; }

        public virtual Staff Staff { get; set; }

    }
}
