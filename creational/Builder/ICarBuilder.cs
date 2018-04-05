
using Builder;

interface ICarBuilder
{
    void BuildWheelType();
    void BuildHP();
    void BuildBrand();
    void BuildConvertible();
    Car GetCar();
}