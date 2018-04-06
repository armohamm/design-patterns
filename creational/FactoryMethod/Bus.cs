using System;

namespace FactoryMethod
{
    public class Bus : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Driving the bus at {0} miles/hours.", miles);
        }
    }
}
