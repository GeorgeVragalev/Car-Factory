using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory;

public class MotorcycleFactory : VehicleFactory
{
    public override Motorcycle Build()
    {
        var motorcycle = new Motorcycle();
        motorcycle.MotorcycleType = (MotorcycleType) new Random().Next(1, 5); 
        motorcycle.IsElectric = false;
        motorcycle.ProductionYear = 2023;
        motorcycle.Manufacturer = "Yamaha";
        motorcycle.HorsePower = new Random().Next(20, 80);
        motorcycle.Model = "New";
        motorcycle.Comfort = (Comfort) new Random().Next(1, 5);
        motorcycle.Style = (Style) new Random().Next(1, 4);
        motorcycle.Color = (Color) new Random().Next(1, 9);
        return motorcycle;
    }
}