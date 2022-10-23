using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory;

public class CarFactory : VehicleFactory
{
    public override Car Build()
    {
        var car = new Car();
        car.Body = (CarBody) new Random().Next(1, 5);
        car.Doors = 4;
        car.ProductionYear = 2022;
        car.IsElectric = false;
        car.Manufacturer = "Porsche";
        car.HorsePower = new Random().Next(80, 130);
        car.Model = "New";
        car.Comfort = (Comfort) new Random().Next(1, 5);
        car.Style = (Style) new Random().Next(1, 4);
        car.Color = (Color) new Random().Next(1, 9);
        return car;
    }
}