using System;

namespace Facade
{
    public class HotelBooking : IHotelBooking
    {
        public void Book()
        {
            Console.WriteLine("Hotel booked successfully");
        }
    }
}