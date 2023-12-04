using System.Reflection;
using Vehicles.Vehicles.Base;

namespace Vehicles;

public class InstanceService
{
    public IEnumerable<T> GetInstances<T>() 
    {
        var vehicleTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => typeof(T).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

        List<T> instances = new List<T>();
        foreach (var type in vehicleTypes)
        {
            var instance = (T)Activator.CreateInstance(type);
            instances.Add(instance);
        }

        return instances;
    }

    public List<Type> SearchTypesByName(string partialName)
    {
        var vehicleTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => typeof(Vehicle).IsAssignableFrom(type) 
                && !type.IsInterface 
                && !type.IsAbstract 
                && type.Name.Contains(partialName))
            .ToList();

        return vehicleTypes;
    }

    public void WriteInstancesToDisk(IEnumerable<Vehicle> instances, string directoryPath)
    {
        foreach (var instance in instances)
        {
            string filePath = Path.Combine(directoryPath, $"{instance.Type}.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Type: {instance.Type}");
                writer.WriteLine($"Max Speed: {instance.MaxSpeed}");
                writer.WriteLine();
            }
        }
    }
}
