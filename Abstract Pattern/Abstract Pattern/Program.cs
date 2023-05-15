using System;

namespace Abstract_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardType = "";

            CreditCard cardDetails = null;

            if(cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if(cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if(cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            if(cardDetails!= null)
            {
                Console.WriteLine("cardType " + cardDetails.GetCardType());
                Console.WriteLine("AnnualCharge " + cardDetails.GetAnnualCharge());
                Console.WriteLine("CreditLimit " + cardDetails.GetCreditLimit());
            }
            else
            {
                Console.WriteLine("Invalid card details entered");
            }
        }
    }
}
