using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.Modern;

public class ModernCarFactory : IModernFactory
{
    private readonly CarFactory _carFactory;

    public ModernCarFactory(CarFactory carFactory)
    {
        _carFactory = carFactory;
    }

    public Vehicle CreateModern()
    {
        var car = _carFactory.Build();
        car.Doors = 4;
        car.Style = Style.Modern;
        car.Comfort = Comfort.Luxury;
        MakeElectric(car);
        return car;
    }

    public Vehicle MakeSport(Vehicle vehicle)
    {
        vehicle.Style = Style.Sport;
        vehicle.Comfort = Comfort.Okay;
        vehicle.Model = "RS";
        vehicle.HorsePower = new Random().Next(250, 300);
        return vehicle;
    }

    public Vehicle MakeOffroad(Vehicle vehicle)
    {
        vehicle.Style = Style.Offroad;
        vehicle.Comfort = Comfort.VIP;
        vehicle.Model = "Offroad";
        vehicle.HorsePower = new Random().Next(150, 200);
        return vehicle;
    }

    public Vehicle MakeClassic(Vehicle vehicle)
    {
        vehicle.Style = Style.Classic;
        vehicle.Comfort = Comfort.Rough;
        vehicle.ProductionYear = 1980;
        vehicle.HorsePower = new Random().Next(50, 100);
        vehicle.Model = "Retro";
        return vehicle;
    }

    public Vehicle MakeElectric(Vehicle vehicle)
    {
        vehicle.IsElectric = true;
        vehicle.Model = "E-Model";
        return vehicle;
    }

    public Vehicle BuildCustom()
    {
        var car = _carFactory.Build();

        var terminate = false;
        while (!terminate)
        {
            try
            {
                Console.WriteLine("Welcome to building your own car\n");

                Console.Write("Select the type of car you want to build:" +
                              " \n (1) Create Modern" +
                              " \n (2) Make Sport" +
                              " \n (3) Make Offroad" +
                              " \n (4) Make Classic" +
                              " \n (5) Make Electric" +
                              " \n (6) Quit \n"
                );
                
                Console.WriteLine("");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateModern();
                        break;
                    case 2:
                        MakeSport(car);
                        break;
                    case 3:
                        MakeOffroad(car);
                        break;
                    case 4:
                        MakeClassic(car);
                        break;
                    case 5:
                        MakeElectric(car);
                        break;
                    case 6:
                        terminate = true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input \n");
                continue;
            }
        }

        return car;
    }
}