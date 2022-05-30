using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] command = input.Split("/");
                

                if (command[0] == "Car")
                {
                    string brand = command[1];
                    string model = command[2];
                    int horsePower = int.Parse(command[3]);
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
                else if (command[0] == "Truck")
                {
                    string brand = command[1];
                    string model = command[2];
                    int weight = int.Parse(command[3]);
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalog.Cars.OrderBy(car => car.Brand).ToList();

                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalog.Trucks.OrderBy(truck => truck.Brand).ToList();

                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            
        }
    }
}
