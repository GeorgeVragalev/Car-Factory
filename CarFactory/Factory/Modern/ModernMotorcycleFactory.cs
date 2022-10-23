using CarFactory.Models;
using CarFactory.Models.Enums;

namespace CarFactory.Factory.Modern;

public class ModernMotorcycleFactory : IModernFactory
{
    private readonly MotorcycleFactory _motorcycleFactory;

    public ModernMotorcycleFactory(MotorcycleFactory motorcycleFactory)
    {
        _motorcycleFactory = motorcycleFactory;
    }

    public Vehicle CreateModern()
    {
        var motorcycle = _motorcycleFactory.Build();
        motorcycle.Style = Style.Modern;
        motorcycle.Comfort = Comfort.Luxury;
        MakeElectric(motorcycle);
        return motorcycle;
    }

    public Vehicle MakeSport(Vehicle vehicle)
    {
        vehicle.Style = Style.Sport;
        vehicle.Comfort = Comfort.Okay;
        vehicle.Model = "Sport";
        vehicle.HorsePower = new Random().Next(100, 150);
        return vehicle;
    }

    public Vehicle MakeOffroad(Vehicle vehicle)
    {
        vehicle.Style = Style.Offroad;
        vehicle.Comfort = Comfort.Rough;
        vehicle.Model = "Enduro";
        vehicle.HorsePower = new Random().Next(50, 100);
        return vehicle;    
    }

    public Vehicle MakeClassic(Vehicle vehicle)
    {
        vehicle.Style = Style.Classic;
        vehicle.Comfort = Comfort.Rough;
        vehicle.ProductionYear = 2000;
        vehicle.HorsePower = new Random().Next(50, 100);
        vehicle.Model = "Chopper";
        return vehicle;    
    }

    public Vehicle MakeElectric(Vehicle vehicle)
    {
        vehicle.IsElectric = true;
        vehicle.Model = "E";
        vehicle.HorsePower = new Random().Next(150, 200);
        return vehicle;
    }

    public Vehicle BuildCustom()
    {
        var motorcycle = _motorcycleFactory.Build();

        var terminate = false;
        while (!terminate)
        {
            try
            {
                Console.WriteLine("Welcome to building your own motorcycle\n");

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
                        MakeSport(motorcycle);
                        break;
                    case 3:
                        MakeOffroad(motorcycle);
                        break;
                    case 4:
                        MakeClassic(motorcycle);
                        break;
                    case 5:
                        MakeElectric(motorcycle);
                        break;
                    case 6:
                        terminate = true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n");


                Console.WriteLine("Do you wish to continue building? (y) or (n): ");

                var continueOn = Console.ReadLine();
                if (continueOn.ToLower().Equals("n"))
                {
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("invalid input \n");
            }
        }

        return motorcycle;
    }
}