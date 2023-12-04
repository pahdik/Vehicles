namespace Vehicles.Vehicles.Base;

public abstract class Vehicle
{
    public string Type { get; protected set; }
    public int MaxSpeed { get; protected set; }
}