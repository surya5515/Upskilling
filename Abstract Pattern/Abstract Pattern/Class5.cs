using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Pattern
{
    class Program1
    {
        static void Main1(string[] args)
        {
            CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");
            if(cardDetails != null)
                {
                Console.WriteLine("CardType is :" + cardDetails.GetCardType());
                Console.WriteLine("AnnualCharge is :" + cardDetails.GetAnnualCharge());
                Console.WriteLine("CreditLimit is :" + cardDetails.GetCreditLimit());
            }
            else
            {
                Console.WriteLine("Invalid Card details entered");
            }
        }
    }
}
