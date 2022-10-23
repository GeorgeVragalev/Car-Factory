using System.Drawing;
using CarFactory.Models.Enums;
using Color = CarFactory.Models.Enums.Color;

namespace CarFactory.Models;

public abstract class Vehicle : IVehicle
{
    protected Vehicle()
    {
        
    }
    protected Vehicle(Vehicle vehicle)
    {
        Wheels = vehicle.Wheels;
        HorsePower = vehicle.HorsePower;
        ProductionYear = vehicle.ProductionYear;
        Color = vehicle.Color;
        Model = vehicle.Model;
        Manufacturer = vehicle.Manufacturer;
    }

    public int Wheels { get; set; }
    public int HorsePower { get; set; }
    public int ProductionYear { get; set; }
    public Color Color  { get; set; }
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public Style Style { get; set; }
    public Comfort Comfort { get; set; }
    public bool IsElectric { get; set; }
    public bool HasABS { get; set; }

    public abstract Vehicle Clone();
    public abstract void Drive();
}