using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string userName = input[1];
                if (command == "register")
                {
                    string licensePlateNumber = input[2];
                    if (parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parking.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!parking.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        parking.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                }
            }

            foreach (var car in parking)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
