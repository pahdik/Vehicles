using Vehicles.Vehicles.Base;
using Vehicles.Vehicles;

namespace Vehicles;

class Program
{
    static void Main()
    {
        InstanceService instanceService = new InstanceService();

        IEnumerable<Vehicle> vehicles = instanceService.GetInstances<Vehicle>();

        var sortedTypes = vehicles.Select(vehicle => vehicle.Type).OrderBy(type => type);

        foreach (var typeName in sortedTypes)
        {
            Console.WriteLine(typeName);
        }
    }
}
