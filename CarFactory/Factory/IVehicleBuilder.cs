using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory;

public interface IVehicleBuilder
{
    public void SetEngine(Vehicle vehicle, int hp, bool hasAbs, bool isElectric = false);
    public void SetStyle(Vehicle vehicle, Style style, Comfort comfort, Color color);
    public void SetModel(Vehicle vehicle, string manufacturer, string model, int productionYear);
}