namespace CarFactory.Models;

public class Car : Vehicle
{
    public int Doors { get; set; }
    public Car()
    {
        Wheels = 4;
    }
    public Car(Car car) : base(car)
    {
        Wheels = 4;
    }

    public override Vehicle Clone()
    {
        return new Car(this);
    }

    public override void Drive()
    {
        Console.WriteLine($"I am driving a {Color} {Style} {Model} model {(IsElectric? "Electric" : "Fuel")} {Doors} door car with {Comfort} comfort rating and a {HorsePower} horsepower engine");
    }
}