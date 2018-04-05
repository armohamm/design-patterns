using System;

namespace Builder
{
    public class MercedezBenzCar : ICarBuilder
    {
        Car car;

        public MercedezBenzCar(){
            car = new Car("Mercedez Benz Car");
        }

        public void BuildWheelType()
        {
            car.WheelType = "4 Wheels";
        }

        public void BuildHP()
        {
            car.HP = 275;
        }

        public void BuildBrand()
        {
            car.Brand = "Mercedez Benz";
        }

        public void BuildConvertible()
        {
            car.Convertible = false;
        }

        public Car GetCar(){
           return car;
        }
    }
}
