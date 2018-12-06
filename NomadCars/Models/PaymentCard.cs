using System;
public class PaymentCard
{
	public int CardID { get; set; }
    //A specific ID used to identify each card uniquely

    public string CardType { get; set; }
    //This is the type of card that the customer will be using to make their purchase

    public String CardNumber { get; set; }
    //A unique 16 digit number on the customer's card

    public String NameOnCard { get; set; }
    //This will be the name of the card owner

    public short SecurityNumber { get; set; }
    //The 3 digit number on the customer's card

    public int ExpiryMonth { get; set; }
    //The month in which the card expires

    public int ExpiryYear { get; set; }
    //The year that the card expires


}
