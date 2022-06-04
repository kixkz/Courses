using System;
using System.Collections.Generic;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            double carsHorsePower = 0;
            double trucksHorsePower = 0;

            while (input != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string model = tokens[1];
                string color = tokens[2];
                double horsePower = double.Parse(tokens[3]);
                if (type == "car")
                {
                    Car newCar = new Car(model, color, horsePower);
                    catalog.Cars.Add(newCar);
                    carsHorsePower += horsePower;
                }

                if (type == "truck")
                {
                    Truck newTruck = new Truck(model, color, horsePower);
                    catalog.Trucks.Add(newTruck);
                    trucksHorsePower += horsePower;
                }

                input = Console.ReadLine();
            }

            List<Car> cars = catalog.Cars;
            List<Truck> trucks = catalog.Trucks;

            string command;
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car car in cars)
                {
                    if (command == car.Model)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.HorsePower}");
                    }
                }

                foreach (Truck truck in trucks)
                {
                    if (command == truck.Model)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.HorsePower}");
                    }
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHorsePower / cars.Count:f2}.");
            }
            else if (cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsePower / trucks.Count:f2}.");
            }
            else if (trucks.Count == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
        }
    }
}
