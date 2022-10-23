using CarFactory.Factory;
using CarFactory.Factory.BmwBuilder;
using CarFactory.Factory.Modern;
using CarFactory.Factory.TeslaBuilder;
using CarFactory.Models;

namespace CarFactory;

public static class Application
{
    public static void Main(string[] args)
    {
        var carFactory = new Factory.CarFactory();
        var modernCarFactory = new ModernCarFactory(carFactory);
        
        var motorcycleFactory = new Factory.MotorcycleFactory();
        var modernMotorCycleFactory = new ModernMotorcycleFactory(motorcycleFactory);

        var bmwCarBuilder = new BmwCarBuilder(carFactory);
        var bmwMotorcycleBuilder = new BmwMotorcycleBuilder(motorcycleFactory);
        var teslaFactory = new TeslaCarBuilder(carFactory);

        Vehicles.GetVehicles();

        var originalCar = carFactory.Build();
        var cloneCar = originalCar.Clone();
        
        Vehicles.AddVehicle(cloneCar);
        
        var terminate = false;
        while (!terminate)
        {
            Console.Write("Select what you want to build:" +
                          " \n (1) Custom Car" +
                          " \n (2) Custom Motorcycle" +
                          " \n (3) Bmw M5" +
                          " \n (4) Bmw SR1000" +
                          " \n (5) Tesla Model S" +
                          " \n (6) Modern Sport Car" +
                          " \n (7) Modern Offroad motorcycle" +
                          " \n (8) Random motorcycle" +
                          " \n (9) Random car" +
                          " \n (10) Quit \n"
            );
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (choice)
            {
                case 1:
                    var customCar = modernCarFactory.BuildCustom();
                    customCar.Drive();
                    Vehicles.AddVehicle(customCar);
                    break;
                case 2:
                    var customMotorcycle = modernMotorCycleFactory.BuildCustom();
                    customMotorcycle.Drive();
                    Vehicles.AddVehicle(customMotorcycle);
                    break;
                case 3:
                    var m5 = bmwCarBuilder.BuildM5();
                    m5.Drive();
                    Vehicles.AddVehicle(m5);
                    break;
                case 4:
                    var sr1000 = bmwMotorcycleBuilder.BuildSR1000();
                    sr1000.Drive();
                    Vehicles.AddVehicle(sr1000);
                    break;
                case 5:
                    var tesla = teslaFactory.BuildModelS();
                    tesla.Drive();
                    Vehicles.AddVehicle(tesla);
                    break;
                case 6:
                    var carModern = modernCarFactory.CreateModern();
                    modernCarFactory.MakeSport(carModern);
                    carModern.Drive();
                    Vehicles.AddVehicle(carModern);
                    break;
                case 7:
                    var motorcycle = motorcycleFactory.Build();
                    motorcycle.Drive();
                    Vehicles.AddVehicle(motorcycle);
                    break;
                case 8:
                    var car = carFactory.Build();
                    car.Drive();
                    Vehicles.AddVehicle(car);
                    break;
                case 10:
                    terminate = true;
                    break;
                default:
                    break;
            }
            
            Vehicles.ShowVehicles();
        }
        
    }
}