using System;

namespace FactoryMethod
{
    public class Plane : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Driving the plane at {0} miles/hours.", miles);
        }
    }
}
