using Vehicles.Vehicles.Base;

namespace Vehicles.Vehicles;

public class Bicycle : Vehicle
{
    public Bicycle()
    {
        Type = "Bicycle";
        MaxSpeed = 25;
    }
}