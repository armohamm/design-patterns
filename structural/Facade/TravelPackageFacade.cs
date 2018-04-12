
using System;
using Facade;

namespace Facade
{
    public class TravelPackageFacade : ITravelPackageFacade
    {
        public void Book()
        {
            FlightBooking flight = new FlightBooking();
            flight.Book();

            HotelBooking hotel = new HotelBooking();
            hotel.Book();

            Console.WriteLine("Travel package booked successfully.");
        }
    }
}