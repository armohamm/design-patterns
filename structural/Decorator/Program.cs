using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda car = new Honda();

            Console.WriteLine("Honda base price is: {0}", car.Price);

            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25% discount";

            Console.WriteLine("{1} @ Diwali Special Offer and price is : {0}", offer.Price, offer.Offer);

            Console.ReadKey();
        }
    }
}
