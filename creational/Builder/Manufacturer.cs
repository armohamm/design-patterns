using System;

namespace Builder
{
    class Manufacturer
    {
        public void Construct(ICarBuilder carBuilder)
        {
            carBuilder.BuildWheelType();
            carBuilder.BuildHP();
            carBuilder.BuildBrand();
            carBuilder.BuildConvertible();
        }
    }
}
