using System;

namespace Builder
{
    public class BMWCar : ICarBuilder
    {
        Car car;

        public BMWCar(){
            car = new Car("BMW Car");
        }

        public void BuildWheelType()
        {
            car.WheelType = "4 Big Wheels";
        }

        public void BuildHP()
        {
            car.HP = 300;
        }

        public void BuildBrand()
        {
            car.Brand = "BMW";
        }

        public void BuildConvertible()
        {
            car.Convertible = true;
        }

        public Car GetCar(){
           return car;
        }
    }
}
