using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;

namespace T1_OOP.ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bandera = 0;
            while (bandera < 10)
            {
                Console.WriteLine("Type a vehicle");

                string animalType = Console.ReadLine().ToLower();

                Vehicles vehicle = null;

                switch (animalType)
                {
                    case "truck":
                        vehicle = new Truck();
                        break;

                    case "car":
                        vehicle = new Car();
                        break;

                    case "train":
                        vehicle = new Train();
                        break;

                    default:
                        Console.WriteLine("Vehicle not found");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }

                if (vehicle != null)
                {
                    vehicle.VehicleSound();
                    bandera++;
                }
            }
        }
    }
}
