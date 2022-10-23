using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.Modern;

public class ModernMotorcycleFactory : IModernFactory
{
    private readonly MotorcycleFactory _motorcycleFactory;

    public ModernMotorcycleFactory(MotorcycleFactory motorcycleFactory)
    {
        _motorcycleFactory = motorcycleFactory;
    }

    public Vehicle CreateModern()
    {
        var motorcycle = _motorcycleFactory.Build();
        motorcycle.Style = Style.Modern;
        motorcycle.Comfort = Comfort.Luxury;
        MakeElectric(motorcycle);
        return motorcycle;
    }

    public Vehicle MakeSport(Vehicle vehicle)
    {
        vehicle.Style = Style.Sport;
        vehicle.Comfort = Comfort.Okay;
        vehicle.Model = "Sport";
        vehicle.HorsePower = new Random().Next(100, 150);
        return vehicle;
    }

    public Vehicle MakeOffroad(Vehicle vehicle)
    {
        vehicle.Style = Style.Offroad;
        vehicle.Comfort = Comfort.Rough;
        vehicle.Model = "Enduro";
        vehicle.HorsePower = new Random().Next(50, 100);
        return vehicle;    
    }

    public Vehicle MakeClassic(Vehicle vehicle)
    {
        vehicle.Style = Style.Classic;
        vehicle.Comfort = Comfort.Rough;
        vehicle.ProductionYear = 2000;
        vehicle.HorsePower = new Random().Next(50, 100);
        vehicle.Model = "Chopper";
        return vehicle;    
    }

    public Vehicle MakeElectric(Vehicle vehicle)
    {
        vehicle.IsElectric = true;
        vehicle.Model = "E";
        vehicle.HorsePower = new Random().Next(150, 200);
        return vehicle;
    }
}