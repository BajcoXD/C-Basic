
using ConsoleApp.Models;

// Create four drivers
Driver[] drivers = {
            new Driver("Bob", 5),
            new Driver("Greg", 7),
            new Driver("Jill", 6),
            new Driver("Anne", 8)
        };

// Create four cars (without assigning drivers initially)
Car[] cars = {
            new Car("Hyundai", 120, null),
            new Car("Mazda", 140, null),
            new Car("Ferrari", 180, null),
            new Car("Porsche", 200, null)
        };

bool raceAgain = true;

while (raceAgain)
{
    // Let user select car 1
    Console.WriteLine("\nChoose a car no.1:");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }
    int car1Index = int.Parse(Console.ReadLine()) - 1;

    // Let user select driver for car 1
    Console.WriteLine("\nChoose a driver for car no.1:");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int driver1Index = int.Parse(Console.ReadLine()) - 1;

    // Assign selected driver to selected car
    cars[car1Index].Driver = drivers[driver1Index];

    // Let user select car 2
    Console.WriteLine("\nChoose a car no.2:");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }
    int car2Index = int.Parse(Console.ReadLine()) - 1;

    // Let user select driver for car 2
    Console.WriteLine("\nChoose a driver for car no.2:");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int driver2Index = int.Parse(Console.ReadLine()) - 1;

    // Assign selected driver to selected car
    cars[car2Index].Driver = drivers[driver2Index];

    // Race the two selected cars
    Car.RaceCars(cars[car1Index], cars[car2Index]);

    // Ask if the user wants to race again
    Console.WriteLine("\nDo you want to race again? (yes/no)");
    string response = Console.ReadLine().ToLower();

    if (response != "yes")
    {
        raceAgain = false;
        Console.WriteLine("\n🏁 Thanks for playing! Goodbye! 🏁");
    }
}