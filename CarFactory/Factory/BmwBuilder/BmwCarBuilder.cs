using CarFactory.Factory.Modern;
using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.BmwBuilder;

public class BmwCarBuilder : ModernCarFactory, IBmwBuilder
{
    private readonly CarFactory _carFactory;
    public BmwCarBuilder(CarFactory carFactory) : base(carFactory)
    {
        _carFactory = carFactory;
    }

    public Car BuildM5()
    {
        var m5 = _carFactory.Build();

        SetEngine(m5, 245, true);
        SetStyle(m5, Style.Sport, Comfort.Luxury, Color.White);
        SetModel(m5, IBmwBuilder.Manufacturer, "M5 Performance", 2022);
        m5.Doors = 4;
        m5.Body = CarBody.Sedan;

        return m5;
    }
    
    public Vehicle BuildBaseBmw()
    {
        var bmw = _carFactory.Build();
        bmw.Manufacturer = IBmwBuilder.Manufacturer;
        return bmw;
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
}