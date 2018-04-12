using System;

namespace Facade
{
    public class FlightBooking : IFlightBooking
    {
        public void Book()
        {
            Console.WriteLine("Flight booked successfully");
        }
    }
}