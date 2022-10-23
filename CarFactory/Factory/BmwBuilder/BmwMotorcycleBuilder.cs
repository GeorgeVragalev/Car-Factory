using CarFactory.Factory.Modern;
using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.BmwBuilder;

public class BmwMotorcycleBuilder : ModernMotorcycleFactory, IBmwBuilder
{
    private readonly MotorcycleFactory _motorcycleFactory;
    public BmwMotorcycleBuilder(MotorcycleFactory motorcycleFactory) : base(motorcycleFactory)
    {
        _motorcycleFactory = motorcycleFactory;
    }

    public Vehicle BuildSR1000()
    {
        var sr1000 = _motorcycleFactory.Build();
        sr1000.MotorcycleType = MotorcycleType.Sport;
        SetEngine(sr1000, 199, true);
        SetStyle(sr1000, Style.Sport, Comfort.Luxury, Color.Black);
        SetModel(sr1000, "BMW", "SR 1000", 2022);

        return sr1000;
    }

    public void SetEngine(Vehicle vehicle, int hp, bool hasAbs, bool isElectric = false)
    {
        vehicle.HorsePower = hp;
        vehicle.HasABS = hasAbs;
        vehicle.IsElectric = isElectric;
    }

    public void SetStyle(Vehicle vehicle, Style style, Comfort comfort, Color color)
    {
        vehicle.Style = style;
        vehicle.Comfort = comfort;
        vehicle.Color = color;
    }

    public void SetModel(Vehicle vehicle, string manufacturer, string model, int productionYear)
    {
        vehicle.Model = model;
        vehicle.Manufacturer = manufacturer;
        vehicle.ProductionYear = productionYear;
    }

    public Vehicle BuildBaseBmw()
    {
        var bmw = _motorcycleFactory.Build();
        bmw.Manufacturer = IBmwBuilder.Manufacturer;
        return bmw;
    }
}