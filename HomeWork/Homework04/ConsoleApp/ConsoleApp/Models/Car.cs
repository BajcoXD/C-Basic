using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Car
    {
        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }
        public static void RaceCars(Car car1, Car car2)
        {
            int speed1 = car1.CalculateSpeed();
            int speed2 = car2.CalculateSpeed();

            Console.WriteLine($"\n🏁 Race Start! 🏁");
            Console.WriteLine($"{car1.Driver.Name} ({car1.Model}) Speed: {speed1}");
            Console.WriteLine($"{car2.Driver.Name} ({car2.Model}) Speed: {speed2}");

            if (speed1 > speed2)
            {
                Console.WriteLine($"\n🚗💨 {car1.Model} driven by {car1.Driver.Name} wins the race!");
            }
            else if (speed2 > speed1)
            {
                Console.WriteLine($"\n🚗💨 {car2.Model} driven by {car2.Driver.Name} wins the race!");
            }
            else
            {
                Console.WriteLine("\n🏁 It's a tie!");
            }
        }

    }
}

