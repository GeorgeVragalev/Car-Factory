using CarFactory.Factory.Modern;
using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.TeslaBuilder;

public class TeslaCarBuilder : ModernCarFactory, ITeslaBuilder
{
    private readonly CarFactory _carFactory;
    public TeslaCarBuilder(CarFactory carFactory) : base(carFactory)
    {
        _carFactory = carFactory;
    }

    public Car BuildModelS()
    {
        var modelS = _carFactory.Build();
        SetEngine(modelS, 350, true, true);
        SetModel(modelS, ITeslaBuilder.Manufacturer, "Model S", 2022);
        SetStyle(modelS, Style.Modern, Comfort.VIP, Color.Blue);
        modelS.Body = CarBody.Sedan;
        return modelS;
    }
    
    //build model X, Y
    
    public void SetEngine(Vehicle vehicle, int hp, bool hasAbs, bool isElectric = true)
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