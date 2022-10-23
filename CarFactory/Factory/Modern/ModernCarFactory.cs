using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.Modern;

public class ModernCarFactory : IModernFactory
{
    private readonly CarFactory _carFactory;

    public ModernCarFactory(CarFactory carFactory)
    {
        _carFactory = carFactory;
    }

    public Vehicle CreateModern()
    {
        var car = _carFactory.Build();
        car.Doors = 4;
        car.Style = Style.Modern;
        car.Comfort = Comfort.Luxury;
        MakeElectric(car);
        return car;
    }

    public Vehicle MakeSport(Vehicle vehicle)
    {
        vehicle.Style = Style.Sport;
        vehicle.Comfort = Comfort.Okay;
        vehicle.Model = "Sport";
        vehicle.HorsePower = new Random().Next(250, 300);
        return vehicle;
    }

    public Vehicle MakeOffroad(Vehicle vehicle)
    {
        vehicle.Style = Style.Offroad;
        vehicle.Comfort = Comfort.VIP;
        vehicle.Model = "Offroad";
        vehicle.HorsePower = new Random().Next(150, 200);
        return vehicle;
    }

    public Vehicle MakeClassic(Vehicle vehicle)
    {
        vehicle.Style = Style.Classic;
        vehicle.Comfort = Comfort.Rough;
        vehicle.ProductionYear = 1980;
        vehicle.HorsePower = new Random().Next(50, 100);
        vehicle.Model = "Retro";
        return vehicle;
    }

    public Vehicle MakeElectric(Vehicle vehicle)
    {
        vehicle.IsElectric = true;
        vehicle.Model = "E-Model";
        return vehicle;
    }
}