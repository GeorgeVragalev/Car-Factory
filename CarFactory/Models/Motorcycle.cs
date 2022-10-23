namespace CarFactory.Models;

public class Motorcycle : Vehicle
{
    public TYPE Type { get; set; }
    
    public Motorcycle()
    {
        Wheels = 2;
    }
    public Motorcycle(Vehicle vehicle) : base(vehicle)
    {
        Wheels = 2;
    }

    public override Vehicle Clone()
    {
        return new Motorcycle(this);
    }

    public override void Drive()
    {
        Console.WriteLine($"I am driving a {Color} {Style} {Model} model  {(IsElectric ? "Electric" : "Fuel")} motorcycle with {Comfort} comfort rating and a {HorsePower} horsepower engine");
    }
}