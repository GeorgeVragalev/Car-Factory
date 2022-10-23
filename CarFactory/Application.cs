using CarFactory.Factory;
using CarFactory.Factory.Modern;
using CarFactory.Models;

namespace CarFactory;

public static class Application
{
    public static void Main(string[] args)
    {
        // //Call factories and create vehicles 
        // var car = new Car();
        //
        // var car2 = car.Clone();
        // Console.WriteLine(car2.Wheels);
        //
        // var motorcycle = new Motorcycle();
        //
        // var m2 = motorcycle.Clone();
        // Console.WriteLine(motorcycle.Wheels);
        // Console.WriteLine(m2.Wheels);


        var carFactory = new Factory.CarFactory();
        var modernCarFactory = new ModernCarFactory(carFactory);

        var car = modernCarFactory.CreateModern();
        modernCarFactory.MakeSport(car);
        car.Drive();


        var motorcycleFactory = new Factory.MotorcycleFactory();
        var modernMotorCycleFactory = new ModernMotorcycleFactory(motorcycleFactory);

        var motorcycle = modernMotorCycleFactory.CreateModern();
        modernMotorCycleFactory.MakeOffroad(motorcycle);
        motorcycle.Drive();
        Console.WriteLine(car.Wheels);
    }
}