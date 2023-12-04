using Vehicles.Vehicles.Base;

namespace Vehicles.Vehicles;

public class Car : Vehicle
{
    public Car()
    {
        Type = "Car";
        MaxSpeed = 150;
    }
}
