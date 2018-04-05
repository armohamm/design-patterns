using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Manufacturer manufacturer = new Manufacturer();

            ICarBuilder carBuilder = null;

            carBuilder = new BMWCar();
            manufacturer.Construct(carBuilder);
            Console.WriteLine("New car was built: \n {0}", carBuilder.GetCar().ToString());

            carBuilder = new MercedezBenzCar();
            manufacturer.Construct(carBuilder);
            Console.WriteLine("New car was built: \n {0}", carBuilder.GetCar().ToString());
        }
    }
}
