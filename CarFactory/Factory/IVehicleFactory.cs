using CarFactory.Models;

namespace CarFactory.Factory;

public interface IVehicleFactory
{
    public Vehicle MakeSport(Vehicle vehicle);
    public Vehicle MakeOffroad(Vehicle vehicle);
    public Vehicle MakeClassic(Vehicle vehicle);    
}