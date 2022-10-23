using CarFactory.Models;

namespace CarFactory.Factory;

public abstract class VehicleFactory
{
    public abstract Vehicle Build();
}