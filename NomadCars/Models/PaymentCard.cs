using System;

namespace NomadCars.Models
{
    public enum CardTypes
    {
        VISA_CREDIT,
        VISA_DEBIT,
        MASTERCARD,
        PAYPAL
    }

    public class PaymentCard
    {
        //A specific ID used to identify each card uniquely
        public int PaymentCardID { get; set; }
        
        //This is the type of card that the customer will be using to make their purchase
        public CardTypes CardType { get; set; }
        
        //A unique 16 digit number on the customer's card
        public string CardNumber { get; set; }
        
        //This will be the name of the card owner
        public string NameOnCard { get; set; }
       
        //The 3 digit number on the customer's card
        public short SecurityNumber { get; set; }
        
        //The month in which the card expires
        public int ExpiryMonth { get; set; }
        
        //The year that the card expires
        public int ExpiryYear { get; set; }
        


    }
}
