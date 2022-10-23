using CarFactory.Models;

namespace CarFactory.Factory.BmwBuilder;

public interface IBmwBuilder : IVehicleBuilder
{
    public static string Manufacturer = "BMW";
    public Vehicle BuildBaseBmw();
}