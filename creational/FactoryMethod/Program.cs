using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory bus = factory.GetVehicle("Bus");
            bus.Drive(50);

            IFactory plane = factory.GetVehicle("Plane");
            bus.Drive(500);

            IFactory car = factory.GetVehicle("Car");
            car.Drive(60);
            
        }
    }
}
