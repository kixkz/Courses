using System;

namespace VehiclesExtension
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQty = double.Parse(carInfo[1]);
            double carLitersPerKm = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQty = double.Parse(truckInfo[1]);
            double truckLitersPerKm = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(carInfo[3]);

            double busFuelQty = double.Parse(busInfo[1]);
            double busLitersPerKm = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Car car = new Car(carTankCapacity, carFuelQty, carLitersPerKm);
            Truck truck = new Truck(truckTankCapacity, truckFuelQty, truckLitersPerKm);
            Bus bus = new Bus(busTankCapacity, busFuelQty, busLitersPerKm);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] command = Console.ReadLine().Split();

                    string action = command[0];
                    string vehicle = command[1];
                    double value = double.Parse(command[2]);

                    IVehicle currVehicle = GetVehicleType(car, truck, bus, vehicle);

                    if (action == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            if (currVehicle.CanDrive(value))
                            {
                                currVehicle.Drive(value);
                                Console.WriteLine($"{vehicle} travelled {value} km");
                            }
                            else
                            {
                                Console.WriteLine($"{vehicle} needs refueling");
                            }
                        }
                    }
                    else if (action == "DriveEmpty")
                    {
                        bus.IsEmpty = true;

                        if (currVehicle.CanDrive(value))
                        {
                            currVehicle.Drive(value);
                            bus.IsEmpty = false;
                            Console.WriteLine($"{vehicle} travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine($"{vehicle} needs refueling");
                        }
                    }
                    else
                    {
                        if (currVehicle.CanRefuel(value))
                        {
                            currVehicle.Refuel(value);
                        }
                        else
                        {
                            Console.WriteLine($"Cannot fit {value} fuel in the tank");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }

        private static IVehicle GetVehicleType(Car car, Truck truck, Bus bus, string vehicle)
        {
            if (vehicle == "Car")
            {
                return car;
            }
            else if (vehicle == "Truck")
            {
                return truck;
            }

            return bus;
        }
    }
}
