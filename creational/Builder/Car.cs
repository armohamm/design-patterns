using System;

namespace Builder
{
    public class Car
    {
        public string carName;
        public string WheelType {get;set;}
        public int HP {get;set;}
        public string Brand {get;set;}
        public bool Convertible {get;set;}

        public Car(string name){
            this.carName = name;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nHP: {1}\nBrand {2}\nConvertible: {3}\nWheelType: {4}",
                carName, HP, Brand, Convertible, WheelType);
        }
    }
}
