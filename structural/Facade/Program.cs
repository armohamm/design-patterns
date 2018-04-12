using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ITravelPackageFacade travelPackageFacade = new TravelPackageFacade();
            travelPackageFacade.Book();
        }
    }
}
