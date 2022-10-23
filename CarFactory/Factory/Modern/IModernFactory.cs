using CarFactory.Models;

namespace CarFactory.Factory.Modern;

public interface IModernFactory : IVehicleFactory
{
    public Vehicle CreateModern();
    public Vehicle MakeElectric(Vehicle vehicle);
}