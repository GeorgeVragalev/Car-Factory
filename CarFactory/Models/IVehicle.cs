namespace CarFactory.Models;

public interface IVehicle
{
    public Vehicle Clone();
    public void Drive();
    
}