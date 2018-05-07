using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Apple", 120.00);
            apple.Attach(new Investor("ABC Trading"));
            apple.Attach(new Investor("Coca Cola"));
        
            apple.Price = 120.10;
            apple.Price = 121.00;
            apple.Price = 120.50;
            apple.Price = 120.75;
        }
    }
}
