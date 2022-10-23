using System.Collections.ObjectModel;
using CarFactory.Models;

namespace CarFactory.Factory;

public class Vehicles
{
    private static IList<Vehicle> _vehicles;

    public static IList<Vehicle> GetVehicles()
    {
        if (_vehicles == null)
        {
            _vehicles = new List<Vehicle>();
        }

        return _vehicles;
    }

    public static void AddVehicle(Vehicle vehicle)
    {
        _vehicles.Add(vehicle);
    }
    
    public static void ShowVehicles()
    {
        Console.WriteLine("Vehicles list:");
        foreach (var vehicle in _vehicles)
        {
            Console.WriteLine($"{vehicle.Manufacturer} Model: {vehicle.Model}" );
        }
    }
}