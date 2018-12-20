using System;
using System.ComponentModel.DataAnnotations;

namespace NomadCars.Models
{
    public enum CardTypes
    {
        [Display(Name="Visa Credit Card")]
        VISA_CREDIT,
        [Display(Name = "Visa Debit Card")]
        VISA_DEBIT,
        [Display(Name = "MasterCard")]
        MASTERCARD,
        [Display(Name = "PayPal")]
        PAYPAL
    }

    /// <summary>
    /// Connor
    /// </summary>
    public class PaymentCard
    {
        //A specific ID used to identify each card uniquely
        public int PaymentCardID { get; set; }
        
        //This is the type of card that the customer will be using to make their purchase
        public CardTypes CardType { get; set; }

        //A unique 16 digit number on the customer's card
        [StringLength(20), Required]
        public string CardNumber { get; set; }

        //This will be the name of the card owner
        [StringLength(20), Required]
        public string NameOnCard { get; set; }

        //The 3 digit number on the customer's card
        [StringLength(3), Required]
       public string SecurityNumber { get; set; }
        
        //The month in which the card expires
        [Range(1,12)]
        public int ExpiryMonth { get; set; }
        
        //The year that the card expires
        [Range(2018,2024)]
        public int ExpiryYear { get; set; }
        


    }
}
