public abstract class VehicleDecorator : Vehicle
{
    private Vehicle vehicle;

    public VehicleDecorator(Vehicle _vehicle){
        vehicle = _vehicle;
    }
    public string Make
    {
        get
        {
            return vehicle.Make;
        }
    }

    public string Model {
        get
        {
            return vehicle.Model;
        }
    }

    public double Price {
        get
        {
            return vehicle.Price;
        }
    }
}